using System.Security;
using IdentityWebApiLesson29.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityWebApiLesson29.Controllers;

[ApiController]
[Route("[controller]")]
public class DataSeedController(
    ApplicationDbContext context,
    RoleManager<IdentityRole> roleManager,
    UserManager<IdentityUser> userManager,
    IWebHostEnvironment env,
    IConfiguration configuration)
    : ControllerBase
{
    private readonly ApplicationDbContext _context = context;
    private readonly RoleManager<IdentityRole> _roleManager = roleManager;
    private readonly UserManager<IdentityUser> _userManager = userManager;
    private readonly IWebHostEnvironment _env = env;
    private readonly IConfiguration _configuration = configuration;

    [HttpGet]
    public async Task<ActionResult> CreateDefaultUsers()
    {
        if (!_env.IsDevelopment())
            return null!;
        
        // setup the default role names
        string role_RegisteredUser = "RegisteredUser";
        string role_Administrator = "Administrator";

        // create the default roles (if they don't exist yet)
        if (await _roleManager.FindByNameAsync(role_RegisteredUser) ==
            null)
            await _roleManager.CreateAsync(new
                IdentityRole(role_RegisteredUser));

        if (await _roleManager.FindByNameAsync(role_Administrator) ==
            null)
            await _roleManager.CreateAsync(new
                IdentityRole(role_Administrator));

        // create a list to track the newly added users
        var addedUserList = new List<IdentityUser>();

        // check if the admin user already exists
        var email_Admin = "admin@email.com";
        if (await _userManager.FindByNameAsync(email_Admin) == null)
        {
            // create a new admin ApplicationUser account
            var user_Admin = new IdentityUser
            {
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = email_Admin,
                Email = email_Admin,
            };

            // insert the admin user into the DB
            await _userManager.CreateAsync(user_Admin, _configuration["DefaultPasswords:Administrator"]);

            // assign the "RegisteredUser" and "Administrator" roles
            await _userManager.AddToRoleAsync(user_Admin,
                role_RegisteredUser);
            await _userManager.AddToRoleAsync(user_Admin,
                role_Administrator);

            // confirm the e-mail and remove lockout
            user_Admin.EmailConfirmed = true;
            user_Admin.LockoutEnabled = false;

            // add the admin user to the added users list
            addedUserList.Add(user_Admin);
        }

        // check if the standard user already exists
        var email_User = "user@email.com";
        if (await _userManager.FindByNameAsync(email_User) == null)
        {
            // create a new standard ApplicationUser account
            var user_User = new IdentityUser
            {
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = email_User,
                Email = email_User
            };

            // insert the standard user into the DB
            await _userManager.CreateAsync(user_User, _configuration["DefaultPasswords:RegisteredUser"]);

            // assign the "RegisteredUser" role
            await _userManager.AddToRoleAsync(user_User,
                role_RegisteredUser);

            // confirm the e-mail and remove lockout
            user_User.EmailConfirmed = true;
            user_User.LockoutEnabled = false;

            // add the standard user to the added users list
            addedUserList.Add(user_User);
        }

        // if we added at least one user, persist the changes into the DB
        if (addedUserList.Count > 0)
            await _context.SaveChangesAsync();

        return new JsonResult(new
        {
            addedUserList.Count,
            Users = addedUserList
        });
    }
}