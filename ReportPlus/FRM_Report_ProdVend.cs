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
using System.Globalization;

namespace ReportPlus
{
    public partial class FRM_Report_ProdVend : Form
    {
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
        List<_diaSemana> lista_DiaSemana = new List<_diaSemana>();
        List<_reportData> lista_ReportData = new List<_reportData>();
        private string sigla = string.Empty;
        string complementoWhere = string.Empty;
        string complementoOrderBy = string.Empty;
        DateTime dtini, dtfin;
        #endregion

        #region Organização dos Controles e Padronização 

        //Limpar Filtros
        private void limpaFiltro()
        {
            try
            {
                posicaoInicial();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            chckFiltroVendedor.Checked = false;
            chckFiltroGrupoProduto.Checked = false;
            chckFiltroProduto.Checked = false;
            chckFiltroDiaSemana.Checked = false;
            rdbtnOrdenarData.Checked = true;
            txtbxSearchProduto.Enabled = false;
            acertarPeriodo();

        }
        
        //habilita botão Consultar
        private void HabBtnConsultar()
        {
            if ((chckFiltroVendedor.Checked && lstbxFiltroVendedor.SelectedIndex < 0) || (chckFiltroGrupoProduto.Checked && lstbxFiltroGrupoProduto.SelectedIndex < 0) || (chckFiltroProduto.Checked && lstbxFiltroProduto.SelectedIndex < 0) || (chckFiltroDiaSemana.Checked && lstbxFiltroDiaSemana.SelectedIndex < 0))
            {
                btnConsultar.Enabled = false;
            }
            else
            {
                btnConsultar.Enabled = true;
            }
        }

        private void lstbxFiltroVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                HabBtnConsultar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void lstbxFiltroGrupoProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                HabBtnConsultar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void lstbxFiltroProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                HabBtnConsultar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void lstbxFiltroDiaSemana_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                HabBtnConsultar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private void btnRedefinirFiltros_Click(object sender, EventArgs e)
        {
            bgwFiltroVendedor.CancelAsync();
            bgwFiltroGrupoProduto.CancelAsync();
            bgwFiltroProduto.CancelAsync();
            bgwFiltroDiaSemana.CancelAsync();
            bgwFiltroTudo.CancelAsync();
            limpaFiltro();
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
                    if (bgwFiltroVendedor.IsBusy)
                    {
                        bgwFiltroVendedor.CancelAsync();
                    }
                }
                HabBtnConsultar();
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
                SelectionMode selectionMode = lstbxFiltroVendedor.SelectionMode;
                lstbxFiltroVendedor.SelectionMode = SelectionMode.None;
                if (chckFiltroVendedor.Checked)
                {
                    lstbxFiltroVendedor.DataSource = (List<_vendedor>)e.Result;
                }
                else
                {
                    lstbxFiltroVendedor.DataSource = null;
                }
                lstbxFiltroVendedor.SelectionMode = selectionMode;
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
                    if (bgwFiltroGrupoProduto.IsBusy)
                    {
                        bgwFiltroGrupoProduto.CancelAsync();
                    }
                }
                HabBtnConsultar();
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
                if (ex.HResult == -2146233079)
                {
                    MetroMessageBox.Show(this, "Aguarde todos os Grupos de Produtos serem carregados.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
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
                SelectionMode selectionMode = lstbxFiltroGrupoProduto.SelectionMode;
                lstbxFiltroGrupoProduto.SelectionMode = SelectionMode.None;
                if (chckFiltroGrupoProduto.Checked)
                {
                    lstbxFiltroGrupoProduto.DataSource = (List<_grupoProduto>)e.Result;
                }
                else
                {
                    lstbxFiltroGrupoProduto.DataSource = null;
                }
                lstbxFiltroGrupoProduto.SelectionMode = selectionMode;
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
                    txtbxSearchProduto.Enabled = true;
                }
                else
                {
                    txtbxSearchProduto.Text = string.Empty;
                    txtbxSearchProduto.Enabled = false;
                    lstbxFiltroProduto.DataSource = null;
                    if (bgwFiltroProduto.IsBusy)
                    {
                        bgwFiltroProduto.CancelAsync();
                    }
                }
                HabBtnConsultar();
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
                lista_produtos.Clear();
                lstbxFiltroProduto.ValueMember = "codproduto";
                lstbxFiltroProduto.DisplayMember = "descriproduto";
                bgwFiltroProduto.RunWorkerAsync(lista_produtos);

            }
            catch (Exception ex)
            {

                if (ex.HResult == -2146233079)
                {
                    MetroMessageBox.Show(this, "Aguarde todos os Produtos serem carregados.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

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
                SelectionMode selectionMode = lstbxFiltroProduto.SelectionMode;
                lstbxFiltroProduto.SelectionMode = SelectionMode.None;
                if (chckFiltroProduto.Checked)
                {
                    lstbxFiltroProduto.DataSource = (List<_produto>)e.Result;
                }
                else
                {
                    lstbxFiltroProduto.DataSource  = null;
                }
                lstbxFiltroProduto.SelectionMode = selectionMode;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void txtbxSearchProduto_TextChanged(object sender, EventArgs e)
        {
            List<_produto> prodsfiltered = new List<_produto>();
            foreach (var item in lista_produtos)
            {
                if (item.descriproduto.ToLower().Contains(txtbxSearchProduto.Text.ToLower()))
                {
                    prodsfiltered.Add(item);
                }
            }
            SelectionMode selectionMode = lstbxFiltroProduto.SelectionMode;
            lstbxFiltroProduto.SelectionMode = SelectionMode.None;
            lstbxFiltroProduto.DataSource = prodsfiltered;
            lstbxFiltroProduto.SelectionMode = selectionMode;
        }


        #endregion //Carregar Produto (Background Worker)


        #region Carregar Dia da Semana        
        private void chckFiltroDiaSemana_CheckedChanged(object sender, EventArgs e)
        {
            if (chckFiltroDiaSemana.Checked)
            {
                rdbtnOrdenarVendedor.Checked = true;
                rdbtnOrdenarData.Enabled = false;
                CarregarDiaSemana();

            }
            else
            {                
                rdbtnOrdenarData.Enabled = true;
                lstbxFiltroDiaSemana.DataSource = null;
                if (bgwFiltroDiaSemana.IsBusy)
                {
                    bgwFiltroDiaSemana.CancelAsync();
                }
            }
            HabBtnConsultar();
        }
        private void CarregarDiaSemana()
        {
            try
            {
                lista_DiaSemana.Clear();
                lstbxFiltroDiaSemana.ValueMember = "NUM_DIASEMANA";
                lstbxFiltroDiaSemana.DisplayMember = "NOME_DIASEMANA";
                bgwFiltroDiaSemana.RunWorkerAsync(lista_DiaSemana);
            }
            catch (Exception ex)
            {
                if (ex.HResult == -2146233079)
                {
                    MetroMessageBox.Show(this, "Aguarde todos os Dias da Semana serem carregados.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void bgwFiltroDiaSemana_DoWork(object sender, DoWorkEventArgs e)
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
                if (bgwFiltroProduto.IsBusy)
                {
                    while (bgwFiltroProduto.IsBusy)
                    {
                        Thread.Sleep(300);
                    }
                }
                bgwFiltroDiaSemana.ReportProgress(1);
                db_Select.CarregarDiaSemana(sigla, dtpckrPeriodoInicial.Value, dtpckrPeriodoFinal.Value, (List<_diaSemana>)e.Argument);
                e.Result = e.Argument;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void bgwFiltroDiaSemana_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                lblCarregandoDiaSemana.Visible = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void bgwFiltroDiaSemana_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                lblCarregandoDiaSemana.Visible = false;
                SelectionMode selectionMode = lstbxFiltroDiaSemana.SelectionMode;
                lstbxFiltroDiaSemana.SelectionMode = SelectionMode.None;
                if (chckFiltroDiaSemana.Checked)
                {
                    lstbxFiltroDiaSemana.DataSource = (List<_diaSemana>)e.Result;
                }
                else
                {
                    lstbxFiltroDiaSemana.DataSource = null;
                }
                lstbxFiltroDiaSemana.SelectionMode = selectionMode;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion //Dia da Semana


        #region DateTime Atualiza tudo

        private void atualizarLabels(int progress)
        {
            chckFiltroVendedor.Enabled = false;
            chckFiltroGrupoProduto.Enabled = false;
            chckFiltroProduto.Enabled = false;
            chckFiltroDiaSemana.Enabled = false;
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
                    if (chckFiltroDiaSemana.Checked)
                    {
                        lblCarregandoDiaSemana.Visible = true;
                        lblCarregandoDiaSemana.Text = "Aguardando";
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
                        lblCarregandoProduto.Visible = true;
                        lblCarregandoProduto.Text = "Aguardando";
                    }
                    if (chckFiltroDiaSemana.Checked)
                    {
                        lblCarregandoDiaSemana.Visible = true;
                        lblCarregandoDiaSemana.Text = "Aguardando";
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
                    if (chckFiltroDiaSemana.Checked)
                    {
                        lblCarregandoDiaSemana.Visible = true;
                        lblCarregandoDiaSemana.Text = "Aguardando";
                    }
                    break;
                case 4:
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
                        lblCarregandoProduto.Visible = false;
                        lblCarregandoProduto.Text = "Carregando";
                    }
                    if (chckFiltroDiaSemana.Checked)
                    {
                        lblCarregandoDiaSemana.Visible = true;
                        lblCarregandoDiaSemana.Text = "Carregando";
                    }
                    break;
                case 5:
                    lblCarregandoVendedor.Text = "Carregando";
                    lblCarregandoGrupoProduto.Text = "Carregando";
                    lblCarregandoProduto.Text = "Carregando";
                    lblCarregandoDiaSemana.Text = "Carregando";
                    lblCarregandoVendedor.Visible = false;
                    lblCarregandoGrupoProduto.Visible = false;
                    lblCarregandoProduto.Visible = false;
                    lblCarregandoDiaSemana.Visible = false;
                    break;
            }

        }

        private void datetime_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (bgwFiltroTudo.IsBusy)
                {

                }
                else if (dtini != dtpckrPeriodoInicial.Value || dtfin != dtpckrPeriodoFinal.Value)
                {

                    lstbxFiltroVendedor.DataSource = null;
                    lstbxFiltroGrupoProduto.DataSource = null;
                    lstbxFiltroProduto.DataSource = null;
                    lstbxFiltroDiaSemana.DataSource = null;
                    lista_vendedores.Clear();
                    lista_GrupoProdutos.Clear();
                    lista_produtos.Clear();
                    lista_DiaSemana.Clear();
                    lstbxFiltroVendedor.ValueMember = "NomeVendedor";
                    lstbxFiltroVendedor.DisplayMember = "NomeVendedor";
                    lstbxFiltroGrupoProduto.ValueMember = "Grupo";
                    lstbxFiltroGrupoProduto.DisplayMember = "Descricao";
                    lstbxFiltroProduto.ValueMember = "codproduto";
                    lstbxFiltroProduto.DisplayMember = "descriproduto";
                    lstbxFiltroDiaSemana.ValueMember = "NUM_DIASEMANA";
                    lstbxFiltroDiaSemana.DisplayMember = "NOME_DIASEMANA";

                    if (chckFiltroVendedor.Checked || chckFiltroGrupoProduto.Checked || chckFiltroProduto.Checked || chckFiltroDiaSemana.Checked)
                    {

                        bgwFiltroTudo.RunWorkerAsync();
                    }
                }
            
            }
            catch (Exception ex)
            {
                
                if (ex.HResult == -2146233079)
                {
                    MetroMessageBox.Show(this, "Aguarde todos os filtros serem carregados antes de alterar o período", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MetroMessageBox.Show(this, ex.Message + ex.HResult, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
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
                bgwFiltroTudo.ReportProgress(4);
                if (chckFiltroDiaSemana.Checked)
                {
                    db_Select.CarregarDiaSemana(sigla, dtpckrPeriodoInicial.Value, dtpckrPeriodoFinal.Value, lista_DiaSemana);
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
                        if (chckFiltroVendedor.Checked)
                        {
                            selectionMode = lstbxFiltroVendedor.SelectionMode;
                            lstbxFiltroVendedor.SelectionMode = SelectionMode.None;
                            lstbxFiltroVendedor.DataSource = lista_vendedores;
                            lstbxFiltroVendedor.SelectionMode = selectionMode;
                        }
                            break;
                        case 3:
                            atualizarLabels(3);
                        if (chckFiltroGrupoProduto.Checked)
                        {
                            selectionMode = lstbxFiltroGrupoProduto.SelectionMode;
                            lstbxFiltroGrupoProduto.SelectionMode = SelectionMode.None;
                            lstbxFiltroGrupoProduto.DataSource = lista_GrupoProdutos;
                            lstbxFiltroGrupoProduto.SelectionMode = selectionMode;
                        }
                            break;
                    case 4:
                        atualizarLabels(4);
                        if (chckFiltroProduto.Checked)
                        {
                            selectionMode = lstbxFiltroProduto.SelectionMode;
                            lstbxFiltroProduto.SelectionMode = SelectionMode.None;
                            if (txtbxSearchProduto.Text == string.Empty)
                            {
                                lstbxFiltroProduto.DataSource = lista_produtos;
                            }
                            else
                            {
                                txtbxSearchProduto_TextChanged(sender, e);
                            }
                            lstbxFiltroProduto.SelectionMode = selectionMode;
                        }

                        chckFiltroVendedor.Enabled = true;
                        chckFiltroGrupoProduto.Enabled = true;
                        chckFiltroProduto.Enabled = true;
                        chckFiltroDiaSemana.Enabled = true;
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
                atualizarLabels(5);
                if (chckFiltroDiaSemana.Checked)
                {
                    SelectionMode selectionMode = lstbxFiltroDiaSemana.SelectionMode;
                    lstbxFiltroDiaSemana.SelectionMode = SelectionMode.None;
                    lstbxFiltroDiaSemana.DataSource = lista_DiaSemana;
                    lstbxFiltroDiaSemana.SelectionMode = selectionMode;
                }

                chckFiltroVendedor.Enabled = true;
                chckFiltroGrupoProduto.Enabled = true;
                chckFiltroProduto.Enabled = true;
                chckFiltroDiaSemana.Enabled = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void dtpckrPeriodoFinal_DropDown(object sender, EventArgs e)
        {
            dtini = dtpckrPeriodoInicial.Value;
            dtfin = dtpckrPeriodoFinal.Value;
        }



        #endregion

        #endregion //Carregamento de Elementos

        #region Consultar Relatório

        #region Coletar Itens Selecionados
        private void VendedoresSelecionados(List<_vendedor> vendedores)
        {
            try
            {
                if (chckFiltroVendedor.Checked && lstbxFiltroVendedor.SelectedIndex >= 0)
                {
                    if (lstbxFiltroVendedor.SelectedIndex >= 0)
                    {
                        foreach (var item in lstbxFiltroVendedor.SelectedItems)
                        {
                            vendedores.Add(item as _vendedor);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void GruposSelecionados(List<_grupoProduto> grupos_Produtos)
        {
            try
            {
                if (chckFiltroGrupoProduto.Checked && lstbxFiltroGrupoProduto.SelectedIndex >= 0)
                {
                    if (lstbxFiltroGrupoProduto.SelectedIndex >= 0)
                    {
                        foreach (var item in lstbxFiltroGrupoProduto.SelectedItems)
                        {
                            grupos_Produtos.Add(item as _grupoProduto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ProdutosSelecionados(List<_produto> produtos)
        {
            try
            {
                if (chckFiltroProduto.Checked && lstbxFiltroProduto.SelectedIndex >= 0)
                {
                    if (lstbxFiltroProduto.SelectedIndex >= 0)
                    {
                        foreach (var item in lstbxFiltroProduto.SelectedItems)
                        {
                            produtos.Add(item as _produto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void DiasSemanaSelecionados(List<_diaSemana> diasSemana)
        {
            try
            {
                if (chckFiltroDiaSemana.Checked && lstbxFiltroDiaSemana.SelectedIndex >= 0)
                {
                    if (lstbxFiltroDiaSemana.SelectedIndex >= 0)
                    {
                        foreach (var item in lstbxFiltroDiaSemana.SelectedItems)
                        {
                            diasSemana.Add(item as _diaSemana);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        private void btnRedefinirFiltros_MouseLeave(object sender, EventArgs e)
        {
            lblOrdenar.Focus();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                #region Declaração de Objetos do Método
                List<_vendedor> lista_vendedoresSelecionados = new List<_vendedor>();
                List<_grupoProduto> lista_GrupoProdutosSelecionados = new List<_grupoProduto>();
                List<_produto> lista_ProdutosSelecionados = new List<_produto>();
                List<_diaSemana> lista_DiasSemanaSelecionados = new List<_diaSemana>();
                bool data_vendedor = true;
                #endregion



                //Verificação da Ordenação do Relatório
                if (rdbtnOrdenarData.Checked)
                {
                    data_vendedor = true;
                }
                else
                {
                    data_vendedor = false;
                }

                //Verificação do Filtro por elementos (Vendedor, Grupos de Produto, Produtos e Dias da Semana)
                if (chckFiltroVendedor.Checked)
                {
                    
                        VendedoresSelecionados(lista_vendedoresSelecionados);
                    
                }
                if (chckFiltroGrupoProduto.Checked)
                {
                        GruposSelecionados(lista_GrupoProdutosSelecionados);
                }
                if (chckFiltroProduto.Checked)
                {
                        ProdutosSelecionados(lista_ProdutosSelecionados);   
                }
                if (chckFiltroDiaSemana.Checked)
                {
                        DiasSemanaSelecionados(lista_DiasSemanaSelecionados);
                }
                
                    //Monta Complemento de Query (Where e Order By)
                    MontaFiltros.MontaFiltroProdVend(data_vendedor, chckFiltroVendedor.Checked, lista_vendedoresSelecionados, chckFiltroGrupoProduto.Checked, lista_GrupoProdutosSelecionados, chckFiltroProduto.Checked, lista_ProdutosSelecionados, chckFiltroDiaSemana.Checked, lista_DiasSemanaSelecionados, ref complementoWhere, ref complementoOrderBy);

                //Executa Consulta no Banco de Dados
                dtgvwMainReportScreen.DataSource = null;
                    lista_ReportData.Clear();
                    bgwFiltroRelatorio.RunWorkerAsync(lista_ReportData);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message + Environment.NewLine + ex.Data + Environment.NewLine + ex.InnerException + Environment.NewLine + ex.HResult, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 250);
            }
        }

        private void bgwFiltroRelatorio_DoWork(object sender, DoWorkEventArgs e)
        {
            
            bgwFiltroRelatorio.ReportProgress(db_Select.carregarRelatorioCount(sigla, dtpckrPeriodoInicial.Value, dtpckrPeriodoFinal.Value, ref complementoWhere, ref complementoOrderBy), true);
            db_Select.CarregarRelatorio(sigla, dtpckrPeriodoInicial.Value, dtpckrPeriodoFinal.Value, lista_ReportData, ref complementoWhere, ref complementoOrderBy, bgwFiltroRelatorio);
            e.Result = lista_ReportData;
        }

        private void bgwFiltroRelatorio_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if ((bool)e.UserState == true)
            {
                btnConsultar.Enabled = false;
                pbarLoadReport.Maximum = e.ProgressPercentage;
            }
            else
            {
                pbarLoadReport.Value = e.ProgressPercentage;
            }
            
        }

        private void bgwFiltroRelatorio_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pbarLoadReport.Value = 0;
            //Acerta o estilo do DataGridView
            DataGridViewStyleSet();
            
            //Atualiza o DataGridView com os dados do banco

            btnConsultar.Enabled = true;
            dtgvwMainReportScreen.DataSource = e.Result;
        }

        private void chckbxTESTE_CheckedChanged(object sender, EventArgs e)
        {
            if (chckbxTESTE.Checked)
            {
                dtgvwMainReportScreen.Columns["DATA"].Visible = true;
            }
            else
            {
                dtgvwMainReportScreen.Columns["DATA"].Visible = false;
            }
        }

        private void DataGridViewStyleSet()
        {
            try
            {
                dtgvwMainReportScreen.AutoGenerateColumns = false;
                dtgvwMainReportScreen.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
                dtgvwMainReportScreen.GridColor = Color.Black;
                dtgvwMainReportScreen.CellBorderStyle = DataGridViewCellBorderStyle.Single;
                dtgvwMainReportScreen.Columns["HORA"].DefaultCellStyle.Format = "HH:mm:ss";
                dtgvwMainReportScreen.Columns["PRODUTO"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
                dtgvwMainReportScreen.Columns["VALOR_TOTAL"].DefaultCellStyle.Format = "c2";
                dtgvwMainReportScreen.Columns["VALOR_UNITARIO"].DefaultCellStyle.Format = "c2";
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message + Environment.NewLine + ex.Data + Environment.NewLine + ex.InnerException + Environment.NewLine + ex.HResult, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 250);
            }
        }

        #endregion

    }





}
