using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoratAppl.ViewModel
{
    class WorkingHoursTutorListVM
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string EmailAdress { get; set; }
        public int NumberOfHours { get; set; }

        public override string ToString()
        {
            return LastName + " " + FirstName + " " + EmailAdress + " " + NumberOfHours;
        }
    }
}
