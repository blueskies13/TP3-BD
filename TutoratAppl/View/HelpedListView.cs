using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutoratAppl.ViewModel;

namespace TutoratAppl.View
{
    class HelpedListView
    {
         IEnumerable<HelpedListVM> _helpedList { get; set; }
        void Display() { }
        HelpedListView(IEnumerable<HelpedListVM> helpedList)
        {
            _helpedList = helpedList;
        }
    }
}
