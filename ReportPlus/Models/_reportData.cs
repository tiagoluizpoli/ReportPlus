using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportPlus.Models
{
    public class _reportData
    {
        public string NUM_LOJA { get; set; }
        public string LOJA { get; set; }
        public string VENDEDOR { get; set; }
        public int COD_GRUPO { get; set; }
        public string GRUPO { get; set; }
        public int COD_PRODUTO { get; set; }
        public string PRODUTO { get; set; }
        public double VALOR_UNITARIO { get; set; }
        public double VALOR_TOTAL { get; set; }
        public double QUANTIDADE { get; set; }
        public DateTime DATA { get; set; }
        public DateTime HORA { get; set; }
        public int NUM_DIASEMANA { get; set; }
        public string NOME_DIASEMANA { get; set; }
        
        
    }
}
