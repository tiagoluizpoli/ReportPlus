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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Report_ProdVend));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pnFiltros = new MetroFramework.Controls.MetroPanel();
            this.txtbxSearchProduto = new MetroFramework.Controls.MetroTextBox();
            this.lblOrdenar = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.rdbtnOrdenarVendedor = new MetroFramework.Controls.MetroRadioButton();
            this.rdbtnOrdenarData = new MetroFramework.Controls.MetroRadioButton();
            this.lstbxFiltroDiaSemana = new System.Windows.Forms.ListBox();
            this.lstbxFiltroProduto = new System.Windows.Forms.ListBox();
            this.lstbxFiltroGrupoProduto = new System.Windows.Forms.ListBox();
            this.lstbxFiltroVendedor = new System.Windows.Forms.ListBox();
            this.btnRedefinirFiltros = new MetroFramework.Controls.MetroButton();
            this.btnConsultar = new MetroFramework.Controls.MetroButton();
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
            this.NUM_LOJA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOJA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VENDEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRUPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR_UNITARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR_TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_DIASEMANA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExportPdf = new MetroFramework.Controls.MetroButton();
            this.btnExportExcel = new MetroFramework.Controls.MetroButton();
            this.pnExport = new MetroFramework.Controls.MetroPanel();
            this.btnExportTexto = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.bgwFiltroGrupoProduto = new System.ComponentModel.BackgroundWorker();
            this.lblCarregandoProduto = new MetroFramework.Controls.MetroLabel();
            this.bgwFiltroProduto = new System.ComponentModel.BackgroundWorker();
            this.lblCarregandoGrupoProduto = new MetroFramework.Controls.MetroLabel();
            this.bgwFiltroVendedor = new System.ComponentModel.BackgroundWorker();
            this.lblCarregandoVendedor = new MetroFramework.Controls.MetroLabel();
            this.bgwFiltroTudo = new System.ComponentModel.BackgroundWorker();
            this.lblCarregandoDiaSemana = new MetroFramework.Controls.MetroLabel();
            this.bgwFiltroDiaSemana = new System.ComponentModel.BackgroundWorker();
            this.bgwFiltroRelatorio = new System.ComponentModel.BackgroundWorker();
            this.pbarLoadReport = new MetroFramework.Controls.MetroProgressBar();
            this.chckbxTESTE = new MetroFramework.Controls.MetroCheckBox();
            this.pnFiltros.SuspendLayout();
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
            this.pnFiltros.Controls.Add(this.txtbxSearchProduto);
            this.pnFiltros.Controls.Add(this.lblOrdenar);
            this.pnFiltros.Controls.Add(this.metroPanel1);
            this.pnFiltros.Controls.Add(this.lstbxFiltroDiaSemana);
            this.pnFiltros.Controls.Add(this.lstbxFiltroProduto);
            this.pnFiltros.Controls.Add(this.lstbxFiltroGrupoProduto);
            this.pnFiltros.Controls.Add(this.lstbxFiltroVendedor);
            this.pnFiltros.Controls.Add(this.btnRedefinirFiltros);
            this.pnFiltros.Controls.Add(this.btnConsultar);
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
            this.pnFiltros.Size = new System.Drawing.Size(794, 195);
            this.pnFiltros.TabIndex = 27;
            this.pnFiltros.VerticalScrollbarBarColor = true;
            this.pnFiltros.VerticalScrollbarHighlightOnWheel = false;
            this.pnFiltros.VerticalScrollbarSize = 10;
            // 
            // txtbxSearchProduto
            // 
            // 
            // 
            // 
            this.txtbxSearchProduto.CustomButton.Image = null;
            this.txtbxSearchProduto.CustomButton.Location = new System.Drawing.Point(109, 1);
            this.txtbxSearchProduto.CustomButton.Name = "";
            this.txtbxSearchProduto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtbxSearchProduto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbxSearchProduto.CustomButton.TabIndex = 1;
            this.txtbxSearchProduto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbxSearchProduto.CustomButton.UseSelectable = true;
            this.txtbxSearchProduto.CustomButton.Visible = false;
            this.txtbxSearchProduto.Lines = new string[0];
            this.txtbxSearchProduto.Location = new System.Drawing.Point(514, 22);
            this.txtbxSearchProduto.MaxLength = 32767;
            this.txtbxSearchProduto.Name = "txtbxSearchProduto";
            this.txtbxSearchProduto.PasswordChar = '\0';
            this.txtbxSearchProduto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbxSearchProduto.SelectedText = "";
            this.txtbxSearchProduto.SelectionLength = 0;
            this.txtbxSearchProduto.SelectionStart = 0;
            this.txtbxSearchProduto.ShortcutsEnabled = true;
            this.txtbxSearchProduto.Size = new System.Drawing.Size(131, 23);
            this.txtbxSearchProduto.TabIndex = 44;
            this.txtbxSearchProduto.UseSelectable = true;
            this.txtbxSearchProduto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbxSearchProduto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtbxSearchProduto.TextChanged += new System.EventHandler(this.txtbxSearchProduto_TextChanged);
            // 
            // lblOrdenar
            // 
            this.lblOrdenar.AutoSize = true;
            this.lblOrdenar.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblOrdenar.Location = new System.Drawing.Point(6, 76);
            this.lblOrdenar.Name = "lblOrdenar";
            this.lblOrdenar.Size = new System.Drawing.Size(74, 15);
            this.lblOrdenar.TabIndex = 43;
            this.lblOrdenar.Text = "Ordenar por:";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.rdbtnOrdenarVendedor);
            this.metroPanel1.Controls.Add(this.rdbtnOrdenarData);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(6, 94);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(228, 22);
            this.metroPanel1.TabIndex = 39;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // rdbtnOrdenarVendedor
            // 
            this.rdbtnOrdenarVendedor.AutoSize = true;
            this.rdbtnOrdenarVendedor.Location = new System.Drawing.Point(119, 2);
            this.rdbtnOrdenarVendedor.Name = "rdbtnOrdenarVendedor";
            this.rdbtnOrdenarVendedor.Size = new System.Drawing.Size(73, 15);
            this.rdbtnOrdenarVendedor.Style = MetroFramework.MetroColorStyle.Black;
            this.rdbtnOrdenarVendedor.TabIndex = 39;
            this.rdbtnOrdenarVendedor.Text = "Vendedor";
            this.rdbtnOrdenarVendedor.UseSelectable = true;
            this.rdbtnOrdenarVendedor.UseStyleColors = true;
            // 
            // rdbtnOrdenarData
            // 
            this.rdbtnOrdenarData.AutoSize = true;
            this.rdbtnOrdenarData.Location = new System.Drawing.Point(8, 2);
            this.rdbtnOrdenarData.Name = "rdbtnOrdenarData";
            this.rdbtnOrdenarData.Size = new System.Drawing.Size(47, 15);
            this.rdbtnOrdenarData.Style = MetroFramework.MetroColorStyle.Black;
            this.rdbtnOrdenarData.TabIndex = 38;
            this.rdbtnOrdenarData.Text = "Data";
            this.rdbtnOrdenarData.UseSelectable = true;
            this.rdbtnOrdenarData.UseStyleColors = true;
            // 
            // lstbxFiltroDiaSemana
            // 
            this.lstbxFiltroDiaSemana.FormattingEnabled = true;
            this.lstbxFiltroDiaSemana.Location = new System.Drawing.Point(651, 22);
            this.lstbxFiltroDiaSemana.Name = "lstbxFiltroDiaSemana";
            this.lstbxFiltroDiaSemana.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstbxFiltroDiaSemana.Size = new System.Drawing.Size(131, 160);
            this.lstbxFiltroDiaSemana.TabIndex = 37;
            this.lstbxFiltroDiaSemana.SelectedIndexChanged += new System.EventHandler(this.lstbxFiltroDiaSemana_SelectedIndexChanged);
            // 
            // lstbxFiltroProduto
            // 
            this.lstbxFiltroProduto.FormattingEnabled = true;
            this.lstbxFiltroProduto.Location = new System.Drawing.Point(514, 48);
            this.lstbxFiltroProduto.Name = "lstbxFiltroProduto";
            this.lstbxFiltroProduto.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstbxFiltroProduto.Size = new System.Drawing.Size(131, 134);
            this.lstbxFiltroProduto.TabIndex = 36;
            this.lstbxFiltroProduto.SelectedIndexChanged += new System.EventHandler(this.lstbxFiltroProduto_SelectedIndexChanged);
            // 
            // lstbxFiltroGrupoProduto
            // 
            this.lstbxFiltroGrupoProduto.FormattingEnabled = true;
            this.lstbxFiltroGrupoProduto.Location = new System.Drawing.Point(377, 22);
            this.lstbxFiltroGrupoProduto.Name = "lstbxFiltroGrupoProduto";
            this.lstbxFiltroGrupoProduto.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstbxFiltroGrupoProduto.Size = new System.Drawing.Size(131, 160);
            this.lstbxFiltroGrupoProduto.TabIndex = 35;
            this.lstbxFiltroGrupoProduto.SelectedIndexChanged += new System.EventHandler(this.lstbxFiltroGrupoProduto_SelectedIndexChanged);
            // 
            // lstbxFiltroVendedor
            // 
            this.lstbxFiltroVendedor.FormattingEnabled = true;
            this.lstbxFiltroVendedor.Location = new System.Drawing.Point(240, 22);
            this.lstbxFiltroVendedor.Name = "lstbxFiltroVendedor";
            this.lstbxFiltroVendedor.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstbxFiltroVendedor.Size = new System.Drawing.Size(131, 160);
            this.lstbxFiltroVendedor.TabIndex = 29;
            this.lstbxFiltroVendedor.SelectedIndexChanged += new System.EventHandler(this.lstbxFiltroVendedor_SelectedIndexChanged);
            // 
            // btnRedefinirFiltros
            // 
            this.btnRedefinirFiltros.BackColor = System.Drawing.Color.Black;
            this.btnRedefinirFiltros.Location = new System.Drawing.Point(6, 147);
            this.btnRedefinirFiltros.Name = "btnRedefinirFiltros";
            this.btnRedefinirFiltros.Size = new System.Drawing.Size(111, 35);
            this.btnRedefinirFiltros.Style = MetroFramework.MetroColorStyle.White;
            this.btnRedefinirFiltros.TabIndex = 29;
            this.btnRedefinirFiltros.Text = "Redefinir Filtros";
            this.btnRedefinirFiltros.UseCustomBackColor = true;
            this.btnRedefinirFiltros.UseSelectable = true;
            this.btnRedefinirFiltros.UseStyleColors = true;
            this.btnRedefinirFiltros.Click += new System.EventHandler(this.btnRedefinirFiltros_Click);
            this.btnRedefinirFiltros.MouseLeave += new System.EventHandler(this.btnRedefinirFiltros_MouseLeave);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Black;
            this.btnConsultar.Location = new System.Drawing.Point(123, 147);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(111, 35);
            this.btnConsultar.Style = MetroFramework.MetroColorStyle.White;
            this.btnConsultar.TabIndex = 28;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseCustomBackColor = true;
            this.btnConsultar.UseSelectable = true;
            this.btnConsultar.UseStyleColors = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            this.btnConsultar.MouseLeave += new System.EventHandler(this.btnRedefinirFiltros_MouseLeave);
            // 
            // chckFiltroDiaSemana
            // 
            this.chckFiltroDiaSemana.AutoSize = true;
            this.chckFiltroDiaSemana.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.chckFiltroDiaSemana.Location = new System.Drawing.Point(651, 3);
            this.chckFiltroDiaSemana.Name = "chckFiltroDiaSemana";
            this.chckFiltroDiaSemana.Size = new System.Drawing.Size(98, 15);
            this.chckFiltroDiaSemana.Style = MetroFramework.MetroColorStyle.Black;
            this.chckFiltroDiaSemana.TabIndex = 34;
            this.chckFiltroDiaSemana.Text = "Dia da Semana";
            this.chckFiltroDiaSemana.UseSelectable = true;
            this.chckFiltroDiaSemana.UseStyleColors = true;
            this.chckFiltroDiaSemana.CheckedChanged += new System.EventHandler(this.chckFiltroDiaSemana_CheckedChanged);
            // 
            // chckFiltroProduto
            // 
            this.chckFiltroProduto.AutoSize = true;
            this.chckFiltroProduto.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.chckFiltroProduto.Location = new System.Drawing.Point(514, 3);
            this.chckFiltroProduto.Name = "chckFiltroProduto";
            this.chckFiltroProduto.Size = new System.Drawing.Size(65, 15);
            this.chckFiltroProduto.Style = MetroFramework.MetroColorStyle.Black;
            this.chckFiltroProduto.TabIndex = 32;
            this.chckFiltroProduto.Text = "Produto";
            this.chckFiltroProduto.UseSelectable = true;
            this.chckFiltroProduto.UseStyleColors = true;
            this.chckFiltroProduto.CheckedChanged += new System.EventHandler(this.chckFiltroProduto_CheckedChanged);
            // 
            // chckFiltroGrupoProduto
            // 
            this.chckFiltroGrupoProduto.AutoSize = true;
            this.chckFiltroGrupoProduto.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.chckFiltroGrupoProduto.Location = new System.Drawing.Point(377, 3);
            this.chckFiltroGrupoProduto.Name = "chckFiltroGrupoProduto";
            this.chckFiltroGrupoProduto.Size = new System.Drawing.Size(116, 15);
            this.chckFiltroGrupoProduto.Style = MetroFramework.MetroColorStyle.Black;
            this.chckFiltroGrupoProduto.TabIndex = 30;
            this.chckFiltroGrupoProduto.Text = "Grupo de Produto";
            this.chckFiltroGrupoProduto.UseSelectable = true;
            this.chckFiltroGrupoProduto.UseStyleColors = true;
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
            this.dtpckrPeriodoFinal.Style = MetroFramework.MetroColorStyle.Black;
            this.dtpckrPeriodoFinal.TabIndex = 27;
            this.dtpckrPeriodoFinal.UseStyleColors = true;
            this.dtpckrPeriodoFinal.CloseUp += new System.EventHandler(this.datetime_ValueChanged);
            this.dtpckrPeriodoFinal.DropDown += new System.EventHandler(this.dtpckrPeriodoFinal_DropDown);
            // 
            // chckFiltroVendedor
            // 
            this.chckFiltroVendedor.AutoSize = true;
            this.chckFiltroVendedor.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.chckFiltroVendedor.Location = new System.Drawing.Point(240, 3);
            this.chckFiltroVendedor.Name = "chckFiltroVendedor";
            this.chckFiltroVendedor.Size = new System.Drawing.Size(92, 15);
            this.chckFiltroVendedor.Style = MetroFramework.MetroColorStyle.Black;
            this.chckFiltroVendedor.TabIndex = 26;
            this.chckFiltroVendedor.Text = "Por Vendedor";
            this.chckFiltroVendedor.UseSelectable = true;
            this.chckFiltroVendedor.UseStyleColors = true;
            this.chckFiltroVendedor.CheckedChanged += new System.EventHandler(this.chckFiltroVendedor_CheckedChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.metroLabel2.Location = new System.Drawing.Point(121, 5);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 15);
            this.metroLabel2.TabIndex = 25;
            this.metroLabel2.Text = "Período Final:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel7.Location = new System.Drawing.Point(4, 6);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(78, 15);
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
            this.dtpckrPeriodoInicial.Style = MetroFramework.MetroColorStyle.Black;
            this.dtpckrPeriodoInicial.TabIndex = 22;
            this.dtpckrPeriodoInicial.UseStyleColors = true;
            this.dtpckrPeriodoInicial.CloseUp += new System.EventHandler(this.datetime_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.dtgvwMainReportScreen);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(12, 253);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1316, 441);
            this.panel1.TabIndex = 28;
            // 
            // dtgvwMainReportScreen
            // 
            this.dtgvwMainReportScreen.AllowUserToAddRows = false;
            this.dtgvwMainReportScreen.AllowUserToResizeRows = false;
            this.dtgvwMainReportScreen.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgvwMainReportScreen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvwMainReportScreen.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgvwMainReportScreen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvwMainReportScreen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvwMainReportScreen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvwMainReportScreen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NUM_LOJA,
            this.LOJA,
            this.VENDEDOR,
            this.GRUPO,
            this.PRODUTO,
            this.QUANTIDADE,
            this.VALOR_UNITARIO,
            this.VALOR_TOTAL,
            this.DATA,
            this.HORA,
            this.NOME_DIASEMANA});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvwMainReportScreen.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvwMainReportScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvwMainReportScreen.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgvwMainReportScreen.EnableHeadersVisualStyles = false;
            this.dtgvwMainReportScreen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtgvwMainReportScreen.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgvwMainReportScreen.HighLightPercentage = 0.3F;
            this.dtgvwMainReportScreen.Location = new System.Drawing.Point(0, 0);
            this.dtgvwMainReportScreen.Name = "dtgvwMainReportScreen";
            this.dtgvwMainReportScreen.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvwMainReportScreen.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvwMainReportScreen.RowHeadersVisible = false;
            this.dtgvwMainReportScreen.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvwMainReportScreen.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvwMainReportScreen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvwMainReportScreen.Size = new System.Drawing.Size(1316, 441);
            this.dtgvwMainReportScreen.Style = MetroFramework.MetroColorStyle.Black;
            this.dtgvwMainReportScreen.TabIndex = 0;
            this.dtgvwMainReportScreen.UseCustomBackColor = true;
            this.dtgvwMainReportScreen.UseCustomForeColor = true;
            this.dtgvwMainReportScreen.UseStyleColors = true;
            // 
            // NUM_LOJA
            // 
            this.NUM_LOJA.DataPropertyName = "NUM_LOJA";
            this.NUM_LOJA.HeaderText = "Num. Loja";
            this.NUM_LOJA.Name = "NUM_LOJA";
            this.NUM_LOJA.ReadOnly = true;
            this.NUM_LOJA.Width = 90;
            // 
            // LOJA
            // 
            this.LOJA.DataPropertyName = "LOJA";
            this.LOJA.HeaderText = "Loja";
            this.LOJA.Name = "LOJA";
            this.LOJA.ReadOnly = true;
            this.LOJA.Width = 150;
            // 
            // VENDEDOR
            // 
            this.VENDEDOR.DataPropertyName = "VENDEDOR";
            this.VENDEDOR.HeaderText = "Vendedor";
            this.VENDEDOR.Name = "VENDEDOR";
            this.VENDEDOR.ReadOnly = true;
            this.VENDEDOR.Width = 180;
            // 
            // GRUPO
            // 
            this.GRUPO.DataPropertyName = "GRUPO";
            this.GRUPO.HeaderText = "Grupo de Produtos";
            this.GRUPO.Name = "GRUPO";
            this.GRUPO.ReadOnly = true;
            this.GRUPO.Width = 180;
            // 
            // PRODUTO
            // 
            this.PRODUTO.DataPropertyName = "PRODUTO";
            this.PRODUTO.HeaderText = "Produtos";
            this.PRODUTO.Name = "PRODUTO";
            this.PRODUTO.ReadOnly = true;
            this.PRODUTO.Width = 300;
            // 
            // QUANTIDADE
            // 
            this.QUANTIDADE.DataPropertyName = "QUANTIDADE";
            this.QUANTIDADE.HeaderText = "Quantidade";
            this.QUANTIDADE.Name = "QUANTIDADE";
            this.QUANTIDADE.ReadOnly = true;
            this.QUANTIDADE.Width = 75;
            // 
            // VALOR_UNITARIO
            // 
            this.VALOR_UNITARIO.DataPropertyName = "VALOR_UNITARIO";
            this.VALOR_UNITARIO.HeaderText = "Valor Unitario";
            this.VALOR_UNITARIO.Name = "VALOR_UNITARIO";
            this.VALOR_UNITARIO.ReadOnly = true;
            // 
            // VALOR_TOTAL
            // 
            this.VALOR_TOTAL.DataPropertyName = "VALOR_TOTAL";
            this.VALOR_TOTAL.HeaderText = "Valor Total";
            this.VALOR_TOTAL.Name = "VALOR_TOTAL";
            this.VALOR_TOTAL.ReadOnly = true;
            // 
            // DATA
            // 
            this.DATA.DataPropertyName = "DATA";
            this.DATA.HeaderText = "Data";
            this.DATA.Name = "DATA";
            this.DATA.ReadOnly = true;
            this.DATA.Width = 80;
            // 
            // HORA
            // 
            this.HORA.DataPropertyName = "HORA";
            this.HORA.HeaderText = "Hora";
            this.HORA.MinimumWidth = 60;
            this.HORA.Name = "HORA";
            this.HORA.Width = 80;
            // 
            // NOME_DIASEMANA
            // 
            this.NOME_DIASEMANA.DataPropertyName = "NOME_DIASEMANA";
            this.NOME_DIASEMANA.HeaderText = "Dia da Semana";
            this.NOME_DIASEMANA.Name = "NOME_DIASEMANA";
            this.NOME_DIASEMANA.ReadOnly = true;
            this.NOME_DIASEMANA.Width = 125;
            // 
            // btnExportPdf
            // 
            this.btnExportPdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExportPdf.Location = new System.Drawing.Point(9, 76);
            this.btnExportPdf.Name = "btnExportPdf";
            this.btnExportPdf.Size = new System.Drawing.Size(111, 40);
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
            this.btnExportExcel.Location = new System.Drawing.Point(9, 30);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(111, 40);
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
            this.pnExport.Controls.Add(this.btnExportPdf);
            this.pnExport.Controls.Add(this.btnExportTexto);
            this.pnExport.Controls.Add(this.btnExportExcel);
            this.pnExport.HorizontalScrollbarBarColor = true;
            this.pnExport.HorizontalScrollbarHighlightOnWheel = false;
            this.pnExport.HorizontalScrollbarSize = 10;
            this.pnExport.Location = new System.Drawing.Point(812, 23);
            this.pnExport.Name = "pnExport";
            this.pnExport.Size = new System.Drawing.Size(131, 195);
            this.pnExport.TabIndex = 45;
            this.pnExport.VerticalScrollbarBarColor = true;
            this.pnExport.VerticalScrollbarHighlightOnWheel = false;
            this.pnExport.VerticalScrollbarSize = 10;
            // 
            // btnExportTexto
            // 
            this.btnExportTexto.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnExportTexto.Location = new System.Drawing.Point(9, 122);
            this.btnExportTexto.Name = "btnExportTexto";
            this.btnExportTexto.Size = new System.Drawing.Size(111, 40);
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
            this.metroLabel5.Location = new System.Drawing.Point(812, 1);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(60, 19);
            this.metroLabel5.TabIndex = 46;
            this.metroLabel5.Text = "Exportar";
            // 
            // bgwFiltroGrupoProduto
            // 
            this.bgwFiltroGrupoProduto.WorkerReportsProgress = true;
            this.bgwFiltroGrupoProduto.WorkerSupportsCancellation = true;
            this.bgwFiltroGrupoProduto.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwFiltroGrupoProduto_DoWork);
            this.bgwFiltroGrupoProduto.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwFiltroGrupoProduto_ProgressChanged);
            this.bgwFiltroGrupoProduto.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwFiltroGrupoProduto_RunWorkerCompleted);
            // 
            // lblCarregandoProduto
            // 
            this.lblCarregandoProduto.AutoSize = true;
            this.lblCarregandoProduto.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblCarregandoProduto.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCarregandoProduto.Location = new System.Drawing.Point(527, 5);
            this.lblCarregandoProduto.Name = "lblCarregandoProduto";
            this.lblCarregandoProduto.Size = new System.Drawing.Size(67, 15);
            this.lblCarregandoProduto.TabIndex = 43;
            this.lblCarregandoProduto.Text = "Carregando";
            this.lblCarregandoProduto.Visible = false;
            // 
            // bgwFiltroProduto
            // 
            this.bgwFiltroProduto.WorkerReportsProgress = true;
            this.bgwFiltroProduto.WorkerSupportsCancellation = true;
            this.bgwFiltroProduto.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwFiltroProduto_DoWork);
            this.bgwFiltroProduto.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwFiltroProduto_ProgressChanged);
            this.bgwFiltroProduto.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwFiltroProduto_RunWorkerCompleted);
            // 
            // lblCarregandoGrupoProduto
            // 
            this.lblCarregandoGrupoProduto.AutoSize = true;
            this.lblCarregandoGrupoProduto.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblCarregandoGrupoProduto.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCarregandoGrupoProduto.Location = new System.Drawing.Point(390, 5);
            this.lblCarregandoGrupoProduto.Name = "lblCarregandoGrupoProduto";
            this.lblCarregandoGrupoProduto.Size = new System.Drawing.Size(67, 15);
            this.lblCarregandoGrupoProduto.TabIndex = 47;
            this.lblCarregandoGrupoProduto.Text = "Carregando";
            this.lblCarregandoGrupoProduto.Visible = false;
            // 
            // bgwFiltroVendedor
            // 
            this.bgwFiltroVendedor.WorkerReportsProgress = true;
            this.bgwFiltroVendedor.WorkerSupportsCancellation = true;
            this.bgwFiltroVendedor.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwFiltroVendedor_DoWork);
            this.bgwFiltroVendedor.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwFiltroVendedor_ProgressChanged);
            this.bgwFiltroVendedor.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwFiltroVendedor_RunWorkerCompleted);
            // 
            // lblCarregandoVendedor
            // 
            this.lblCarregandoVendedor.AutoSize = true;
            this.lblCarregandoVendedor.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblCarregandoVendedor.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCarregandoVendedor.Location = new System.Drawing.Point(253, 5);
            this.lblCarregandoVendedor.Name = "lblCarregandoVendedor";
            this.lblCarregandoVendedor.Size = new System.Drawing.Size(67, 15);
            this.lblCarregandoVendedor.TabIndex = 48;
            this.lblCarregandoVendedor.Text = "Carregando";
            this.lblCarregandoVendedor.Visible = false;
            // 
            // bgwFiltroTudo
            // 
            this.bgwFiltroTudo.WorkerReportsProgress = true;
            this.bgwFiltroTudo.WorkerSupportsCancellation = true;
            this.bgwFiltroTudo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwFiltroTudo_DoWork);
            this.bgwFiltroTudo.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwFiltroTudo_ProgressChanged);
            this.bgwFiltroTudo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwFiltroTudo_RunWorkerCompleted);
            // 
            // lblCarregandoDiaSemana
            // 
            this.lblCarregandoDiaSemana.AutoSize = true;
            this.lblCarregandoDiaSemana.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblCarregandoDiaSemana.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCarregandoDiaSemana.Location = new System.Drawing.Point(664, 5);
            this.lblCarregandoDiaSemana.Name = "lblCarregandoDiaSemana";
            this.lblCarregandoDiaSemana.Size = new System.Drawing.Size(67, 15);
            this.lblCarregandoDiaSemana.TabIndex = 49;
            this.lblCarregandoDiaSemana.Text = "Carregando";
            this.lblCarregandoDiaSemana.Visible = false;
            // 
            // bgwFiltroDiaSemana
            // 
            this.bgwFiltroDiaSemana.WorkerReportsProgress = true;
            this.bgwFiltroDiaSemana.WorkerSupportsCancellation = true;
            this.bgwFiltroDiaSemana.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwFiltroDiaSemana_DoWork);
            this.bgwFiltroDiaSemana.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwFiltroDiaSemana_ProgressChanged);
            this.bgwFiltroDiaSemana.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwFiltroDiaSemana_RunWorkerCompleted);
            // 
            // bgwFiltroRelatorio
            // 
            this.bgwFiltroRelatorio.WorkerReportsProgress = true;
            this.bgwFiltroRelatorio.WorkerSupportsCancellation = true;
            this.bgwFiltroRelatorio.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwFiltroRelatorio_DoWork);
            this.bgwFiltroRelatorio.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwFiltroRelatorio_ProgressChanged);
            this.bgwFiltroRelatorio.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwFiltroRelatorio_RunWorkerCompleted);
            // 
            // pbarLoadReport
            // 
            this.pbarLoadReport.Location = new System.Drawing.Point(12, 224);
            this.pbarLoadReport.Name = "pbarLoadReport";
            this.pbarLoadReport.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Blocks;
            this.pbarLoadReport.Size = new System.Drawing.Size(931, 23);
            this.pbarLoadReport.Style = MetroFramework.MetroColorStyle.Black;
            this.pbarLoadReport.TabIndex = 50;
            // 
            // chckbxTESTE
            // 
            this.chckbxTESTE.AutoSize = true;
            this.chckbxTESTE.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.chckbxTESTE.Location = new System.Drawing.Point(1005, 79);
            this.chckbxTESTE.Name = "chckbxTESTE";
            this.chckbxTESTE.Size = new System.Drawing.Size(65, 15);
            this.chckbxTESTE.Style = MetroFramework.MetroColorStyle.Black;
            this.chckbxTESTE.TabIndex = 45;
            this.chckbxTESTE.Text = "Produto";
            this.chckbxTESTE.UseSelectable = true;
            this.chckbxTESTE.UseStyleColors = true;
            this.chckbxTESTE.CheckedChanged += new System.EventHandler(this.chckbxTESTE_CheckedChanged);
            // 
            // FRM_Report_ProdVend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1340, 706);
            this.Controls.Add(this.chckbxTESTE);
            this.Controls.Add(this.pbarLoadReport);
            this.Controls.Add(this.lblCarregandoDiaSemana);
            this.Controls.Add(this.lblCarregandoVendedor);
            this.Controls.Add(this.lblCarregandoGrupoProduto);
            this.Controls.Add(this.lblCarregandoProduto);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.pnExport);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnFiltros);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1116, 720);
            this.Name = "FRM_Report_ProdVend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório: Vendas de Produtos.";
            this.pnFiltros.ResumeLayout(false);
            this.pnFiltros.PerformLayout();
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
        private MetroFramework.Controls.MetroButton btnConsultar;
        private MetroFramework.Controls.MetroButton btnRedefinirFiltros;
        private MetroFramework.Controls.MetroDateTime dtpckrPeriodoFinal;
        private MetroFramework.Controls.MetroCheckBox chckFiltroDiaSemana;
        private MetroFramework.Controls.MetroCheckBox chckFiltroProduto;
        private MetroFramework.Controls.MetroCheckBox chckFiltroGrupoProduto;
        private System.Windows.Forms.ListBox lstbxFiltroVendedor;
        private System.Windows.Forms.ListBox lstbxFiltroDiaSemana;
        private System.Windows.Forms.ListBox lstbxFiltroProduto;
        private System.Windows.Forms.ListBox lstbxFiltroGrupoProduto;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroRadioButton rdbtnOrdenarVendedor;
        private MetroFramework.Controls.MetroRadioButton rdbtnOrdenarData;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton btnExportPdf;
        private MetroFramework.Controls.MetroButton btnExportExcel;
        private MetroFramework.Controls.MetroPanel pnExport;
        private MetroFramework.Controls.MetroButton btnExportTexto;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.ComponentModel.BackgroundWorker bgwFiltroGrupoProduto;
        private MetroFramework.Controls.MetroLabel lblCarregandoProduto;
        private System.ComponentModel.BackgroundWorker bgwFiltroProduto;
        private MetroFramework.Controls.MetroLabel lblCarregandoGrupoProduto;
        private System.ComponentModel.BackgroundWorker bgwFiltroVendedor;
        private MetroFramework.Controls.MetroLabel lblCarregandoVendedor;
        private System.ComponentModel.BackgroundWorker bgwFiltroTudo;
        private MetroFramework.Controls.MetroTextBox txtbxSearchProduto;
        private MetroFramework.Controls.MetroLabel lblOrdenar;
        private MetroFramework.Controls.MetroLabel lblCarregandoDiaSemana;
        private System.ComponentModel.BackgroundWorker bgwFiltroDiaSemana;
        private MetroFramework.Controls.MetroGrid dtgvwMainReportScreen;
        private System.ComponentModel.BackgroundWorker bgwFiltroRelatorio;
        private MetroFramework.Controls.MetroProgressBar pbarLoadReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_LOJA;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOJA;
        private System.Windows.Forms.DataGridViewTextBoxColumn VENDEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRUPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR_UNITARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR_TOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_DIASEMANA;
        private MetroFramework.Controls.MetroCheckBox chckbxTESTE;
    }
}