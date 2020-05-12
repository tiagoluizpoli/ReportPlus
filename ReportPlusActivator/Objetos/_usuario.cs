using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportPlusActivator.Objetos
{
    internal class _usuario
    {
        public uint id { get; set; }
        public string nome { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public bool ativo { get; set; }
    }
}
