using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3_Partie1_EntityFramework;
using TP3_Partie1_EntityFramework.EfEntityFramework;
using TP3_Partie1_EntityFramework.Model;
using TutoratAppl.View;
using TutoratAppl.ViewModel;

namespace TutoratAppl.Controller
{
    public class TutorController
    {

       public  IEntityRepository<Tutor> _tutorsRepository { get; set; }

        public TutorController(IEntityRepository<Tutor> tutorRepository)
        {
            _tutorsRepository = tutorRepository;
        }

        public void ListAll() 
        {
            var tutors =  _tutorsRepository.GetAll().ToList<Tutor>();
            var TutorList = new List<TutorListVM>();
         
            foreach(Tutor t in tutors)
            {
                TutorList.Add(new TutorListVM()
                {
                    EmailAddress = t.EmailAddress,
                    FirstName = t.FirstName,
                    LastName = t.LastName
                });
            }
           new TutorListView(TutorList).Display();
        }
        public void ListAllWithWorkingHoursTotal()
        {
            var tutors = _tutorsRepository.GetAll();
            var tutorHoursVM = new List<WorkingHoursTutorListVM>();
            foreach (Tutor tutor in tutors)
            {
                var totalHours = 0;

                foreach (TutoringSession student in tutor.Sessions)
                {
                    totalHours = totalHours + student.LenghtSession;
                }

                tutorHoursVM.Add(new WorkingHoursTutorListVM()
                {

                    EmailAdress = tutor.EmailAddress,
                    FirstName = tutor.FirstName,
                    LastName = tutor.LastName,
                    Id = tutor.Id,
                    NumberOfHours = totalHours
                });
            }

            var tutorHourView = new WorkingHoursTutorView(tutorHoursVM);

            tutorHourView.Display();
        }
   
        public void ListWhenNextTutoringSession()
        {
            var tutors = _tutorsRepository.GetAll();

            var tutorsSessionsVM = new List<SessionListVM>();

            foreach (Tutor tutor in tutors)
            {
                foreach (TutoringSession session in tutor.Sessions)
                {
                    if (session.DateSession > DateTime.Now)
                    {
                        tutorsSessionsVM.Add(new SessionListVM()
                        {
                            DateTimeSession = session.DateSession,
                            LenghtSession = session.LenghtSession,
                            HelpedFirstName = session.Helped.FirstName,
                            HelpedLastName = session.Helped.LastName,
                            TutorFirstName = tutor.FirstName,
                            TutorLastName = tutor.LastName
                        });
                    }

                }

            }
            tutorsSessionsVM.OrderBy(t => t.TutorLastName).ThenBy(ts => ts.DateTimeSession);
            SessionListView sessionsDisplay = new SessionListView(tutorsSessionsVM);
            sessionsDisplay.Display();
        }
        public void ListWhenWithoutSession(DateTime sessionDate){}
    }
}
