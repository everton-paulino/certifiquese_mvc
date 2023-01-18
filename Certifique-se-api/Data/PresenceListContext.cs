using Certifique_se_api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Certifique_se_api.Data
{
    public class PresenceListContext: DbContext
    {
        public DbSet <Course> Courses { get; set; }
        public DbSet <Customer> Customers { get; set; }
        public DbSet <instructor> Instructors { get; set; }
        public DbSet <PresenceList> PresenceLists { get; set; }
        public DbSet <Student> Students { get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Integrated Security=SSPI;Persist Security Info=False;User ID=adm;Initial Catalog=certifiquese;Data Source=DESKTOP-7REA1K7\\SQLEXPRESS");
        }
    }
}
