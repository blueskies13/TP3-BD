using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3_Partie1_EntityFramework.EfEntityFramework;
using TutoratAppl.Controller;
using TP3_Partie1_EntityFramework.Model;

namespace TutoratAppl
{
    class Program
    {
        static void Main(string[] args)
        {
           var dataBaseHelper = new EfDataBaseHelper();
           dataBaseHelper.SeedTables();
           
           var Tutors = new EfEntityRepository<Tutor>();
           var tutorController = new TutorController(Tutors);
           var Students = new EfEntityRepository<HelpedStudent>();
           var studentController = new HelpedController(Students);
           var TutoringSession = new EfEntityRepository<TutoringSession>();
           var tutoringSessionController = new SessionController(TutoringSession);

           tutorController.ListAll();
           studentController.ListAll();
           tutoringSessionController.ListAll();
        }
    }
}
