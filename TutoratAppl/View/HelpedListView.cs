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
     public class HelpedListView
    {
        public IEnumerable<HelpedListVM> _helpedList { get; set; }
        public void Display()
        {
            var DbContext = new TutoringDbContext();
            foreach (var students in DbContext.HelpedStudents)
            {
                Console.WriteLine(students.ToString());
            }
            Console.ReadKey();
        }
        public HelpedListView(IEnumerable<HelpedListVM> helpedList)
        {
            _helpedList = helpedList;
        }
    }
}
