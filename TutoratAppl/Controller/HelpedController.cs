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
    class HelpedController
    {
        IEntityRepository<HelpedStudent> _helpedRepository { get;set; }
       public void ListAll() 
        {
            var students = _helpedRepository.GetAll().ToList<HelpedStudent>();
            var studentsList = new List<HelpedListVM>();

            foreach (HelpedStudent s in students)
            {
                studentsList.Add(new HelpedListVM()
                {
                    EmailAddress = s.EmailAddress,
                    FirstName = s.FirstName,
                    LastName = s.LastName
                });
            }
            new HelpedListView(studentsList).Display();
        }
        public HelpedController(IEntityRepository<HelpedStudent> helpedRepository)
        {
            _helpedRepository = helpedRepository;
        }

        public void ListWhenWithoutTutoringSession() { }
    }
}
