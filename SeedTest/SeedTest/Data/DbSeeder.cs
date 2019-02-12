using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SeedTest.Models;
using Microsoft.AspNetCore.Identity;


namespace SeedTest.Data
{
    public static class DbSeeder
    {
        public static void SeedDb(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            SeedContacts(context);
            SeedUsers(userManager);
        }

        private static void SeedUsers(UserManager<IdentityUser> userManager)
        {
            IdentityUser user = new IdentityUser
            {
                UserName = "vyshnavi@gmail.com",
                Email = "vyshnavi@gmail.com"
            };
            userManager.CreateAsync(user, "P@ssword123!").Wait();
        }

        private static void SeedContacts(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();
            context.Contacts.Add(
                new Contact() { Name = "Vyshnavi" }
            );
            context.SaveChanges();
        }
    }
}
