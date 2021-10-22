using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUserAsync(UserManager<AppUser> userManager)
        {
            if(!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName="Jai",
                    Email="jai@test.com",
                    UserName="bob@test.com",
                    Address = new Address
                    {
                        FirstName="jai",
                        LastName="dev",
                        Street ="40 street",
                        City="Sec",
                        State="T",
                        ZipCode="111"
                    }
                };
                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}