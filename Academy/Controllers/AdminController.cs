using Academy.Models.Account;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Academy.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly UserManager<AcademyUser> userManager;

        public AdminController(UserManager<AcademyUser> userManager)
        {
            this.userManager = userManager;
        }



        public async Task<IActionResult> Users()
        {
            var users = (await userManager.GetUsersInRoleAsync("Guest")).ToList();

            return View(users);
        }



        public async Task<IActionResult> MakeTeacher(string username)
        {
            var user = await userManager.FindByNameAsync(username);

            var userChangeRole = await userManager.AddToRoleAsync(user, "Teacher");


         
                await userManager.RemoveFromRoleAsync(user, "Guest");
                var users = (await userManager.GetUsersInRoleAsync("Guest")).ToList();
                return View("Users", users);
           
        }



        public async Task<IActionResult> Teachers()
        {
            var users = (await userManager.GetUsersInRoleAsync("Teacher")).ToList();

            return View(users);
        }

        public async Task<IActionResult> MakeGuest(string username)
        {
            var user = await userManager.FindByNameAsync(username);

            var userChangeRole = await userManager.AddToRoleAsync(user, "Guest");


            await userManager.RemoveFromRoleAsync(user, "Teacher");
            var users = (await userManager.GetUsersInRoleAsync("Teacher")).ToList();
            return View("Teachers", users);
            
        }
    }
}
