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
    class SessionController
    {
        IEntityRepository<TutoringSession> _sessionRepository { get; set; }
        void ListAll() { }
        SessionController(IEntityRepository<TutoringSession> sessionRepository)
        {
            _sessionRepository = sessionRepository;
        }
    }
}
