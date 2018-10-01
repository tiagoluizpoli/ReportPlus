using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportPlus.Models
{
    public class _reportTotal
    {
        public string VENDEDOR_TOT { get; set; }
        public double QUANTIDADE_TOT_VEND { get; set; }
        public double VALOR_TOT_VEND { get; set; }

        public string GRUPO_TOT { get; set; }
        public double QUANTIDADE_TOT_GRUPO { get; set; }
        public double VALOR_TOT_GRUPO { get; set; }


        public DateTime DATA_TOT { get; set; }
        public string NOME_DIASEMANA_TOT { get; set; }
        public double QUANTIDADE_TOT_DATA { get; set; }
        public double VALOR_TOT_DATA { get; set; }
    }
}
