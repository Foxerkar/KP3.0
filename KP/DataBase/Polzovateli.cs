using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP.DataBase
{
    public class Polzovateli
    {
        public Polzovateli() { }

        public int ID_Polzovatel { get; set; }
        public string Name { get; set; }
        public string FName { get; set; }
        public string LOGIN { get; set; }
        public string PASSWORD { get; set; }
    }
}
