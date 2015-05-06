using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutoratAppl.ViewModel;

namespace TutoratAppl.View
{
    class SessionListView
    {
        IEnumerable<SessionListVM> _sessionList { get; set; }
        void Display() { }
        SessionListView(IEnumerable<SessionListVM> sessionList)
        {
            _sessionList = sessionList;
        }
    }
}
