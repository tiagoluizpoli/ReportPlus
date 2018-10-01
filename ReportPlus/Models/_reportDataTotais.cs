using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportPlus.Models
{
    public class _reportDataTotais
    {
        public double TOTAL_QTD_PRODUTOS_VENDIDOS { get; set; }
        public double TOTAL_VALOR_PRODUTOS_VENDIDOS { get; set; }

        public List<_reportTotal> LISTA_TOTAL_PRODUTOS_VENDIDOS_POR_VENDEDOR { get; set; }
        public List<_reportTotal> LISTA_TOTAL_PRODUTOS_VENDIDOS_POR_GRUPO { get; set; }
        public List<_reportTotal> LISTA_TOTAL_PRODUTOS_VENDIDOS_POR_DATA { get; set; }
        

    }
}
