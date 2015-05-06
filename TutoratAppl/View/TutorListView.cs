using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutoratAppl.ViewModel;
using TP3_Partie1_EntityFramework.EfEntityFramework;
using TP3_Partie1_EntityFramework.Model;
using TP3_Partie1_EntityFramework;

namespace TutoratAppl.View
{
   public class TutorListView
    {
        IEnumerable<TutorListVM> _tutorList { get; set; }

        void Display() 
        { 
            var DbContext = new TutoringDbContext();
            foreach (var tutors in DbContext.Tutors)
            {
                Console.WriteLine(tutors.ToString());
                DbContext.SaveChanges();
            }
            Console.ReadKey(); 
        }
        TutorListView(IEnumerable<TutorListVM> tutorList)
        {
            _tutorList = tutorList;
        }
    }
}
