using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP.DataBase
{
    public class Auditoria
    {
        public Auditoria() { }

        public int ID_Auditor {  get; set; }
        public string NomAud {  get; set; }
        public string Type { get; set; }
    }
}
