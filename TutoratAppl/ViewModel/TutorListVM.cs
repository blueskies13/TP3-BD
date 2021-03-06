﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3_Partie1_EntityFramework.Model;

namespace TutoratAppl.ViewModel
{
    public class TutorListVM : Entity
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string EmailAddress { get; set; }

        public override String ToString() { return Id + "," + LastName + "," + FirstName + "," + EmailAddress; }
    }
}
