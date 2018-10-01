using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportPlus.Models
{
    public class _FiltrosExport
    {
        public DateTime periodoInicial { get; set; }
        public DateTime periodoFinal { get; set; }
        public DateTime agora { get; set; }

        public List<_vendedor> listaVendedores { get; set; }
        public List<_grupoProduto> listaGrupos { get; set; }
        public List<_produto> listaProdutos { get; set; }
        public List<_diaSemana> listaDiaSemana { get; set; }
        public bool agrupadoData { get; set; }
        public bool agrupadoHora { get; set; }
        public bool data_vendedor { get; set; }
        public _loja loja { get; set; }
        public _usuario usuario { get; set; }

    }
}
