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



        #region Carregar Vendedores Background Work

        private void chckFiltroVendedor_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chckFiltroVendedor.Checked)
                {
                    CarregarVendedores();

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
        private void CarregarVendedores()
        {
            try
            {
                List<_vendedor> lista_vendedores = new List<_vendedor>();
                lstbxFiltroVendedor.ValueMember = "NomeVendedor";
                lstbxFiltroVendedor.DisplayMember = "NomeVendedor";
                bgwFiltroVendedor.RunWorkerAsync(lista_vendedores);
                
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bgwFiltroVendedor_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                bgwFiltroVendedor.ReportProgress(1);
                db_Select.CarregarVendedores(sigla, dtpckrPeriodoInicial.Value, dtpckrPeriodoFinal.Value, (List<_vendedor>)e.Argument);
                e.Result = e.Argument;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void bgwFiltroVendedor_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                lblCarregandoVendedor.Visible = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void bgwFiltroVendedor_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                lblCarregandoVendedor.Visible = false;
                lstbxFiltroVendedor.DataSource = (List<_vendedor>)e.Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        #endregion


        #region Carregar Grupo de Produtos Background Work

        private void chckFiltroGrupoProduto_CheckedChanged(object sender, EventArgs e)
        {
            try
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
                bgwFiltroGrupoProduto.RunWorkerAsync(lista_GrupoProdutos);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bgwFiltroGrupoProduto_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                bgwFiltroGrupoProduto.ReportProgress(1);
                db_Select.CarregarGruposProduto(sigla, dtpckrPeriodoInicial.Value, dtpckrPeriodoFinal.Value, (List<_grupoProduto>)e.Argument);
                e.Result = e.Argument;
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bgwFiltroGrupoProduto_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                lblCarregandoGrupoProduto.Visible = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void bgwFiltroGrupoProduto_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                lblCarregandoGrupoProduto.Visible = false;
                lstbxFiltroGrupoProduto.DataSource = (List<_grupoProduto>)e.Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion //Carregar Grupo de Produtos Background Work



        #region Carregar Produto (Background Worker)

        private void chckFiltroProduto_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chckFiltroProduto.Checked)
                {
                    CarregarProdutos();
                }
                else
                {
                    lstbxFiltroProduto.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CarregarProdutos()
        {
            try
            {
                List<_produto> lista_produtos = new List<_produto>();
                lstbxFiltroProduto.ValueMember = "codproduto";
                lstbxFiltroProduto.DisplayMember = "descriproduto";
                bgwFiltroProduto.RunWorkerAsync(lista_produtos);               

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void bgwFiltroProduto_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                bgwFiltroProduto.ReportProgress(1);
                db_Select.CarregarProdutos(sigla, dtpckrPeriodoInicial.Value, dtpckrPeriodoFinal.Value, (List<_produto>)e.Argument);
                e.Result = e.Argument;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void bgwFiltroProduto_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                lblCarregandoProduto.Visible = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void bgwFiltroProduto_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                lblCarregandoProduto.Visible = false;
                lstbxFiltroProduto.DataSource = (List<_produto>)e.Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion //Carregar Produto (Background Worker)



        #endregion //Carregamento de Elementos



       

        private void datetime_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (chckFiltroVendedor.Checked)
                {
                    if (!bgwFiltroVendedor.IsBusy)
                    {
                        CarregarVendedores();
                    }
                }
                if (chckFiltroGrupoProduto.Checked)
                {
                    if (bgwFiltroGrupoProduto.IsBusy)
                    {
                        lblCarregandoGrupoProduto.Visible = true;
                        while (bgwFiltroGrupoProduto.IsBusy)
                        {
                            lblCarregandoGrupoProduto.Text = "Aguardando";
                        }

                        lblCarregandoGrupoProduto.Visible = false;
                        lblCarregandoGrupoProduto.Text = "Carregando";
                        CarregarGruposProduto();
                    }
                    else
                    {
                        CarregarGruposProduto();
                    }
                }
                    if (chckFiltroProduto.Checked)
                    {
                    if (bgwFiltroGrupoProduto.IsBusy)
                    {
                        lblCarregandoProduto.Visible = true;

                        while (bgwFiltroGrupoProduto.IsBusy)
                        {                            
                            lblCarregandoProduto.Text = "Aguardando";
                        }

                        lblCarregandoGrupoProduto.Visible = false;
                        lblCarregandoProduto.Text = "Carregando";
                        CarregarProdutos();
                    }
                    }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
} 
