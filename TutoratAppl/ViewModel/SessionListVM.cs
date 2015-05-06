using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutoratAppl.ViewModel;
using TP3_Partie1_EntityFramework.Model;

namespace TutoratAppl.ViewModel
{
    public class SessionListVM
    {

        public string HelpedLastName { get; set; }
        public string HelpedFirstName { get; set; }
        public DateTime DateTimeSession { get; set; }
        public int LenghtSession { get; set; }

        public string TutorFirstName { get; set; }
        public string TutorLastName { get; set; }

        public Tutor TutorId { get; set; }
        public HelpedStudent HelpedId { get; set; }

        public override String ToString() { return DateTimeSession.ToString() + LenghtSession + "," + HelpedLastName + "," + HelpedFirstName + ","+ TutorFirstName +"," + TutorLastName ; }
    }
}
