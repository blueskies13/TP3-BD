using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3_Partie1_EntityFramework.EfEntityFramework;
using TP3_Partie1_EntityFramework.Model;

namespace TP3_Partie1_EntityFramework
{
    class TutoringDbContext : DbContext
    {

        public DbSet<Tutor> Tutors { get; set; }
        public DbSet<HelpedStudent> HelpedStudents { get; set; }
        public DbSet<TutoringSession> TutoringSessions { get; set; }
        static void Main(string[] args)
        {
            var EfDataBaseHelper = new EfDataBaseHelper();

            EfDataBaseHelper.SeedTables();

        }
    }
}
