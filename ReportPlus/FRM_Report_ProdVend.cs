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
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using MoreLinq;
using ReportPlus.Tools.Export;

namespace ReportPlus
{
    public partial class FRM_Report_ProdVendTotals : Form
    {
        public FRM_Report_ProdVendTotals(_loja loja, _usuario usuarioLogado)
        {
            this.loja = loja;
            this.UsuarioLogado = usuarioLogado;
            InitializeComponent();
            posicaoInicial();
            HabilitaTotaisDetalhamento();
            
        }

        #region Declaração de Objetos
        List<_vendedor> lista_vendedores = new List<_vendedor>();
        List<_grupoProduto> lista_GrupoProdutos = new List<_grupoProduto>();
        List<_produto> lista_produtos = new List<_produto>();
        List<_diaSemana> lista_DiaSemana = new List<_diaSemana>();
        List<_reportData> lista_ReportData = new List<_reportData>();
        _reportDataTotais reportDataTotais = new _reportDataTotais();
        _FiltrosExport filtros = new _FiltrosExport();
        _usuario UsuarioLogado = new _usuario();
        private _loja loja;
        string complementoWhere = string.Empty;
        string complementoOrderBy = string.Empty;
        DateTime dtini, dtfin;
        bool visualizaTotaisDetalhe = false;
        
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
            chckAgruparData.Checked = true;
            chckAgruparHora.Checked = false;
            rdbtnOrdenarData.Checked = true;
            txtbxSearchProduto.Enabled = false;
            acertarPeriodo();

        }
        
        private void HabilitaTotaisDetalhamento()
        {
            if (dtgvwMainReportScreen.Rows.Count > 0)
            {
                btnTotaisDetalhamento.Enabled = true;
            }
            else
            {
                btnTotaisDetalhamento.Enabled = false;
            }
        }

        private void TrocaVisualização()
        {
            if (visualizaTotaisDetalhe == true)
            {
                btnTotaisDetalhamento.Text = "Detalhamento";
                pnReport.Visible = false;
                pnTotais.Visible = true;
                btnConsultar.Enabled = false;
                
            }
            else
            {
                btnTotaisDetalhamento.Text = "Mais Totais";
                pnReport.Visible = true;
                pnTotais.Visible = false;
                btnConsultar.Enabled = true;
            }
        }

