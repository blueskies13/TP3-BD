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
        public void ListAllWithWorkingHoursTotal(){}
        public void ListWhenNextTutoringSession(){}
        public void ListWhenWithoutSession(DateTime sessionDate){}
    }
}
