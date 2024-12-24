using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERPRetailProAPI.BusinessLogics.Seeder
{
    public class RoleSeeder
    {
        public static async Task SeedRoles(IServiceProvider serviceProvider)
        {
            // Initializing custom roles 
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            string[] roleNames = { "Admin", "SuperAdmin" , "User"};
            IdentityResult roleResult;

            foreach (var roleName in roleNames)
            {
                // Check if the role exists; if not, create it
                var roleExist = await roleManager.RoleExistsAsync(roleName);
                if (!roleExist)
                {
                    roleResult = await roleManager.CreateAsync(new IdentityRole(roleName));
                }
            }
        }
    }
}
