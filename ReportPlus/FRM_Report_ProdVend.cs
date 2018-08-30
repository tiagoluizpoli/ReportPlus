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
using System.Threading;

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

        #region Declaração de Objetos
        List<_vendedor> lista_vendedores = new List<_vendedor>();
        List<_grupoProduto> lista_GrupoProdutos = new List<_grupoProduto>();
        List<_produto> lista_produtos = new List<_produto>();
        #endregion

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
                if (bgwFiltroGrupoProduto.IsBusy)
                {
                    while (bgwFiltroGrupoProduto.IsBusy)
                    {
                        Thread.Sleep(300);
                    }
                }
                if (bgwFiltroProduto.IsBusy)
                {
                    while (bgwFiltroProduto.IsBusy)
                    {
                        Thread.Sleep(300);
                    }
                }
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
                if (bgwFiltroVendedor.IsBusy)
                {
                    while (bgwFiltroVendedor.IsBusy)
                    {
                        Thread.Sleep(300);
                    }
                }
                if (bgwFiltroProduto.IsBusy)
                {
                    while (bgwFiltroProduto.IsBusy)
                    {
                        Thread.Sleep(300);
                    }
                }
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
                if (bgwFiltroGrupoProduto.IsBusy)
                {
                    while (bgwFiltroGrupoProduto.IsBusy)
                    {
                        Thread.Sleep(300);
                    }
                }
                if (bgwFiltroVendedor.IsBusy)
                {
                    while (bgwFiltroVendedor.IsBusy)
                    {
                        Thread.Sleep(300);
                    }
                }
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


        #region DateTime Atualiza tudo

        private void atualizarLabels(int progress)
        {
            switch (progress)
            {
                case 1:
                    if (chckFiltroVendedor.Checked)
                    {
                        lblCarregandoVendedor.Visible = true;
                        lblCarregandoVendedor.Text = "Carregando";
                    }
                    if (chckFiltroGrupoProduto.Checked)
                    {
                        lblCarregandoGrupoProduto.Visible = true;
                        lblCarregandoGrupoProduto.Text = "Aguardando";
                    }
                    if (chckFiltroProduto.Checked)
                    {
                        lblCarregandoProduto.Visible = true;
                        lblCarregandoProduto.Text = "Aguardando";
                    }

                    break;
                case 2:
                    if (chckFiltroVendedor.Checked)
                    {
                        lblCarregandoVendedor.Visible = false;
                    }
                    if (chckFiltroGrupoProduto.Checked)
                    {
                        lblCarregandoGrupoProduto.Text = "Carregando";

                    }
                    if (chckFiltroProduto.Checked)
                    {
                        lblCarregandoProduto.Text = "Aguardando";
                    }


                    break;
                case 3:

                    if (chckFiltroVendedor.Checked)
                    {
                        lblCarregandoVendedor.Visible = false;
                    }
                    if (chckFiltroGrupoProduto.Checked)
                    {
                        lblCarregandoGrupoProduto.Text = "Carregando";
                        lblCarregandoGrupoProduto.Visible = false;

                    }
                    if (chckFiltroProduto.Checked)
                    {
                        lblCarregandoProduto.Text = "Carregando";
                    }
                    break;
                case 4:
                    lblCarregandoVendedor.Text = "Carregando";
                    lblCarregandoGrupoProduto.Text = "Carregando";
                    lblCarregandoProduto.Text = "Carregando";
                    lblCarregandoVendedor.Visible = false;
                    lblCarregandoGrupoProduto.Visible = false;
                    lblCarregandoProduto.Visible = false;
                    break;

            }

        }

        private void datetime_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                lstbxFiltroVendedor.DataSource = null;
                lstbxFiltroGrupoProduto.DataSource = null;
                lstbxFiltroProduto.DataSource = null;
                lista_vendedores.Clear();
                lista_GrupoProdutos.Clear();
                lista_produtos.Clear();
                lstbxFiltroVendedor.ValueMember = "NomeVendedor";
                lstbxFiltroVendedor.DisplayMember = "NomeVendedor";
                lstbxFiltroGrupoProduto.ValueMember = "Grupo";
                lstbxFiltroGrupoProduto.DisplayMember = "Descricao";
                lstbxFiltroProduto.ValueMember = "codproduto";
                lstbxFiltroProduto.DisplayMember = "descriproduto";

                if (chckFiltroVendedor.Checked || chckFiltroGrupoProduto.Checked || chckFiltroProduto.Checked)
                {
                    bgwFiltroTudo.RunWorkerAsync();
                }


            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bgwFiltroTudo_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                bgwFiltroTudo.ReportProgress(1);
                if (chckFiltroVendedor.Checked)
                {

                    db_Select.CarregarVendedores(sigla, dtpckrPeriodoInicial.Value, dtpckrPeriodoFinal.Value, lista_vendedores);
                    Thread.Sleep(300);
                }
                bgwFiltroTudo.ReportProgress(2);
                if (chckFiltroGrupoProduto.Checked)
                {
                    db_Select.CarregarGruposProduto(sigla, dtpckrPeriodoInicial.Value, dtpckrPeriodoFinal.Value, lista_GrupoProdutos);
                    Thread.Sleep(300);
                }
                bgwFiltroTudo.ReportProgress(3);
                if (chckFiltroProduto.Checked)
                {
                    db_Select.CarregarProdutos(sigla, dtpckrPeriodoInicial.Value, dtpckrPeriodoFinal.Value, lista_produtos);
                    Thread.Sleep(300);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void bgwFiltroTudo_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                
                    SelectionMode selectionMode = new SelectionMode();
                    switch (e.ProgressPercentage)
                    {
                        case 1:
                            atualizarLabels(1);
                            break;
                        case 2:
                            atualizarLabels(2);
                            selectionMode = lstbxFiltroVendedor.SelectionMode;
                            lstbxFiltroVendedor.SelectionMode = SelectionMode.None;
                            lstbxFiltroVendedor.DataSource = lista_vendedores;
                            lstbxFiltroVendedor.SelectionMode = selectionMode;
                            break;
                        case 3:
                            atualizarLabels(3);
                            selectionMode = lstbxFiltroGrupoProduto.SelectionMode;
                            lstbxFiltroGrupoProduto.SelectionMode = SelectionMode.None;
                            lstbxFiltroGrupoProduto.DataSource = lista_GrupoProdutos;
                            lstbxFiltroGrupoProduto.SelectionMode = selectionMode;
                            break;
                    }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void bgwFiltroTudo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                atualizarLabels(4);
                SelectionMode selectionMode = lstbxFiltroProduto.SelectionMode;
                lstbxFiltroProduto.SelectionMode = SelectionMode.None;
                lstbxFiltroProduto.DataSource = lista_produtos;
                lstbxFiltroProduto.SelectionMode = selectionMode;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
    #endregion

    #endregion //Carregamento de Elementos





}
