using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutoratAppl.ViewModel;

namespace TutoratAppl.View
{
    public class WorkingHoursTutorView
    {
        private IEnumerable<WorkingHoursTutorListVM> tutors;

        public WorkingHoursTutorView(IEnumerable<WorkingHoursTutorListVM> _tutors)
        {
            tutors = _tutors;
        }
        public void Display()
        {
            foreach (WorkingHoursTutorListVM _tutors in tutors)
            {
                Console.WriteLine(_tutors.ToString());
            }
        }
    }
}
