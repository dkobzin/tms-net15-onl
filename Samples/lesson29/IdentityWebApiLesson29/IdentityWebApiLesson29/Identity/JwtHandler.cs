using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace IdentityWebApiLesson29.Identity;

public class JwtHandler(IConfiguration configuration, UserManager<IdentityUser> userManager)
{
    public async Task<JwtSecurityToken> GetTokenAsync(IdentityUser user)
    {
        var jwt = new JwtSecurityToken(
            issuer: configuration["JwtSettings:Issuer"],
            audience: configuration["JwtSettings:Audience"],
            claims: await GetClaimsAsync(user),
            expires: DateTime.Now.AddMinutes(Convert.ToDouble(
                configuration["JwtSettings:ExpirationTimeInMinutes"])),
            signingCredentials: GetSigningCredentials());
        return jwt;
    }

    private SigningCredentials GetSigningCredentials()
    {
        var key = Encoding.UTF8.GetBytes(
            configuration["JwtSettings:SecurityKey"]!);
        var secret = new SymmetricSecurityKey(key);
        return new SigningCredentials(secret,
            SecurityAlgorithms.HmacSha256);
    }

    private async Task<List<Claim>> GetClaimsAsync(IdentityUser user)
    {
        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, user.Email!)
        };

        foreach (var role in await userManager.GetRolesAsync(user))
        {
            claims.Add(new Claim(ClaimTypes.Role, role));
        }
        return claims;
    }
}