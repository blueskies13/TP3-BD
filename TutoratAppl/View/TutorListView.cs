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
       public IEnumerable<TutorListVM> _tutorList { get; set; }

        public void Display() 
        { 
            var DbContext = new TutoringDbContext();
            foreach (var tutors in DbContext.Tutors)
            {
                Console.WriteLine(tutors.ToString());
            }
            Console.ReadKey(); 
        }
        public TutorListView(IEnumerable<TutorListVM> tutorList)
        {
            _tutorList = tutorList;
        }
    }
}
