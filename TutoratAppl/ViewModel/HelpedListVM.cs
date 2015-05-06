using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutoratAppl.ViewModel;

namespace TutoratAppl.ViewModel
{
    public class HelpedListVM
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string EmailAddress { get; set; }

        public override String ToString() { return Id + "," + LastName + "," + FirstName + "," + EmailAddress; }
    }
}
