﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PatientsApp.Server.Entities;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace PatientsApp.Server.Data
{
    public class Seed
    {
        //public static async Task SeedUsers(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        public static async Task SeedUsers(DataContext context)
        {
            if (await context.Users.AnyAsync()) return;

            var userData = await System.IO.File.ReadAllTextAsync("Data/UserSeedData.json");
            var users = JsonSerializer.Deserialize<List<AppUser>>(userData);
      
            if (users == null) return;

            foreach (var user in users)
            {
                using var hmac = new HMACSHA512();

                user.UserName = user.UserName.ToLower();
                user.PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("password"));
                user.PasswordSalt = hmac.Key;

                context.Users.Add(user);
            }

            await context.SaveChangesAsync();
        }
    }
}
