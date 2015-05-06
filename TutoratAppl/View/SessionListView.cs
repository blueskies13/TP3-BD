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

    public class SessionListView
    {
        public IEnumerable<SessionListVM> _sessionList { get; set; }
        public void Display()
        {
            var DbContext = new TutoringDbContext();
            foreach (var session in DbContext.TutoringSessions)
            {
                Console.WriteLine(session.ToString());
            }
            Console.ReadKey();

        }
         public SessionListView(IEnumerable<SessionListVM> sessionList)
        {
            _sessionList = sessionList;
        }
    }
}
