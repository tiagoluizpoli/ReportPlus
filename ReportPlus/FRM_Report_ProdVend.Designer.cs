namespace ReportPlus
{
    partial class FRM_Report_ProdVend
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Report_ProdVend));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pnFiltros = new MetroFramework.Controls.MetroPanel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.pnTipo = new MetroFramework.Controls.MetroPanel();
            this.rdbtnTipoConsolidado = new MetroFramework.Controls.MetroRadioButton();
            this.rdbtnTipoDetalhado = new MetroFramework.Controls.MetroRadioButton();
            this.chckFiltroOrdenar = new MetroFramework.Controls.MetroCheckBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.rdbtnOrdenarVendedor = new MetroFramework.Controls.MetroRadioButton();
            this.rdbtnOrdenarData = new MetroFramework.Controls.MetroRadioButton();
            this.lstbxFiltroDiaSemana = new System.Windows.Forms.ListBox();
            this.lstbxFiltroProduto = new System.Windows.Forms.ListBox();
            this.lstbxFiltroGrupoProduto = new System.Windows.Forms.ListBox();
            this.lstbxFiltroVendedor = new System.Windows.Forms.ListBox();
            this.btnRedefinirFiltros = new MetroFramework.Controls.MetroButton();
            this.btnAplicarFiltros = new MetroFramework.Controls.MetroButton();
            this.chckFiltroDiaSemana = new MetroFramework.Controls.MetroCheckBox();
            this.chckFiltroProduto = new MetroFramework.Controls.MetroCheckBox();
            this.chckFiltroGrupoProduto = new MetroFramework.Controls.MetroCheckBox();
            this.dtpckrPeriodoFinal = new MetroFramework.Controls.MetroDateTime();
            this.chckFiltroVendedor = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.dtpckrPeriodoInicial = new MetroFramework.Controls.MetroDateTime();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvwMainReportScreen = new MetroFramework.Controls.MetroGrid();
            this.NLoja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrupoProdutos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produtos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaSemana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExportPdf = new MetroFramework.Controls.MetroButton();
            this.btnExportExcel = new MetroFramework.Controls.MetroButton();
            this.pnExport = new MetroFramework.Controls.MetroPanel();
            this.btnExportTexto = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.bgwFiltroGrupoProduto = new System.ComponentModel.BackgroundWorker();
            this.pnFiltros.SuspendLayout();
            this.pnTipo.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvwMainReportScreen)).BeginInit();
            this.pnExport.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 1);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(44, 19);
            this.metroLabel1.TabIndex = 26;
            this.metroLabel1.Text = "Filtros";
            // 
            // pnFiltros
            // 
            this.pnFiltros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnFiltros.Controls.Add(this.metroLabel3);
            this.pnFiltros.Controls.Add(this.pnTipo);
            this.pnFiltros.Controls.Add(this.chckFiltroOrdenar);
            this.pnFiltros.Controls.Add(this.metroPanel1);
            this.pnFiltros.Controls.Add(this.lstbxFiltroDiaSemana);
            this.pnFiltros.Controls.Add(this.lstbxFiltroProduto);
            this.pnFiltros.Controls.Add(this.lstbxFiltroGrupoProduto);
            this.pnFiltros.Controls.Add(this.lstbxFiltroVendedor);
            this.pnFiltros.Controls.Add(this.btnRedefinirFiltros);
            this.pnFiltros.Controls.Add(this.btnAplicarFiltros);
            this.pnFiltros.Controls.Add(this.chckFiltroDiaSemana);
            this.pnFiltros.Controls.Add(this.chckFiltroProduto);
            this.pnFiltros.Controls.Add(this.chckFiltroGrupoProduto);
            this.pnFiltros.Controls.Add(this.dtpckrPeriodoFinal);
            this.pnFiltros.Controls.Add(this.chckFiltroVendedor);
            this.pnFiltros.Controls.Add(this.metroLabel2);
            this.pnFiltros.Controls.Add(this.metroLabel7);
            this.pnFiltros.Controls.Add(this.dtpckrPeriodoInicial);
            this.pnFiltros.HorizontalScrollbarBarColor = true;
            this.pnFiltros.HorizontalScrollbarHighlightOnWheel = false;
            this.pnFiltros.HorizontalScrollbarSize = 10;
            this.pnFiltros.Location = new System.Drawing.Point(12, 23);
            this.pnFiltros.Name = "pnFiltros";
            this.pnFiltros.Size = new System.Drawing.Size(935, 157);
            this.pnFiltros.TabIndex = 27;
            this.pnFiltros.VerticalScrollbarBarColor = true;
            this.pnFiltros.VerticalScrollbarHighlightOnWheel = false;
            this.pnFiltros.VerticalScrollbarSize = 10;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.Location = new System.Drawing.Point(6, 60);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(32, 15);
            this.metroLabel3.TabIndex = 42;
            this.metroLabel3.Text = "Tipo:";
            // 
            // pnTipo
            // 
            this.pnTipo.Controls.Add(this.rdbtnTipoConsolidado);
            this.pnTipo.Controls.Add(this.rdbtnTipoDetalhado);
            this.pnTipo.HorizontalScrollbarBarColor = true;
            this.pnTipo.HorizontalScrollbarHighlightOnWheel = false;
            this.pnTipo.HorizontalScrollbarSize = 10;
            this.pnTipo.Location = new System.Drawing.Point(6, 78);
            this.pnTipo.Name = "pnTipo";
            this.pnTipo.Size = new System.Drawing.Size(228, 22);
            this.pnTipo.TabIndex = 41;
            this.pnTipo.VerticalScrollbarBarColor = true;
            this.pnTipo.VerticalScrollbarHighlightOnWheel = false;
            this.pnTipo.VerticalScrollbarSize = 10;
            // 
            // rdbtnTipoConsolidado
            // 
            this.rdbtnTipoConsolidado.AutoSize = true;
            this.rdbtnTipoConsolidado.Location = new System.Drawing.Point(120, 3);
            this.rdbtnTipoConsolidado.Name = "rdbtnTipoConsolidado";
            this.rdbtnTipoConsolidado.Size = new System.Drawing.Size(90, 15);
            this.rdbtnTipoConsolidado.TabIndex = 42;
            this.rdbtnTipoConsolidado.Text = "Consolidado";
            this.rdbtnTipoConsolidado.UseSelectable = true;
            // 
            // rdbtnTipoDetalhado
            // 
            this.rdbtnTipoDetalhado.AutoSize = true;
            this.rdbtnTipoDetalhado.Location = new System.Drawing.Point(9, 3);
            this.rdbtnTipoDetalhado.Name = "rdbtnTipoDetalhado";
            this.rdbtnTipoDetalhado.Size = new System.Drawing.Size(77, 15);
            this.rdbtnTipoDetalhado.TabIndex = 41;
            this.rdbtnTipoDetalhado.Text = "Detalhado";
            this.rdbtnTipoDetalhado.UseSelectable = true;
            // 
            // chckFiltroOrdenar
            // 
            this.chckFiltroOrdenar.AutoSize = true;
            this.chckFiltroOrdenar.BackColor = System.Drawing.Color.White;
            this.chckFiltroOrdenar.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.chckFiltroOrdenar.Location = new System.Drawing.Point(788, 3);
            this.chckFiltroOrdenar.Name = "chckFiltroOrdenar";
            this.chckFiltroOrdenar.Size = new System.Drawing.Size(65, 15);
            this.chckFiltroOrdenar.TabIndex = 40;
            this.chckFiltroOrdenar.Text = "Ordenar";
            this.chckFiltroOrdenar.UseSelectable = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.rdbtnOrdenarVendedor);
            this.metroPanel1.Controls.Add(this.rdbtnOrdenarData);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(788, 22);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(131, 121);
            this.metroPanel1.TabIndex = 39;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // rdbtnOrdenarVendedor
            // 
            this.rdbtnOrdenarVendedor.AutoSize = true;
            this.rdbtnOrdenarVendedor.Location = new System.Drawing.Point(28, 63);
            this.rdbtnOrdenarVendedor.Name = "rdbtnOrdenarVendedor";
            this.rdbtnOrdenarVendedor.Size = new System.Drawing.Size(74, 15);
            this.rdbtnOrdenarVendedor.TabIndex = 39;
            this.rdbtnOrdenarVendedor.Text = "Vendedor";
            this.rdbtnOrdenarVendedor.UseSelectable = true;
            // 
            // rdbtnOrdenarData
            // 
            this.rdbtnOrdenarData.AutoSize = true;
            this.rdbtnOrdenarData.Location = new System.Drawing.Point(28, 40);
            this.rdbtnOrdenarData.Name = "rdbtnOrdenarData";
            this.rdbtnOrdenarData.Size = new System.Drawing.Size(47, 15);
            this.rdbtnOrdenarData.TabIndex = 38;
            this.rdbtnOrdenarData.Text = "Data";
            this.rdbtnOrdenarData.UseSelectable = true;
            // 
            // lstbxFiltroDiaSemana
            // 
            this.lstbxFiltroDiaSemana.FormattingEnabled = true;
            this.lstbxFiltroDiaSemana.Location = new System.Drawing.Point(651, 22);
            this.lstbxFiltroDiaSemana.Name = "lstbxFiltroDiaSemana";
            this.lstbxFiltroDiaSemana.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstbxFiltroDiaSemana.Size = new System.Drawing.Size(131, 121);
            this.lstbxFiltroDiaSemana.TabIndex = 37;
            // 
            // lstbxFiltroProduto
            // 
            this.lstbxFiltroProduto.FormattingEnabled = true;
            this.lstbxFiltroProduto.Location = new System.Drawing.Point(514, 22);
            this.lstbxFiltroProduto.Name = "lstbxFiltroProduto";
            this.lstbxFiltroProduto.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstbxFiltroProduto.Size = new System.Drawing.Size(131, 121);
            this.lstbxFiltroProduto.TabIndex = 36;
            // 
            // lstbxFiltroGrupoProduto
            // 
            this.lstbxFiltroGrupoProduto.FormattingEnabled = true;
            this.lstbxFiltroGrupoProduto.Location = new System.Drawing.Point(377, 22);
            this.lstbxFiltroGrupoProduto.Name = "lstbxFiltroGrupoProduto";
            this.lstbxFiltroGrupoProduto.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstbxFiltroGrupoProduto.Size = new System.Drawing.Size(131, 121);
            this.lstbxFiltroGrupoProduto.TabIndex = 35;
            // 
            // lstbxFiltroVendedor
            // 
            this.lstbxFiltroVendedor.FormattingEnabled = true;
            this.lstbxFiltroVendedor.Location = new System.Drawing.Point(240, 22);
            this.lstbxFiltroVendedor.Name = "lstbxFiltroVendedor";
            this.lstbxFiltroVendedor.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstbxFiltroVendedor.Size = new System.Drawing.Size(131, 121);
            this.lstbxFiltroVendedor.TabIndex = 29;
            // 
            // btnRedefinirFiltros
            // 
            this.btnRedefinirFiltros.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnRedefinirFiltros.Location = new System.Drawing.Point(6, 108);
            this.btnRedefinirFiltros.Name = "btnRedefinirFiltros";
            this.btnRedefinirFiltros.Size = new System.Drawing.Size(111, 35);
            this.btnRedefinirFiltros.Style = MetroFramework.MetroColorStyle.White;
            this.btnRedefinirFiltros.TabIndex = 29;
            this.btnRedefinirFiltros.Text = "Redefinir Filtros";
            this.btnRedefinirFiltros.UseCustomBackColor = true;
            this.btnRedefinirFiltros.UseSelectable = true;
            this.btnRedefinirFiltros.UseStyleColors = true;
            // 
            // btnAplicarFiltros
            // 
            this.btnAplicarFiltros.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAplicarFiltros.Location = new System.Drawing.Point(123, 108);
            this.btnAplicarFiltros.Name = "btnAplicarFiltros";
            this.btnAplicarFiltros.Size = new System.Drawing.Size(111, 35);
            this.btnAplicarFiltros.Style = MetroFramework.MetroColorStyle.White;
            this.btnAplicarFiltros.TabIndex = 28;
            this.btnAplicarFiltros.Text = "Aplicar Filtro";
            this.btnAplicarFiltros.UseCustomBackColor = true;
            this.btnAplicarFiltros.UseSelectable = true;
            this.btnAplicarFiltros.UseStyleColors = true;
            // 
            // chckFiltroDiaSemana
            // 
            this.chckFiltroDiaSemana.AutoSize = true;
            this.chckFiltroDiaSemana.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.chckFiltroDiaSemana.Location = new System.Drawing.Point(651, 3);
            this.chckFiltroDiaSemana.Name = "chckFiltroDiaSemana";
            this.chckFiltroDiaSemana.Size = new System.Drawing.Size(98, 15);
            this.chckFiltroDiaSemana.TabIndex = 34;
            this.chckFiltroDiaSemana.Text = "Dia da Semana";
            this.chckFiltroDiaSemana.UseSelectable = true;
            // 
            // chckFiltroProduto
            // 
            this.chckFiltroProduto.AutoSize = true;
            this.chckFiltroProduto.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.chckFiltroProduto.Location = new System.Drawing.Point(514, 3);
            this.chckFiltroProduto.Name = "chckFiltroProduto";
            this.chckFiltroProduto.Size = new System.Drawing.Size(65, 15);
            this.chckFiltroProduto.TabIndex = 32;
            this.chckFiltroProduto.Text = "Produto";
            this.chckFiltroProduto.UseSelectable = true;
            this.chckFiltroProduto.CheckedChanged += new System.EventHandler(this.chckFiltroProduto_CheckedChanged);
            // 
            // chckFiltroGrupoProduto
            // 
            this.chckFiltroGrupoProduto.AutoSize = true;
            this.chckFiltroGrupoProduto.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.chckFiltroGrupoProduto.Location = new System.Drawing.Point(377, 3);
            this.chckFiltroGrupoProduto.Name = "chckFiltroGrupoProduto";
            this.chckFiltroGrupoProduto.Size = new System.Drawing.Size(116, 15);
            this.chckFiltroGrupoProduto.TabIndex = 30;
            this.chckFiltroGrupoProduto.Text = "Grupo de Produto";
            this.chckFiltroGrupoProduto.UseSelectable = true;
            this.chckFiltroGrupoProduto.CheckedChanged += new System.EventHandler(this.chckFiltroGrupoProduto_CheckedChanged);
            // 
            // dtpckrPeriodoFinal
            // 
            this.dtpckrPeriodoFinal.AllowDrop = true;
            this.dtpckrPeriodoFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpckrPeriodoFinal.Location = new System.Drawing.Point(123, 21);
            this.dtpckrPeriodoFinal.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpckrPeriodoFinal.Name = "dtpckrPeriodoFinal";
            this.dtpckrPeriodoFinal.Size = new System.Drawing.Size(111, 29);
            this.dtpckrPeriodoFinal.Style = MetroFramework.MetroColorStyle.Orange;
            this.dtpckrPeriodoFinal.TabIndex = 27;
            this.dtpckrPeriodoFinal.ValueChanged += new System.EventHandler(this.datetime_ValueChanged);
            // 
            // chckFiltroVendedor
            // 
            this.chckFiltroVendedor.AutoSize = true;
            this.chckFiltroVendedor.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.chckFiltroVendedor.Location = new System.Drawing.Point(240, 3);
            this.chckFiltroVendedor.Name = "chckFiltroVendedor";
            this.chckFiltroVendedor.Size = new System.Drawing.Size(94, 15);
            this.chckFiltroVendedor.TabIndex = 26;
            this.chckFiltroVendedor.Text = "Por Vendedor";
            this.chckFiltroVendedor.UseSelectable = true;
            this.chckFiltroVendedor.CheckedChanged += new System.EventHandler(this.chckFiltroVendedor_CheckedChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.metroLabel2.Location = new System.Drawing.Point(121, 5);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 15);
            this.metroLabel2.TabIndex = 25;
            this.metroLabel2.Text = "Período Final:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel7.Location = new System.Drawing.Point(4, 6);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(79, 15);
            this.metroLabel7.TabIndex = 24;
            this.metroLabel7.Text = "Período Inicial:";
            // 
            // dtpckrPeriodoInicial
            // 
            this.dtpckrPeriodoInicial.AllowDrop = true;
            this.dtpckrPeriodoInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpckrPeriodoInicial.Location = new System.Drawing.Point(6, 21);
            this.dtpckrPeriodoInicial.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpckrPeriodoInicial.Name = "dtpckrPeriodoInicial";
            this.dtpckrPeriodoInicial.Size = new System.Drawing.Size(111, 29);
            this.dtpckrPeriodoInicial.Style = MetroFramework.MetroColorStyle.Orange;
            this.dtpckrPeriodoInicial.TabIndex = 22;
            this.dtpckrPeriodoInicial.ValueChanged += new System.EventHandler(this.datetime_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.dtgvwMainReportScreen);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(12, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1326, 530);
            this.panel1.TabIndex = 28;
            // 
            // dtgvwMainReportScreen
            // 
            this.dtgvwMainReportScreen.AllowUserToResizeRows = false;
            this.dtgvwMainReportScreen.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgvwMainReportScreen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvwMainReportScreen.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgvwMainReportScreen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvwMainReportScreen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvwMainReportScreen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvwMainReportScreen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NLoja,
            this.Loja,
            this.Vendedor,
            this.GrupoProdutos,
            this.Produtos,
            this.Quantidade,
            this.DiaSemana,
            this.Dia});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvwMainReportScreen.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvwMainReportScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvwMainReportScreen.EnableHeadersVisualStyles = false;
            this.dtgvwMainReportScreen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtgvwMainReportScreen.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgvwMainReportScreen.Location = new System.Drawing.Point(0, 0);
            this.dtgvwMainReportScreen.Name = "dtgvwMainReportScreen";
            this.dtgvwMainReportScreen.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvwMainReportScreen.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvwMainReportScreen.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvwMainReportScreen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvwMainReportScreen.Size = new System.Drawing.Size(1326, 530);
            this.dtgvwMainReportScreen.TabIndex = 0;
            // 
            // NLoja
            // 
            this.NLoja.HeaderText = "Num. Loja";
            this.NLoja.Name = "NLoja";
            this.NLoja.ReadOnly = true;
            // 
            // Loja
            // 
            this.Loja.HeaderText = "Loja";
            this.Loja.Name = "Loja";
            this.Loja.ReadOnly = true;
            // 
            // Vendedor
            // 
            this.Vendedor.HeaderText = "Vendedor";
            this.Vendedor.Name = "Vendedor";
            this.Vendedor.ReadOnly = true;
            // 
            // GrupoProdutos
            // 
            this.GrupoProdutos.HeaderText = "Grupo Produtos";
            this.GrupoProdutos.Name = "GrupoProdutos";
            this.GrupoProdutos.ReadOnly = true;
            // 
            // Produtos
            // 
            this.Produtos.HeaderText = "Produtos";
            this.Produtos.Name = "Produtos";
            this.Produtos.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // DiaSemana
            // 
            this.DiaSemana.HeaderText = "DiaSemana";
            this.DiaSemana.Name = "DiaSemana";
            this.DiaSemana.ReadOnly = true;
            // 
            // Dia
            // 
            this.Dia.HeaderText = "Dia";
            this.Dia.Name = "Dia";
            this.Dia.ReadOnly = true;
            // 
            // btnExportPdf
            // 
            this.btnExportPdf.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnExportPdf.Location = new System.Drawing.Point(9, 60);
            this.btnExportPdf.Name = "btnExportPdf";
            this.btnExportPdf.Size = new System.Drawing.Size(111, 35);
            this.btnExportPdf.Style = MetroFramework.MetroColorStyle.White;
            this.btnExportPdf.TabIndex = 43;
            this.btnExportPdf.Text = "Pdf";
            this.btnExportPdf.UseCustomBackColor = true;
            this.btnExportPdf.UseSelectable = true;
            this.btnExportPdf.UseStyleColors = true;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnExportExcel.Location = new System.Drawing.Point(9, 22);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(111, 35);
            this.btnExportExcel.Style = MetroFramework.MetroColorStyle.White;
            this.btnExportExcel.TabIndex = 44;
            this.btnExportExcel.Text = "Excel";
            this.btnExportExcel.UseCustomBackColor = true;
            this.btnExportExcel.UseSelectable = true;
            this.btnExportExcel.UseStyleColors = true;
            // 
            // pnExport
            // 
            this.pnExport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnExport.Controls.Add(this.btnExportTexto);
            this.pnExport.Controls.Add(this.btnExportPdf);
            this.pnExport.Controls.Add(this.btnExportExcel);
            this.pnExport.HorizontalScrollbarBarColor = true;
            this.pnExport.HorizontalScrollbarHighlightOnWheel = false;
            this.pnExport.HorizontalScrollbarSize = 10;
            this.pnExport.Location = new System.Drawing.Point(953, 23);
            this.pnExport.Name = "pnExport";
            this.pnExport.Size = new System.Drawing.Size(131, 157);
            this.pnExport.TabIndex = 45;
            this.pnExport.VerticalScrollbarBarColor = true;
            this.pnExport.VerticalScrollbarHighlightOnWheel = false;
            this.pnExport.VerticalScrollbarSize = 10;
            // 
            // btnExportTexto
            // 
            this.btnExportTexto.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnExportTexto.Location = new System.Drawing.Point(9, 98);
            this.btnExportTexto.Name = "btnExportTexto";
            this.btnExportTexto.Size = new System.Drawing.Size(111, 35);
            this.btnExportTexto.Style = MetroFramework.MetroColorStyle.White;
            this.btnExportTexto.TabIndex = 45;
            this.btnExportTexto.Text = "Texto";
            this.btnExportTexto.UseCustomBackColor = true;
            this.btnExportTexto.UseSelectable = true;
            this.btnExportTexto.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(953, 1);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(59, 19);
            this.metroLabel5.TabIndex = 46;
            this.metroLabel5.Text = "Exportar";
            // 
            // bgwFiltroGrupoProduto
            // 
            this.bgwFiltroGrupoProduto.WorkerReportsProgress = true;
            this.bgwFiltroGrupoProduto.WorkerSupportsCancellation = true;
            // 
            // FRM_Report_ProdVend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.pnExport);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnFiltros);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1116, 720);
            this.Name = "FRM_Report_ProdVend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório: Produtos Vendidos";
            this.pnFiltros.ResumeLayout(false);
            this.pnFiltros.PerformLayout();
            this.pnTipo.ResumeLayout(false);
            this.pnTipo.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvwMainReportScreen)).EndInit();
            this.pnExport.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel pnFiltros;
        private MetroFramework.Controls.MetroCheckBox chckFiltroVendedor;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroDateTime dtpckrPeriodoInicial;
        private MetroFramework.Controls.MetroButton btnAplicarFiltros;
        private MetroFramework.Controls.MetroButton btnRedefinirFiltros;
        private MetroFramework.Controls.MetroDateTime dtpckrPeriodoFinal;
        private MetroFramework.Controls.MetroCheckBox chckFiltroDiaSemana;
        private MetroFramework.Controls.MetroCheckBox chckFiltroProduto;
        private MetroFramework.Controls.MetroCheckBox chckFiltroGrupoProduto;
        private System.Windows.Forms.ListBox lstbxFiltroVendedor;
        private System.Windows.Forms.ListBox lstbxFiltroDiaSemana;
        private System.Windows.Forms.ListBox lstbxFiltroProduto;
        private System.Windows.Forms.ListBox lstbxFiltroGrupoProduto;
        private MetroFramework.Controls.MetroCheckBox chckFiltroOrdenar;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroRadioButton rdbtnOrdenarVendedor;
        private MetroFramework.Controls.MetroRadioButton rdbtnOrdenarData;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroPanel pnTipo;
        private MetroFramework.Controls.MetroRadioButton rdbtnTipoConsolidado;
        private MetroFramework.Controls.MetroRadioButton rdbtnTipoDetalhado;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroGrid dtgvwMainReportScreen;
        private MetroFramework.Controls.MetroButton btnExportPdf;
        private MetroFramework.Controls.MetroButton btnExportExcel;
        private MetroFramework.Controls.MetroPanel pnExport;
        private MetroFramework.Controls.MetroButton btnExportTexto;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn NLoja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrupoProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produtos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaSemana;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia;
        private System.ComponentModel.BackgroundWorker bgwFiltroGrupoProduto;
    }
}