        //habilita botão Consultar
        private void HabBtnConsultar()
        {
            if (visualizaTotaisDetalhe == false)
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

        private void chckAgruparData_CheckedChanged(object sender, EventArgs e)
        {
            if (chckAgruparData.Checked)
            {
                chckAgruparHora.Enabled = true;
                
                    chckFiltroDiaSemana.Enabled = true;
                rdbtnOrdenarData.Enabled = true;
            }
            else
            {
                chckAgruparHora.Enabled = false;
                chckAgruparHora.Checked = false;
                chckFiltroDiaSemana.Enabled = false;
                chckFiltroDiaSemana.Checked = false;
                rdbtnOrdenarVendedor.Checked = true;
                rdbtnOrdenarData.Enabled = false;
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
            visualizaTotaisDetalhe = false;
            TrocaVisualização();
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
                db_Select.CarregarVendedores(loja.Sigla, dtpckrPeriodoInicial.Value, dtpckrPeriodoFinal.Value + new TimeSpan(23, 59, 59), (List<_vendedor>)e.Argument);
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
                lista_GrupoProdutos.Clear();
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
                db_Select.CarregarGruposProduto(loja.Sigla, dtpckrPeriodoInicial.Value, dtpckrPeriodoFinal.Value, (List<_grupoProduto>)e.Argument);
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
                db_Select.CarregarProdutos(loja.Sigla, dtpckrPeriodoInicial.Value, dtpckrPeriodoFinal.Value, (List<_produto>)e.Argument);
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
                db_Select.CarregarDiaSemana(loja.Sigla, dtpckrPeriodoInicial.Value, dtpckrPeriodoFinal.Value, (List<_diaSemana>)e.Argument);
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

                    db_Select.CarregarVendedores(loja.Sigla, dtpckrPeriodoInicial.Value, dtpckrPeriodoFinal.Value, lista_vendedores);
                    Thread.Sleep(300);
                }
                bgwFiltroTudo.ReportProgress(2);
                if (chckFiltroGrupoProduto.Checked)
                {
                    db_Select.CarregarGruposProduto(loja.Sigla, dtpckrPeriodoInicial.Value, dtpckrPeriodoFinal.Value, lista_GrupoProdutos);
                    Thread.Sleep(300);
                }
                bgwFiltroTudo.ReportProgress(3);
                if (chckFiltroProduto.Checked)
                {
                    db_Select.CarregarProdutos(loja.Sigla, dtpckrPeriodoInicial.Value, dtpckrPeriodoFinal.Value, lista_produtos);
                    Thread.Sleep(300);
                }
                bgwFiltroTudo.ReportProgress(4);
                if (chckFiltroDiaSemana.Checked)
                {
                    db_Select.CarregarDiaSemana(loja.Sigla, dtpckrPeriodoInicial.Value, dtpckrPeriodoFinal.Value, lista_DiaSemana);
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
                MontaFiltros.MontaFiltroProdVend(data_vendedor, chckFiltroVendedor.Checked, lista_vendedoresSelecionados, chckFiltroGrupoProduto.Checked, lista_GrupoProdutosSelecionados, chckFiltroProduto.Checked, lista_ProdutosSelecionados, chckFiltroDiaSemana.Checked, lista_DiasSemanaSelecionados, chckAgruparData.Checked, chckAgruparHora.Checked, ref complementoWhere, ref complementoOrderBy);

                //Executa Consulta no Banco de Dados
                dtgvwMainReportScreen.DataSource = null;
                lista_ReportData.Clear();
                reportDataTotais.TOTAL_QTD_PRODUTOS_VENDIDOS = 0;
                reportDataTotais.TOTAL_VALOR_PRODUTOS_VENDIDOS = 0;
                PreencherFiltros();
                bgwFiltroRelatorio.RunWorkerAsync(lista_ReportData);

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message + Environment.NewLine + ex.Data + Environment.NewLine + ex.InnerException + Environment.NewLine + ex.HResult, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 250);
            }
        }

        private void bgwFiltroRelatorio_DoWork(object sender, DoWorkEventArgs e)
        {
            
            bgwFiltroRelatorio.ReportProgress(db_Select.carregarRelatorioCount(loja.Sigla, dtpckrPeriodoInicial.Value, dtpckrPeriodoFinal.Value, ref complementoWhere, ref complementoOrderBy), true);
            
            db_Select.CarregarRelatorio(loja.Sigla, dtpckrPeriodoInicial.Value, dtpckrPeriodoFinal.Value, lista_ReportData, reportDataTotais, ref complementoWhere, ref complementoOrderBy, bgwFiltroRelatorio, chckAgruparData.Checked, chckAgruparHora.Checked);
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
            if (lista_ReportData.Count > 0)
            {
                LoadTotais();
            }
            //Acerta o estilo do DataGridView

            DataGridViewStyleSet();

            //Atualiza o DataGridView com os dados do banco

            btnConsultar.Enabled = true;
            dtgvwMainReportScreen.DataSource = e.Result;
            txtbxTotalQtdProdutosVendidos.Text = reportDataTotais.TOTAL_QTD_PRODUTOS_VENDIDOS.ToString(string.Format("n3"));
            txtbxTotalValorProdutosVendidos.Text = reportDataTotais.TOTAL_VALOR_PRODUTOS_VENDIDOS.ToString("C2", CultureInfo.CurrentCulture);
            HabilitaTotaisDetalhamento();
        }

