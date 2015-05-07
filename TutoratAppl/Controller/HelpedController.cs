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

        public void ListWhenWithoutTutoringSession() 
        {
            var studentsList = _helpedRepository.GetAll();
            var helpedStudentsWithoutTutoringList = new List<HelpedListVM>();
            helpedStudentsWithoutTutoringList.Clear();
            
            foreach(HelpedStudent helpedStudent in studentsList)
            {
                if(helpedStudent.Sessions.Count() == 0)
                {
                    helpedStudentsWithoutTutoringList.Add(new HelpedListVM()

                    {
                        FirstName = helpedStudent.FirstName,
                        LastName = helpedStudent.LastName,
                        Id = helpedStudent.Id,
                        EmailAddress = helpedStudent.EmailAddress
                    }
                    );
                }
            }
            HelpedListView helpedListDisplay = new HelpedListView(helpedStudentsWithoutTutoringList);

            helpedListDisplay.Display();
        }
    }
}
