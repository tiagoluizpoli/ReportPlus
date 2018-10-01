namespace ReportPlus
{
    partial class FRM_Config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Config));
            this.tabcConf = new MetroFramework.Controls.MetroTabControl();
            this.tabpLogo = new MetroFramework.Controls.MetroTabPage();
            this.lblMensagemPic = new MetroFramework.Controls.MetroLabel();
            this.btnSavePicLogoPath = new MetroFramework.Controls.MetroButton();
            this.btnClearPicLogoPath = new MetroFramework.Controls.MetroButton();
            this.lblLogoPath = new MetroFramework.Controls.MetroLabel();
            this.btnSearchPicLogoPath = new MetroFramework.Controls.MetroButton();
            this.lblLogoPreview = new MetroFramework.Controls.MetroLabel();
            this.txtbxPicLogoPath = new MetroFramework.Controls.MetroTextBox();
            this.pbLogoImg = new System.Windows.Forms.PictureBox();
            this.tabpDatabase = new MetroFramework.Controls.MetroTabPage();
            this.lblMensagemDatabase = new MetroFramework.Controls.MetroLabel();
            this.pgrspnTesteConexao = new MetroFramework.Controls.MetroProgressSpinner();
            this.btnTestarConexao = new MetroFramework.Controls.MetroButton();
            this.btnSalvar = new MetroFramework.Controls.MetroButton();
            this.lblSenha = new MetroFramework.Controls.MetroLabel();
            this.txtbxSenha = new MetroFramework.Controls.MetroTextBox();
            this.lblUsuario = new MetroFramework.Controls.MetroLabel();
            this.txtbxUsuario = new MetroFramework.Controls.MetroTextBox();
            this.lblDatabasePath = new MetroFramework.Controls.MetroLabel();
            this.txtbxDatabasePath = new MetroFramework.Controls.MetroTextBox();
            this.lblServerPort = new MetroFramework.Controls.MetroLabel();
            this.txtbxServerPort = new MetroFramework.Controls.MetroTextBox();
            this.lblServerIP = new MetroFramework.Controls.MetroLabel();
            this.txtbxServerIP = new MetroFramework.Controls.MetroTextBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.bgWorkerConnectionTest = new System.ComponentModel.BackgroundWorker();
            this.bgWorker2 = new System.ComponentModel.BackgroundWorker();
            this.opfdpic = new System.Windows.Forms.OpenFileDialog();
            this.bgWorker3 = new System.ComponentModel.BackgroundWorker();
            this.tabcConf.SuspendLayout();
            this.tabpLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoImg)).BeginInit();
            this.tabpDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // tabcConf
            // 
            this.tabcConf.Controls.Add(this.tabpLogo);
            this.tabcConf.Controls.Add(this.tabpDatabase);
            this.tabcConf.HotTrack = true;
            this.tabcConf.ItemSize = new System.Drawing.Size(66, 34);
            this.tabcConf.Location = new System.Drawing.Point(12, 38);
            this.tabcConf.Name = "tabcConf";
            this.tabcConf.SelectedIndex = 0;
            this.tabcConf.Size = new System.Drawing.Size(462, 247);
            this.tabcConf.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabcConf.Style = MetroFramework.MetroColorStyle.Green;
            this.tabcConf.TabIndex = 1;
            this.tabcConf.UseSelectable = true;
            this.tabcConf.UseStyleColors = true;
            // 
            // tabpLogo
            // 
            this.tabpLogo.Controls.Add(this.lblMensagemPic);
            this.tabpLogo.Controls.Add(this.btnSavePicLogoPath);
            this.tabpLogo.Controls.Add(this.btnClearPicLogoPath);
            this.tabpLogo.Controls.Add(this.lblLogoPath);
            this.tabpLogo.Controls.Add(this.btnSearchPicLogoPath);
            this.tabpLogo.Controls.Add(this.lblLogoPreview);
            this.tabpLogo.Controls.Add(this.txtbxPicLogoPath);
            this.tabpLogo.Controls.Add(this.pbLogoImg);
            this.tabpLogo.HorizontalScrollbarBarColor = true;
            this.tabpLogo.HorizontalScrollbarHighlightOnWheel = false;
            this.tabpLogo.HorizontalScrollbarSize = 10;
            this.tabpLogo.Location = new System.Drawing.Point(4, 38);
            this.tabpLogo.Name = "tabpLogo";
            this.tabpLogo.Size = new System.Drawing.Size(454, 205);
            this.tabpLogo.TabIndex = 1;
            this.tabpLogo.Text = "Logo";
            this.tabpLogo.VerticalScrollbarBarColor = true;
            this.tabpLogo.VerticalScrollbarHighlightOnWheel = false;
            this.tabpLogo.VerticalScrollbarSize = 10;
            // 
            // lblMensagemPic
            // 
            this.lblMensagemPic.AutoSize = true;
            this.lblMensagemPic.Location = new System.Drawing.Point(189, 183);
            this.lblMensagemPic.Name = "lblMensagemPic";
            this.lblMensagemPic.Size = new System.Drawing.Size(169, 19);
            this.lblMensagemPic.TabIndex = 16;
            this.lblMensagemPic.Text = "Caminho de Imagem Salvo";
            this.lblMensagemPic.Visible = false;
            // 
            // btnSavePicLogoPath
            // 
            this.btnSavePicLogoPath.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSavePicLogoPath.ForeColor = System.Drawing.Color.White;
            this.btnSavePicLogoPath.Location = new System.Drawing.Point(189, 51);
            this.btnSavePicLogoPath.Name = "btnSavePicLogoPath";
            this.btnSavePicLogoPath.Size = new System.Drawing.Size(128, 23);
            this.btnSavePicLogoPath.TabIndex = 8;
            this.btnSavePicLogoPath.Text = "Salvar";
            this.btnSavePicLogoPath.UseCustomBackColor = true;
            this.btnSavePicLogoPath.UseCustomForeColor = true;
            this.btnSavePicLogoPath.UseSelectable = true;
            this.btnSavePicLogoPath.Click += new System.EventHandler(this.btnSavePicLogoPath_Click);
            this.btnSavePicLogoPath.MouseLeave += new System.EventHandler(this.btnClearFocus_Click);
            // 
            // btnClearPicLogoPath
            // 
            this.btnClearPicLogoPath.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnClearPicLogoPath.ForeColor = System.Drawing.Color.White;
            this.btnClearPicLogoPath.Location = new System.Drawing.Point(323, 51);
            this.btnClearPicLogoPath.Name = "btnClearPicLogoPath";
            this.btnClearPicLogoPath.Size = new System.Drawing.Size(128, 23);
            this.btnClearPicLogoPath.TabIndex = 7;
            this.btnClearPicLogoPath.Text = "Limpar";
            this.btnClearPicLogoPath.UseCustomBackColor = true;
            this.btnClearPicLogoPath.UseCustomForeColor = true;
            this.btnClearPicLogoPath.UseSelectable = true;
            this.btnClearPicLogoPath.Click += new System.EventHandler(this.btnClearPicLogoPath_Click);
            this.btnClearPicLogoPath.MouseLeave += new System.EventHandler(this.btnClearFocus_Click);
            // 
            // lblLogoPath
            // 
            this.lblLogoPath.AutoSize = true;
            this.lblLogoPath.Location = new System.Drawing.Point(189, 0);
            this.lblLogoPath.Name = "lblLogoPath";
            this.lblLogoPath.Size = new System.Drawing.Size(68, 19);
            this.lblLogoPath.TabIndex = 6;
            this.lblLogoPath.Text = "Logo Path";
            // 
            // btnSearchPicLogoPath
            // 
            this.btnSearchPicLogoPath.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSearchPicLogoPath.ForeColor = System.Drawing.Color.White;
            this.btnSearchPicLogoPath.Location = new System.Drawing.Point(394, 22);
            this.btnSearchPicLogoPath.Name = "btnSearchPicLogoPath";
            this.btnSearchPicLogoPath.Size = new System.Drawing.Size(57, 23);
            this.btnSearchPicLogoPath.TabIndex = 5;
            this.btnSearchPicLogoPath.Text = "Procurar";
            this.btnSearchPicLogoPath.UseCustomBackColor = true;
            this.btnSearchPicLogoPath.UseCustomForeColor = true;
            this.btnSearchPicLogoPath.UseSelectable = true;
            this.btnSearchPicLogoPath.Click += new System.EventHandler(this.btnSearchPicLogoPath_Click);
            this.btnSearchPicLogoPath.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // lblLogoPreview
            // 
            this.lblLogoPreview.AutoSize = true;
            this.lblLogoPreview.Location = new System.Drawing.Point(3, 0);
            this.lblLogoPreview.Name = "lblLogoPreview";
            this.lblLogoPreview.Size = new System.Drawing.Size(88, 19);
            this.lblLogoPreview.TabIndex = 4;
            this.lblLogoPreview.Text = "Logo Preview";
            // 
            // txtbxPicLogoPath
            // 
            // 
            // 
            // 
            this.txtbxPicLogoPath.CustomButton.Image = null;
            this.txtbxPicLogoPath.CustomButton.Location = new System.Drawing.Point(177, 1);
            this.txtbxPicLogoPath.CustomButton.Name = "";
            this.txtbxPicLogoPath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtbxPicLogoPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbxPicLogoPath.CustomButton.TabIndex = 1;
            this.txtbxPicLogoPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbxPicLogoPath.CustomButton.UseSelectable = true;
            this.txtbxPicLogoPath.CustomButton.Visible = false;
            this.txtbxPicLogoPath.Lines = new string[0];
            this.txtbxPicLogoPath.Location = new System.Drawing.Point(189, 22);
            this.txtbxPicLogoPath.MaxLength = 32767;
            this.txtbxPicLogoPath.Name = "txtbxPicLogoPath";
            this.txtbxPicLogoPath.PasswordChar = '\0';
            this.txtbxPicLogoPath.ReadOnly = true;
            this.txtbxPicLogoPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbxPicLogoPath.SelectedText = "";
            this.txtbxPicLogoPath.SelectionLength = 0;
            this.txtbxPicLogoPath.SelectionStart = 0;
            this.txtbxPicLogoPath.ShortcutsEnabled = true;
            this.txtbxPicLogoPath.Size = new System.Drawing.Size(199, 23);
            this.txtbxPicLogoPath.TabIndex = 3;
            this.txtbxPicLogoPath.UseSelectable = true;
            this.txtbxPicLogoPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbxPicLogoPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pbLogoImg
            // 
            this.pbLogoImg.BackColor = System.Drawing.Color.White;
            this.pbLogoImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbLogoImg.ErrorImage = global::ReportPlus.Properties.Resources.if_cancel_1303884;
            this.pbLogoImg.Location = new System.Drawing.Point(3, 22);
            this.pbLogoImg.Name = "pbLogoImg";
            this.pbLogoImg.Size = new System.Drawing.Size(180, 180);
            this.pbLogoImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogoImg.TabIndex = 2;
            this.pbLogoImg.TabStop = false;
            // 
            // tabpDatabase
            // 
            this.tabpDatabase.Controls.Add(this.lblMensagemDatabase);
            this.tabpDatabase.Controls.Add(this.pgrspnTesteConexao);
            this.tabpDatabase.Controls.Add(this.btnTestarConexao);
            this.tabpDatabase.Controls.Add(this.btnSalvar);
            this.tabpDatabase.Controls.Add(this.lblSenha);
            this.tabpDatabase.Controls.Add(this.txtbxSenha);
            this.tabpDatabase.Controls.Add(this.lblUsuario);
            this.tabpDatabase.Controls.Add(this.txtbxUsuario);
            this.tabpDatabase.Controls.Add(this.lblDatabasePath);
            this.tabpDatabase.Controls.Add(this.txtbxDatabasePath);
            this.tabpDatabase.Controls.Add(this.lblServerPort);
            this.tabpDatabase.Controls.Add(this.txtbxServerPort);
            this.tabpDatabase.Controls.Add(this.lblServerIP);
            this.tabpDatabase.Controls.Add(this.txtbxServerIP);
            this.tabpDatabase.HorizontalScrollbarBarColor = true;
            this.tabpDatabase.HorizontalScrollbarHighlightOnWheel = false;
            this.tabpDatabase.HorizontalScrollbarSize = 10;
            this.tabpDatabase.Location = new System.Drawing.Point(4, 38);
            this.tabpDatabase.Name = "tabpDatabase";
            this.tabpDatabase.Size = new System.Drawing.Size(454, 205);
            this.tabpDatabase.TabIndex = 0;
            this.tabpDatabase.Text = "Database";
            this.tabpDatabase.VerticalScrollbarBarColor = true;
            this.tabpDatabase.VerticalScrollbarHighlightOnWheel = false;
            this.tabpDatabase.VerticalScrollbarSize = 10;
            // 
            // lblMensagemDatabase
            // 
            this.lblMensagemDatabase.AutoSize = true;
            this.lblMensagemDatabase.Location = new System.Drawing.Point(261, 60);
            this.lblMensagemDatabase.Name = "lblMensagemDatabase";
            this.lblMensagemDatabase.Size = new System.Drawing.Size(161, 19);
            this.lblMensagemDatabase.TabIndex = 15;
            this.lblMensagemDatabase.Text = "Dados salvos com sucesso";
            // 
            // pgrspnTesteConexao
            // 
            this.pgrspnTesteConexao.Location = new System.Drawing.Point(308, 34);
            this.pgrspnTesteConexao.Maximum = 100;
            this.pgrspnTesteConexao.Name = "pgrspnTesteConexao";
            this.pgrspnTesteConexao.Size = new System.Drawing.Size(68, 67);
            this.pgrspnTesteConexao.Style = MetroFramework.MetroColorStyle.Green;
            this.pgrspnTesteConexao.TabIndex = 14;
            this.pgrspnTesteConexao.UseSelectable = true;
            this.pgrspnTesteConexao.UseStyleColors = true;
            this.pgrspnTesteConexao.Value = 90;
            // 
            // btnTestarConexao
            // 
            this.btnTestarConexao.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnTestarConexao.ForeColor = System.Drawing.Color.White;
            this.btnTestarConexao.Location = new System.Drawing.Point(296, 142);
            this.btnTestarConexao.Name = "btnTestarConexao";
            this.btnTestarConexao.Size = new System.Drawing.Size(91, 23);
            this.btnTestarConexao.TabIndex = 13;
            this.btnTestarConexao.Text = "Testar Conexão";
            this.btnTestarConexao.UseCustomBackColor = true;
            this.btnTestarConexao.UseCustomForeColor = true;
            this.btnTestarConexao.UseSelectable = true;
            this.btnTestarConexao.Click += new System.EventHandler(this.btnTestarConexao_Click);
            this.btnTestarConexao.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(296, 113);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(91, 23);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseCustomBackColor = true;
            this.btnSalvar.UseCustomForeColor = true;
            this.btnSalvar.UseSelectable = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            this.btnSalvar.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(3, 157);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(44, 19);
            this.lblSenha.TabIndex = 11;
            this.lblSenha.Text = "Senha";
            // 
            // txtbxSenha
            // 
            // 
            // 
            // 
            this.txtbxSenha.CustomButton.Image = null;
            this.txtbxSenha.CustomButton.Location = new System.Drawing.Point(202, 1);
            this.txtbxSenha.CustomButton.Name = "";
            this.txtbxSenha.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtbxSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbxSenha.CustomButton.TabIndex = 1;
            this.txtbxSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbxSenha.CustomButton.UseSelectable = true;
            this.txtbxSenha.CustomButton.Visible = false;
            this.txtbxSenha.Lines = new string[0];
            this.txtbxSenha.Location = new System.Drawing.Point(3, 179);
            this.txtbxSenha.MaxLength = 32767;
            this.txtbxSenha.Name = "txtbxSenha";
            this.txtbxSenha.PasswordChar = '*';
            this.txtbxSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbxSenha.SelectedText = "";
            this.txtbxSenha.SelectionLength = 0;
            this.txtbxSenha.SelectionStart = 0;
            this.txtbxSenha.ShortcutsEnabled = true;
            this.txtbxSenha.Size = new System.Drawing.Size(224, 23);
            this.txtbxSenha.TabIndex = 10;
            this.txtbxSenha.UseSelectable = true;
            this.txtbxSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbxSenha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(3, 109);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(53, 19);
            this.lblUsuario.TabIndex = 9;
            this.lblUsuario.Text = "Usuário";
            // 
            // txtbxUsuario
            // 
            // 
            // 
            // 
            this.txtbxUsuario.CustomButton.Image = null;
            this.txtbxUsuario.CustomButton.Location = new System.Drawing.Point(202, 1);
            this.txtbxUsuario.CustomButton.Name = "";
            this.txtbxUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtbxUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbxUsuario.CustomButton.TabIndex = 1;
            this.txtbxUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbxUsuario.CustomButton.UseSelectable = true;
            this.txtbxUsuario.CustomButton.Visible = false;
            this.txtbxUsuario.Lines = new string[0];
            this.txtbxUsuario.Location = new System.Drawing.Point(3, 131);
            this.txtbxUsuario.MaxLength = 32767;
            this.txtbxUsuario.Name = "txtbxUsuario";
            this.txtbxUsuario.PasswordChar = '*';
            this.txtbxUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbxUsuario.SelectedText = "";
            this.txtbxUsuario.SelectionLength = 0;
            this.txtbxUsuario.SelectionStart = 0;
            this.txtbxUsuario.ShortcutsEnabled = true;
            this.txtbxUsuario.Size = new System.Drawing.Size(224, 23);
            this.txtbxUsuario.TabIndex = 8;
            this.txtbxUsuario.UseSelectable = true;
            this.txtbxUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbxUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblDatabasePath
            // 
            this.lblDatabasePath.AutoSize = true;
            this.lblDatabasePath.Location = new System.Drawing.Point(3, 60);
            this.lblDatabasePath.Name = "lblDatabasePath";
            this.lblDatabasePath.Size = new System.Drawing.Size(63, 19);
            this.lblDatabasePath.TabIndex = 7;
            this.lblDatabasePath.Text = "Database";
            // 
            // txtbxDatabasePath
            // 
            // 
            // 
            // 
            this.txtbxDatabasePath.CustomButton.Image = null;
            this.txtbxDatabasePath.CustomButton.Location = new System.Drawing.Point(202, 1);
            this.txtbxDatabasePath.CustomButton.Name = "";
            this.txtbxDatabasePath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtbxDatabasePath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbxDatabasePath.CustomButton.TabIndex = 1;
            this.txtbxDatabasePath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbxDatabasePath.CustomButton.UseSelectable = true;
            this.txtbxDatabasePath.CustomButton.Visible = false;
            this.txtbxDatabasePath.Lines = new string[0];
            this.txtbxDatabasePath.Location = new System.Drawing.Point(3, 82);
            this.txtbxDatabasePath.MaxLength = 32767;
            this.txtbxDatabasePath.Name = "txtbxDatabasePath";
            this.txtbxDatabasePath.PasswordChar = '\0';
            this.txtbxDatabasePath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbxDatabasePath.SelectedText = "";
            this.txtbxDatabasePath.SelectionLength = 0;
            this.txtbxDatabasePath.SelectionStart = 0;
            this.txtbxDatabasePath.ShortcutsEnabled = true;
            this.txtbxDatabasePath.Size = new System.Drawing.Size(224, 23);
            this.txtbxDatabasePath.TabIndex = 6;
            this.txtbxDatabasePath.UseSelectable = true;
            this.txtbxDatabasePath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbxDatabasePath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblServerPort
            // 
            this.lblServerPort.AutoSize = true;
            this.lblServerPort.Location = new System.Drawing.Point(153, 12);
            this.lblServerPort.Name = "lblServerPort";
            this.lblServerPort.Size = new System.Drawing.Size(41, 19);
            this.lblServerPort.TabIndex = 5;
            this.lblServerPort.Text = "Porta";
            // 
            // txtbxServerPort
            // 
            // 
            // 
            // 
            this.txtbxServerPort.CustomButton.Image = null;
            this.txtbxServerPort.CustomButton.Location = new System.Drawing.Point(52, 1);
            this.txtbxServerPort.CustomButton.Name = "";
            this.txtbxServerPort.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtbxServerPort.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbxServerPort.CustomButton.TabIndex = 1;
            this.txtbxServerPort.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbxServerPort.CustomButton.UseSelectable = true;
            this.txtbxServerPort.CustomButton.Visible = false;
            this.txtbxServerPort.Lines = new string[0];
            this.txtbxServerPort.Location = new System.Drawing.Point(153, 34);
            this.txtbxServerPort.MaxLength = 8;
            this.txtbxServerPort.Name = "txtbxServerPort";
            this.txtbxServerPort.PasswordChar = '\0';
            this.txtbxServerPort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbxServerPort.SelectedText = "";
            this.txtbxServerPort.SelectionLength = 0;
            this.txtbxServerPort.SelectionStart = 0;
            this.txtbxServerPort.ShortcutsEnabled = true;
            this.txtbxServerPort.Size = new System.Drawing.Size(74, 23);
            this.txtbxServerPort.TabIndex = 4;
            this.txtbxServerPort.UseSelectable = true;
            this.txtbxServerPort.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbxServerPort.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtbxServerPort.TextChanged += new System.EventHandler(this.txtbxServerPort_TextChanged);
            // 
            // lblServerIP
            // 
            this.lblServerIP.AutoSize = true;
            this.lblServerIP.Location = new System.Drawing.Point(3, 12);
            this.lblServerIP.Name = "lblServerIP";
            this.lblServerIP.Size = new System.Drawing.Size(62, 19);
            this.lblServerIP.TabIndex = 3;
            this.lblServerIP.Text = "Server IP";
            // 
            // txtbxServerIP
            // 
            // 
            // 
            // 
            this.txtbxServerIP.CustomButton.Image = null;
            this.txtbxServerIP.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.txtbxServerIP.CustomButton.Name = "";
            this.txtbxServerIP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtbxServerIP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbxServerIP.CustomButton.TabIndex = 1;
            this.txtbxServerIP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbxServerIP.CustomButton.UseSelectable = true;
            this.txtbxServerIP.CustomButton.Visible = false;
            this.txtbxServerIP.Lines = new string[0];
            this.txtbxServerIP.Location = new System.Drawing.Point(3, 34);
            this.txtbxServerIP.MaxLength = 32767;
            this.txtbxServerIP.Name = "txtbxServerIP";
            this.txtbxServerIP.PasswordChar = '\0';
            this.txtbxServerIP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbxServerIP.SelectedText = "";
            this.txtbxServerIP.SelectionLength = 0;
            this.txtbxServerIP.SelectionStart = 0;
            this.txtbxServerIP.ShortcutsEnabled = true;
            this.txtbxServerIP.Size = new System.Drawing.Size(144, 23);
            this.txtbxServerIP.TabIndex = 2;
            this.txtbxServerIP.UseSelectable = true;
            this.txtbxServerIP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbxServerIP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pbExit
            // 
            this.pbExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbExit.Image = global::ReportPlus.Properties.Resources.if_cancel_1303884;
            this.pbExit.Location = new System.Drawing.Point(451, 12);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(23, 20);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExit.TabIndex = 13;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // pbMinimize
            // 
            this.pbMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMinimize.Image = global::ReportPlus.Properties.Resources.if_minus_1303882;
            this.pbMinimize.Location = new System.Drawing.Point(422, 12);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(23, 20);
            this.pbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimize.TabIndex = 12;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            // 
            // bgWorkerConnectionTest
            // 
            this.bgWorkerConnectionTest.WorkerReportsProgress = true;
            this.bgWorkerConnectionTest.WorkerSupportsCancellation = true;
            this.bgWorkerConnectionTest.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorkerConnectionTest.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
            this.bgWorkerConnectionTest.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // bgWorker2
            // 
            this.bgWorker2.WorkerReportsProgress = true;
            this.bgWorker2.WorkerSupportsCancellation = true;
            this.bgWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker2_DoWork);
            this.bgWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker2_ProgressChanged);
            this.bgWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker2_RunWorkerCompleted);
            // 
            // opfdpic
            // 
            this.opfdpic.FileName = "openFileDialog1";
            // 
            // bgWorker3
            // 
            this.bgWorker3.WorkerReportsProgress = true;
            this.bgWorker3.WorkerSupportsCancellation = true;
            this.bgWorker3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker3_DoWork);
            this.bgWorker3.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker3_ProgressChanged);
            this.bgWorker3.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker3_RunWorkerCompleted);
            // 
            // FRM_Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(486, 297);
            this.ControlBox = false;
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.pbMinimize);
            this.Controls.Add(this.tabcConf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_Config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tabcConf.ResumeLayout(false);
            this.tabpLogo.ResumeLayout(false);
            this.tabpLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoImg)).EndInit();
            this.tabpDatabase.ResumeLayout(false);
            this.tabpDatabase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabcConf;
        private MetroFramework.Controls.MetroTabPage tabpDatabase;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.PictureBox pbMinimize;
        private MetroFramework.Controls.MetroLabel lblServerIP;
        private MetroFramework.Controls.MetroTextBox txtbxServerIP;
        private MetroFramework.Controls.MetroLabel lblSenha;
        private MetroFramework.Controls.MetroTextBox txtbxSenha;
        private MetroFramework.Controls.MetroLabel lblUsuario;
        private MetroFramework.Controls.MetroTextBox txtbxUsuario;
        private MetroFramework.Controls.MetroLabel lblDatabasePath;
        private MetroFramework.Controls.MetroTextBox txtbxDatabasePath;
        private MetroFramework.Controls.MetroLabel lblServerPort;
        private MetroFramework.Controls.MetroTextBox txtbxServerPort;
        private MetroFramework.Controls.MetroTabPage tabpLogo;
        private MetroFramework.Controls.MetroButton btnClearPicLogoPath;
        private MetroFramework.Controls.MetroLabel lblLogoPath;
        private MetroFramework.Controls.MetroButton btnSearchPicLogoPath;
        private MetroFramework.Controls.MetroLabel lblLogoPreview;
        private MetroFramework.Controls.MetroTextBox txtbxPicLogoPath;
        private System.Windows.Forms.PictureBox pbLogoImg;
        private MetroFramework.Controls.MetroButton btnTestarConexao;
        private MetroFramework.Controls.MetroButton btnSalvar;
        private System.ComponentModel.BackgroundWorker bgWorkerConnectionTest;
        private MetroFramework.Controls.MetroProgressSpinner pgrspnTesteConexao;
        private MetroFramework.Controls.MetroLabel lblMensagemDatabase;
        private System.ComponentModel.BackgroundWorker bgWorker2;
        private System.Windows.Forms.OpenFileDialog opfdpic;
        private MetroFramework.Controls.MetroButton btnSavePicLogoPath;
        private System.ComponentModel.BackgroundWorker bgWorker3;
        private MetroFramework.Controls.MetroLabel lblMensagemPic;
    }
}