using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3_Partie1_EntityFramework;
using TP3_Partie1_EntityFramework.EfEntityFramework;
using TP3_Partie1_EntityFramework.Model;

namespace TutoratAppl.Controller
{
    public class TutorController
    {

        IEntityRepository<Tutor> _tutorsRepository { get; set; }

        public TutorController(IEntityRepository<Tutor> tutorRepository)
        {
            _tutorsRepository = tutorRepository;
        }

        public void ListAll(){}
        public void ListAllWithWorkingHoursTotal(){}
        public void ListWhenNextTutoringSession(){}
        public void ListWhenWithoutSession(DateTime sessionDate){}
    }
}
