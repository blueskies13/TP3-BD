using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3_Partie1_EntityFramework;
using TP3_Partie1_EntityFramework.EfEntityFramework;
using TP3_Partie1_EntityFramework.Model;
using TutoratAppl.ViewModel;
using TutoratAppl.View;

namespace TutoratAppl.Controller
{
    class SessionController
    {
        IEntityRepository<TutoringSession> _sessionRepository { get; set; }
        public void ListAll() 
        {
            var sessions = _sessionRepository.GetAll().ToList<TutoringSession>();
            var sessionList = new List<SessionListVM>();

            foreach (TutoringSession tuto in sessions)
            {
                sessionList.Add(new SessionListVM()
                {
                    HelpedId = tuto.Helped,
                    TutorId = tuto.Tutor,
                    HelpedFirstName = tuto.Helped.FirstName,
                    HelpedLastName = tuto.Helped.LastName,
                    DateTimeSession = tuto.DateSession,
                    LenghtSession = tuto.LenghtSession,
                    TutorFirstName = tuto.Tutor.FirstName,
                    TutorLastName = tuto.Tutor.LastName,
                });
            }
            new SessionListView(sessionList).Display();
        }
       public SessionController(IEntityRepository<TutoringSession> sessionRepository)
        {
            _sessionRepository = sessionRepository;
        }
    }
}
