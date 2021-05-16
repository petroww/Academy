using Academy.Models.Account;
using Academy.Models.Courses;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Data
{
    public class ApplicationDbContext : IdentityDbContext<AcademyUser, AcademyRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Cours> Courses { get; set; }
    }
}
