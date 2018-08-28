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
using ReportPlus.Models;
using ReportPlus.DATABASE;
using ReportPlus.Tools;

namespace ReportPlus
{
    public partial class FRM_Report_ProdVend : Form
    {
        private string sigla = string.Empty;
        public FRM_Report_ProdVend(string sigla)
        {
            this.sigla = sigla;
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
                List<_vendedor> lista_vendedores = new List<_vendedor>();
                lstbxFiltroVendedor.ValueMember = "NomeVendedor";
                lstbxFiltroVendedor.DisplayMember = "NomeVendedor";
                db_Select.CarregarVendedores(sigla,dtpckrPeriodoInicial.Value, dtpckrPeriodoFinal.Value, lista_vendedores);
                lstbxFiltroVendedor.DataSource = lista_vendedores;
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarGruposProduto()
        {
            try
            {
                List<_grupoProduto> lista_GrupoProdutos = new List<_grupoProduto>();
                lstbxFiltroGrupoProduto.ValueMember = "Grupo";
                lstbxFiltroGrupoProduto.DisplayMember = "Descricao";
                db_Select.CarregarGruposProduto(sigla, dtpckrPeriodoInicial.Value, dtpckrPeriodoFinal.Value, lista_GrupoProdutos);
                lstbxFiltroGrupoProduto.DataSource = lista_GrupoProdutos;
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion



        private void chckFiltroVendedor_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chckFiltroVendedor.Checked)
                {
                    CarregarUsuarios();
                    
                }
                else
                {
                    lstbxFiltroVendedor.DataSource = null;
                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void datetime_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (chckFiltroVendedor.Checked)
                {
                    CarregarUsuarios();
                    CarregarGruposProduto();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chckFiltroGrupoProduto_CheckedChanged(object sender, EventArgs e)
        {
            if (chckFiltroGrupoProduto.Checked)
            {
                CarregarGruposProduto();
            }
            else
            {
                lstbxFiltroGrupoProduto.DataSource = null;
            }
        }
        

        
    }
} 
