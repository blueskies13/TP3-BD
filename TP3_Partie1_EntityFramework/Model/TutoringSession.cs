using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_Partie1_EntityFramework.Model
{
   public class TutoringSession : Entity
    {
        public DateTime DateSession { get; set; }
        public int TimeSession { get; set; }
        public int LenghtSession { get; set; }
        
        //Cle etrangere
        public Tutor Tutor { get; set; }
        public HelpedStudent Helped { get; set; }

        public int TutorId { get; set; }
        public int HelpedId { get; set; }

        public override String ToString()  {return DateSession.ToString() + " - "+ TimeSession + "h" +" - "+ LenghtSession + "(h)" + " - " + Helped.FirstName + "," + Helped.LastName + "," + Helped.EmailAddress + "," +
                                            " - " + Tutor.FirstName +"," + Tutor.LastName + "," + Tutor.EmailAddress; }
        

    }
}