        private void btnTotaisDetalhamento_Click(object sender, EventArgs e)
        {
            try
            {
                if (visualizaTotaisDetalhe == true)
                {
                    visualizaTotaisDetalhe = false;
                    TrocaVisualização();
                    HabBtnConsultar();
                }
                else
                {
                    visualizaTotaisDetalhe = true;
                    TrocaVisualização();
                }
                
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void DataGridViewStyleSet()
        {
            try
            {
                if (lista_ReportData.Count > 0)
                {
                    dtgvwTotaisPorDia.AutoGenerateColumns = false;
                    dtgvwTotaisPorGrupoProdutos.AutoGenerateColumns = false;
                    dtgvwTotaisPorVendedor.AutoGenerateColumns = false;
                    dtgvwTotaisPorVendedor.GridColor = Color.Black;
                    dtgvwTotaisPorVendedor.CellBorderStyle = DataGridViewCellBorderStyle.Single;
                    dtgvwTotaisPorGrupoProdutos.GridColor = Color.Black;
                    dtgvwTotaisPorGrupoProdutos.CellBorderStyle = DataGridViewCellBorderStyle.Single;
                    dtgvwTotaisPorDia.GridColor = Color.Black;
                    dtgvwTotaisPorDia.CellBorderStyle = DataGridViewCellBorderStyle.Single;
                    dtgvwTotaisPorVendedor.Columns["QUANTIDADE_TOT_VEND"].DefaultCellStyle.Format = string.Format("n3");
                    dtgvwTotaisPorGrupoProdutos.Columns["QUANTIDADE_TOT_GRUPO"].DefaultCellStyle.Format = string.Format("n3");
                    dtgvwTotaisPorVendedor.Columns["VALOR_TOT_VEND"].DefaultCellStyle.Format = "c2";
                    dtgvwTotaisPorGrupoProdutos.Columns["VALOR_TOT_GRUPO"].DefaultCellStyle.Format = "c2";
                    if (chckAgruparData.Checked)
                    {
                        dtgvwTotaisPorDia.Columns["VALOR_TOT_DATA"].DefaultCellStyle.Format = "c2";
                        dtgvwTotaisPorDia.Columns["QUANTIDADE_TOT_DATA"].DefaultCellStyle.Format = string.Format("n3");
                    }
                }



                dtgvwMainReportScreen.AutoGenerateColumns = false;
                dtgvwMainReportScreen.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
                dtgvwMainReportScreen.GridColor = Color.Black;
                dtgvwMainReportScreen.CellBorderStyle = DataGridViewCellBorderStyle.Single;

                


                



                //Alinhamento
                dtgvwMainReportScreen.Columns["NUM_LOJA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtgvwMainReportScreen.Columns["QUANTIDADE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtgvwMainReportScreen.Columns["VALOR_UNITARIO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtgvwMainReportScreen.Columns["VALOR_TOTAL"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtgvwMainReportScreen.Columns["DATA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtgvwMainReportScreen.Columns["HORA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                


                //Currency and datetime format
                dtgvwMainReportScreen.Columns["VALOR_TOTAL"].DefaultCellStyle.Format = "c2";
                dtgvwMainReportScreen.Columns["VALOR_UNITARIO"].DefaultCellStyle.Format = "c2";
                dtgvwMainReportScreen.Columns["HORA"].DefaultCellStyle.Format = "HH:mm:ss";
                dtgvwMainReportScreen.Columns["DATA"].DefaultCellStyle.Format = "dd/MM/yyyy";

                

                


                if (chckAgruparData.Checked)
                {
                    dtgvwMainReportScreen.Columns["DATA"].Visible = true;
                    dtgvwMainReportScreen.Columns["NOME_DIASEMANA"].Visible = true;
                }
                else
                {
                    dtgvwMainReportScreen.Columns["DATA"].Visible = false;
                    dtgvwMainReportScreen.Columns["NOME_DIASEMANA"].Visible = false;
                }
                if (chckAgruparHora.Checked)
                {
                    dtgvwMainReportScreen.Columns["HORA"].Visible = true;
                }
                else
                {
                    dtgvwMainReportScreen.Columns["HORA"].Visible = false;
                }
                
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message + Environment.NewLine + ex.Data + Environment.NewLine + ex.InnerException + Environment.NewLine + ex.HResult, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 250);
            }
        }

       

        private void LoadTotais()
        {
            try
            {
                dtgvwTotaisPorVendedor.DataSource = null;
                dtgvwTotaisPorGrupoProdutos.DataSource = null;
                dtgvwTotaisPorDia.DataSource = null;

                var Cultura = new System.Globalization.CultureInfo("pt-Br");
                var TotPorVend = lista_ReportData.GroupBy(item => item.VENDEDOR).Select(VENDEDOR => new { VENDEDOR_TOT = VENDEDOR.Key, QUANTIDADE_TOT_VEND = VENDEDOR.Sum(x => x.QUANTIDADE), VALOR_TOT_VEND = VENDEDOR.Sum(x => x.VALOR_TOTAL) }).ToList();

                
                var TotPorGrupo = lista_ReportData.GroupBy(item => item.GRUPO).Select(grupo => new { GRUPO_TOT = grupo.Key, QUANTIDADE_TOT_GRUPO = grupo.Sum(x => x.QUANTIDADE), VALOR_TOT_GRUPO = grupo.Sum(x => x.VALOR_TOTAL) }).ToList();
               if(chckAgruparData.Checked)
                {
                    var TotPorDia = lista_ReportData.GroupBy(item => item.DATA).Select(DATA => new { DATA_TOT = DATA.Key, NOME_DIASEMANA_TOT = Cultura.DateTimeFormat.GetDayName(DATA.Key.DayOfWeek).ToUpper(), QUANTIDADE_TOT_DATA = DATA.Sum(x => x.QUANTIDADE), VALOR_TOT_DATA = DATA.Sum(x => x.VALOR_TOTAL) }).ToList();
                    dtgvwTotaisPorDia.DataSource = TotPorDia;
                    dtgvwTotaisPorDia.Visible = true;

                    reportDataTotais.LISTA_TOTAL_PRODUTOS_VENDIDOS_POR_DATA = new List<_reportTotal>();
                    foreach (var item in TotPorDia)
                    {
                        reportDataTotais.LISTA_TOTAL_PRODUTOS_VENDIDOS_POR_DATA.Add(new _reportTotal
                        {
                            DATA_TOT = item.DATA_TOT,
                            NOME_DIASEMANA_TOT = item.NOME_DIASEMANA_TOT,
                            QUANTIDADE_TOT_DATA = item.QUANTIDADE_TOT_DATA,
                            VALOR_TOT_DATA = item.VALOR_TOT_DATA
                        });
                    }
                }
                else
                {
                    dtgvwTotaisPorDia.Visible = false;
                    lblTotaisPorDia.Visible = false;
                }

                reportDataTotais.LISTA_TOTAL_PRODUTOS_VENDIDOS_POR_VENDEDOR = new List<_reportTotal>();
                foreach (var item in TotPorVend)
                {
                    reportDataTotais.LISTA_TOTAL_PRODUTOS_VENDIDOS_POR_VENDEDOR.Add(new _reportTotal
                    {
                        VENDEDOR_TOT = item.VENDEDOR_TOT,
                        QUANTIDADE_TOT_VEND = item.QUANTIDADE_TOT_VEND,
                        VALOR_TOT_VEND = item.VALOR_TOT_VEND
                    });
                }
                reportDataTotais.LISTA_TOTAL_PRODUTOS_VENDIDOS_POR_GRUPO = new List<_reportTotal>();
                foreach (var item in TotPorGrupo)
                {
                    reportDataTotais.LISTA_TOTAL_PRODUTOS_VENDIDOS_POR_GRUPO.Add(new _reportTotal
                    {
                        GRUPO_TOT = item.GRUPO_TOT,
                        QUANTIDADE_TOT_GRUPO = item.QUANTIDADE_TOT_GRUPO,
                        VALOR_TOT_GRUPO = item.VALOR_TOT_GRUPO
                    });
                }
                dtgvwTotaisPorVendedor.DataSource = TotPorVend;
                dtgvwTotaisPorGrupoProdutos.DataSource = TotPorGrupo;
                
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Exportação
        private void ExcelExport_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = sfdExcelExport.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    bgwExportExcel.RunWorkerAsync(this);

                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message + Environment.NewLine + ex.Data + Environment.NewLine + ex.InnerException + Environment.NewLine + ex.HResult, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 250);
            }
        }

        private void bgwExportExcel_DoWork(object sender, DoWorkEventArgs e)
        {
            bgwExportExcel.ReportProgress(1);
            
            
            ExcelExport.ExportarRelatorioExcel(lista_ReportData, reportDataTotais, filtros, sfdExcelExport.FileName, chckAgruparData.Checked, chckAgruparHora.Checked);
            bgwExportExcel.ReportProgress(2);
            Thread.Sleep(4000);
            bgwExportExcel.ReportProgress(3);
        }

        private void bgwExportExcel_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            if (e.ProgressPercentage == 1)
            {
                pnExcelExportBtn.Enabled = false;
                pctrbxExcelExportBtn.Enabled = false;
                lblExcelExportBtn.Enabled = false;

                ExportSpinner.Visible = true;
                ExportSpinner.Spinning = true;
                lblExportStatus.Visible = true;
            }


            else if (e.ProgressPercentage == 2)
            {
                pnExcelExportBtn.Enabled = true;
                pctrbxExcelExportBtn.Enabled = true;
                lblExcelExportBtn.Enabled = true;

                ExportSpinner.Visible = false;
                ExportSpinner.Spinning = false;

                lblExportStatus.Text = "O arquivo \"" + Path.GetFileName(sfdExcelExport.FileName) + "\" foi salvo no diretório: \"" + Path.GetDirectoryName(sfdExcelExport.FileName) + "\" com sucesso.";

            }
            else if (e.ProgressPercentage == 3)
            {
                lblExportStatus.Text = "Exportando Excel";
            }
        }

        private void bgwExportExcel_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            lblExportStatus.Visible = false;
        }

        

        private void PreencherFiltros()
        {
            filtros.periodoInicial = dtpckrPeriodoInicial.Value;
            filtros.periodoFinal = dtpckrPeriodoFinal.Value;
            filtros.agora = DateTime.Now;

            #region Listas

            
            if (filtros.listaVendedores == null)
            {
                filtros.listaVendedores = new List<_vendedor>();
            }
            else
            {
                filtros.listaVendedores.Clear();
            }

            if (filtros.listaGrupos == null)
            {
                filtros.listaGrupos = new List<_grupoProduto>();
            }
            else
            {
                filtros.listaGrupos.Clear();
            }

            if (filtros.listaProdutos == null)
            {
                filtros.listaProdutos = new List<_produto>();
            }
            else
            {
                filtros.listaProdutos.Clear();
            }

            if (filtros.listaDiaSemana == null)
            {
                filtros.listaDiaSemana = new List<_diaSemana>();
            }
            else
            {
                filtros.listaDiaSemana.Clear();
            } 

            if (lstbxFiltroVendedor.SelectedIndex >= 0)
            {
                foreach (var item in lstbxFiltroVendedor.SelectedItems)
                {
                    filtros.listaVendedores.Add(item as _vendedor);
                }
            }
            if (lstbxFiltroGrupoProduto.SelectedIndex >= 0)
            {
                foreach (var item in lstbxFiltroGrupoProduto.SelectedItems)
                {
                    filtros.listaGrupos.Add(item as _grupoProduto);
                }
            }
            if (lstbxFiltroProduto.SelectedIndex >= 0)
            {
                foreach (var item in lstbxFiltroProduto.SelectedItems)
                {
                    filtros.listaProdutos.Add(item as _produto);
                }
            }
            if (lstbxFiltroDiaSemana.SelectedIndex >= 0)
            {
                foreach (var item in lstbxFiltroDiaSemana.SelectedItems)
                {
                    filtros.listaDiaSemana.Add(item as _diaSemana);
                }
            }
            #endregion

            if (rdbtnOrdenarData.Checked)
            {
                filtros.data_vendedor = true;
            }
            else
            {
                filtros.data_vendedor = false;
            }
            filtros.agrupadoData = chckAgruparData.Checked;
            filtros.agrupadoHora = chckAgruparHora.Checked;
            filtros.loja = loja;
            filtros.usuario = UsuarioLogado;

        }
        #endregion
    }





}
