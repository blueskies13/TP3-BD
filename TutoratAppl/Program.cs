using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3_Partie1_EntityFramework.EfEntityFramework;

namespace TutoratAppl
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataBaseHelper = new EfDataBaseHelper();
            dataBaseHelper.SeedTables();
        }
    }
}
