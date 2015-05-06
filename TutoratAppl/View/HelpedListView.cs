using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutoratAppl.ViewModel;

namespace TutoratAppl.View
{
     public class HelpedListView
    {
        public IEnumerable<HelpedListVM> _helpedList { get; set; }
        public void Display() { }
        public HelpedListView(IEnumerable<HelpedListVM> helpedList)
        {
            _helpedList = helpedList;
        }
    }
}
