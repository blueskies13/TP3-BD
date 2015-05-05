using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_Partie1_EntityFramework.Model
{
    public class Tutor: Entity
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string EmailAddress { get; set; }

        //propriété navigation
        public ICollection<TutoringSession> Sessions { get; set; }

        public override String ToString() { return Id + "," + LastName + "," + FirstName + "," + EmailAddress; }
    }
}
