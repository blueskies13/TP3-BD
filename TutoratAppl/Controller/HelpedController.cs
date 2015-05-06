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
    class HelpedController
    {
        IEntityRepository<HelpedStudent> _helpedRepository { get;set; }
        void ListAll() { }
        HelpedController(IEntityRepository<HelpedStudent> helpedRepository)
        {
            _helpedRepository = helpedRepository;
        }

        void ListWhenWithoutTutoringSession() { }
    }
}
