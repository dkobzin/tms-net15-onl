using Microsoft.AspNetCore.Authorization;

namespace IdentityWebApiLesson29.Policies
{
    public class MinimumAgeRequirement : IAuthorizationRequirement
    {
        public MinimumAgeRequirement(int minimumAge) =>
            MinimumAge = minimumAge;

        public MinimumAgeRequirement()
        {
        }

        public int MinimumAge { get; }
    }
}
