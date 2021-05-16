using Academy.Data;
using Academy.Models.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academy.Models.Courses;
using Microsoft.EntityFrameworkCore;

namespace Academy.Controllers
{
    public class CoursesController : Controller
    {
        private readonly UserManager<AcademyUser> userManager;
        private readonly ApplicationDbContext context;

        public CoursesController(UserManager<AcademyUser> userManager, ApplicationDbContext context)
        {
            this.userManager = userManager;
            this.context = context;
        }



        public async Task<ActionResult> ListOfCourses()
        {

            AcademyUser LogedUser = await userManager.FindByNameAsync(User.Identity.Name);
            string currentTeacherId = LogedUser.Id;

            List<Cours> listOfCourses = await context.Courses
                .Where(cours => cours.TeacherId == currentTeacherId)
                .ToListAsync();

            return View("CoursesList", listOfCourses);
        }




        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create(Cours cours)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            string takeName = User.Identity.Name;
            AcademyUser user = await userManager.FindByNameAsync(takeName);


            string currteacherId = user.Id;
            cours.TeacherId = currteacherId;


            context.Courses.Add(cours);
            await context.SaveChangesAsync();

            List<Cours> courseList = await context.Courses
                .Where(cours => cours.TeacherId == currteacherId)
                .ToListAsync();

            return View("CoursesList", courseList);
        }




        [HttpGet]
        public async Task<ActionResult> Edit(int coursId)
        {

            Cours currCours = await context.Courses.FindAsync(coursId);

            return View(currCours);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(Cours cours, int coursId)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            string takeName = User.Identity.Name;
            AcademyUser user = await userManager.FindByNameAsync(takeName);


            string currteacherId = user.Id;
            cours.TeacherId = currteacherId;
            cours.Id = coursId;

            context.Courses.Update(cours);
            await context.SaveChangesAsync();




            AcademyUser LogedUser = await userManager.FindByNameAsync(User.Identity.Name);
            string currentTeacherId = LogedUser.Id;

            List<Cours> listOfCourses = await context.Courses
                .Where(cours => cours.TeacherId == currentTeacherId)
                .ToListAsync();

            ViewData["success"] = "Успешно редактирахте курс";
            return View("CoursesList", listOfCourses);

        }



        public async Task<ActionResult> Delete(int coursId)
        {
            Cours currCours = await context.Courses.FindAsync(coursId);

            context.Courses.Remove(currCours);
            await context.SaveChangesAsync();



            List<Cours> listOfCourses = await context.Courses.ToListAsync();
            
            ViewData["delete"] = "Успешно изтриване на курс";
            return View("CoursesList", listOfCourses);
        }


        public  async Task<ActionResult> AdminListWithAllCourses()
        {
            List<Cours> listOfCourses = await context.Courses.ToListAsync();
           

            return View("CoursesList", listOfCourses);
        }


    }
}
