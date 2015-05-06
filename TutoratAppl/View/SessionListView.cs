using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutoratAppl.ViewModel;

namespace TutoratAppl.View
{

    public class SessionListView
    {
        public IEnumerable<SessionListVM> _sessionList { get; set; }
        public void Display() { }
         public SessionListView(IEnumerable<SessionListVM> sessionList)
        {
            _sessionList = sessionList;
        }
    }
}
