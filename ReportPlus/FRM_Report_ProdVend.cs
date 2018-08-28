using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace ReportPlus
{
    public partial class FRM_Report_ProdVend : Form
    {
        public FRM_Report_ProdVend()
        {
            InitializeComponent();
            posicaoInicial();
        }



        #region Organização dos Controles e Padronização 
        
        //Limpar Filtros
        private void limpaFiltro()
        {
            
        }

        //Acertar Período do DateTimePicker
        private void acertarPeriodo()
        {
            dtpckrPeriodoInicial.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpckrPeriodoFinal.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);
        }

        // Posição inicial
        private void posicaoInicial()
        {
            acertarPeriodo();
            rdbtnTipoDetalhado.Checked = true;
            chckFiltroVendedor.Checked = false;
            chckFiltroGrupoProduto.Checked = false;
            chckFiltroProduto.Checked = false;
            chckFiltroDiaSemana.Checked = false;
            rdbtnOrdenarData.Checked = true;

        }
        #endregion

        #region Carregamento de Elementos
        private void CarregarUsuarios()
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion



    }
} 
