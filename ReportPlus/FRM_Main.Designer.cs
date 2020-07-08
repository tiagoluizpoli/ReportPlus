namespace ReportPlus
{
    partial class FRM_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Main));
            this.cmbxLoja = new MetroFramework.Controls.MetroComboBox();
            this.cmbxUsuarios = new MetroFramework.Controls.MetroComboBox();
            this.lblLoja = new MetroFramework.Controls.MetroLabel();
            this.lblUsuario = new MetroFramework.Controls.MetroLabel();
            this.lblSenha = new MetroFramework.Controls.MetroLabel();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.txtbxSenha = new MetroFramework.Controls.MetroTextBox();
            this.lblReportPlus = new MetroFramework.Controls.MetroLabel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.pbConfig = new System.Windows.Forms.PictureBox();
            this.pnLogin = new MetroFramework.Controls.MetroPanel();
            this.pnLogued = new MetroFramework.Controls.MetroPanel();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btnSairSelecaoRel = new MetroFramework.Controls.MetroButton();
            this.btnVendasdeProdutos = new MetroFramework.Controls.MetroButton();
            this.lblLoguedUsuarioNome = new MetroFramework.Controls.MetroLabel();
            this.lblLoguedLojaNome = new MetroFramework.Controls.MetroLabel();
            this.lblLoguedUsuario = new MetroFramework.Controls.MetroLabel();
            this.lblLoguedLoja = new MetroFramework.Controls.MetroLabel();
            this.lblTrial = new MetroFramework.Controls.MetroLabel();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfig)).BeginInit();
            this.pnLogin.SuspendLayout();
            this.pnLogued.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbxLoja
            // 
            this.cmbxLoja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxLoja.FormattingEnabled = true;
            this.cmbxLoja.ItemHeight = 23;
            this.cmbxLoja.Location = new System.Drawing.Point(8, 33);
            this.cmbxLoja.Name = "cmbxLoja";
            this.cmbxLoja.Size = new System.Drawing.Size(239, 29);
            this.cmbxLoja.Style = MetroFramework.MetroColorStyle.Green;
            this.cmbxLoja.TabIndex = 0;
            this.cmbxLoja.UseSelectable = true;
            this.cmbxLoja.UseStyleColors = true;
            this.cmbxLoja.SelectedIndexChanged += new System.EventHandler(this.cmbxLoja_SelectedIndexChanged);
            // 
            // cmbxUsuarios
            // 
            this.cmbxUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxUsuarios.FormattingEnabled = true;
            this.cmbxUsuarios.ItemHeight = 23;
            this.cmbxUsuarios.Location = new System.Drawing.Point(8, 87);
            this.cmbxUsuarios.Name = "cmbxUsuarios";
            this.cmbxUsuarios.Size = new System.Drawing.Size(239, 29);
            this.cmbxUsuarios.Style = MetroFramework.MetroColorStyle.Green;
            this.cmbxUsuarios.TabIndex = 1;
            this.cmbxUsuarios.UseSelectable = true;
            this.cmbxUsuarios.UseStyleColors = true;
            // 
            // lblLoja
            // 
            this.lblLoja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoja.AutoSize = true;
            this.lblLoja.BackColor = System.Drawing.Color.Transparent;
            this.lblLoja.Location = new System.Drawing.Point(112, 11);
            this.lblLoja.Name = "lblLoja";
            this.lblLoja.Size = new System.Drawing.Size(33, 19);
            this.lblLoja.TabIndex = 6;
            this.lblLoja.Text = "Loja";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(101, 65);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(53, 19);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblSenha
            // 
            this.lblSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(101, 119);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(44, 19);
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "Senha";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.BackColor = System.Drawing.Color.Maroon;
            this.btnLogin.Location = new System.Drawing.Point(64, 186);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(121, 29);
            this.btnLogin.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnLogin.UseSelectable = true;
            this.btnLogin.UseStyleColors = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtbxSenha
            // 
            this.txtbxSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtbxSenha.CustomButton.Image = null;
            this.txtbxSenha.CustomButton.Location = new System.Drawing.Point(217, 1);
            this.txtbxSenha.CustomButton.Name = "";
            this.txtbxSenha.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtbxSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbxSenha.CustomButton.TabIndex = 1;
            this.txtbxSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbxSenha.CustomButton.UseSelectable = true;
            this.txtbxSenha.CustomButton.Visible = false;
            this.txtbxSenha.Lines = new string[0];
            this.txtbxSenha.Location = new System.Drawing.Point(8, 141);
            this.txtbxSenha.MaxLength = 32767;
            this.txtbxSenha.Name = "txtbxSenha";
            this.txtbxSenha.PasswordChar = '*';
            this.txtbxSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbxSenha.SelectedText = "";
            this.txtbxSenha.SelectionLength = 0;
            this.txtbxSenha.SelectionStart = 0;
            this.txtbxSenha.ShortcutsEnabled = true;
            this.txtbxSenha.Size = new System.Drawing.Size(239, 23);
            this.txtbxSenha.Style = MetroFramework.MetroColorStyle.Green;
            this.txtbxSenha.TabIndex = 2;
            this.txtbxSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbxSenha.UseSelectable = true;
            this.txtbxSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbxSenha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtbxSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbxSenha_KeyDown);
            // 
            // lblReportPlus
            // 
            this.lblReportPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReportPlus.AutoSize = true;
            this.lblReportPlus.Location = new System.Drawing.Point(352, 367);
            this.lblReportPlus.Name = "lblReportPlus";
            this.lblReportPlus.Size = new System.Drawing.Size(89, 19);
            this.lblReportPlus.TabIndex = 12;
            this.lblReportPlus.Text = "Report Plus®";
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLogo.Image = global::ReportPlus.Properties.Resources.saj_logo;
            this.pbLogo.Location = new System.Drawing.Point(12, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(65, 65);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 13;
            this.pbLogo.TabStop = false;
            // 
            // pbExit
            // 
            this.pbExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbExit.Image = global::ReportPlus.Properties.Resources.if_cancel_1303884;
            this.pbExit.Location = new System.Drawing.Point(418, 12);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(23, 20);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExit.TabIndex = 11;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // pbMinimize
            // 
            this.pbMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMinimize.Image = global::ReportPlus.Properties.Resources.if_minus_1303882;
            this.pbMinimize.Location = new System.Drawing.Point(389, 12);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(23, 20);
            this.pbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimize.TabIndex = 10;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            // 
            // pbConfig
            // 
            this.pbConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbConfig.Image = global::ReportPlus.Properties.Resources.settings_1_;
            this.pbConfig.Location = new System.Drawing.Point(12, 363);
            this.pbConfig.Name = "pbConfig";
            this.pbConfig.Size = new System.Drawing.Size(23, 20);
            this.pbConfig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbConfig.TabIndex = 9;
            this.pbConfig.TabStop = false;
            this.pbConfig.Click += new System.EventHandler(this.pbConfig_Click);
            // 
            // pnLogin
            // 
            this.pnLogin.Controls.Add(this.lblLoja);
            this.pnLogin.Controls.Add(this.cmbxLoja);
            this.pnLogin.Controls.Add(this.cmbxUsuarios);
            this.pnLogin.Controls.Add(this.lblUsuario);
            this.pnLogin.Controls.Add(this.txtbxSenha);
            this.pnLogin.Controls.Add(this.lblSenha);
            this.pnLogin.Controls.Add(this.btnLogin);
            this.pnLogin.HorizontalScrollbarBarColor = true;
            this.pnLogin.HorizontalScrollbarHighlightOnWheel = false;
            this.pnLogin.HorizontalScrollbarSize = 10;
            this.pnLogin.Location = new System.Drawing.Point(99, 66);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Size = new System.Drawing.Size(255, 218);
            this.pnLogin.TabIndex = 0;
            this.pnLogin.VerticalScrollbarBarColor = true;
            this.pnLogin.VerticalScrollbarHighlightOnWheel = false;
            this.pnLogin.VerticalScrollbarSize = 10;
            // 
            // pnLogued
            // 
            this.pnLogued.Controls.Add(this.metroButton4);
            this.pnLogued.Controls.Add(this.metroButton3);
            this.pnLogued.Controls.Add(this.metroButton2);
            this.pnLogued.Controls.Add(this.metroButton1);
            this.pnLogued.Controls.Add(this.btnSairSelecaoRel);
            this.pnLogued.Controls.Add(this.btnVendasdeProdutos);
            this.pnLogued.Controls.Add(this.lblLoguedUsuarioNome);
            this.pnLogued.Controls.Add(this.lblLoguedLojaNome);
            this.pnLogued.Controls.Add(this.lblLoguedUsuario);
            this.pnLogued.Controls.Add(this.lblLoguedLoja);
            this.pnLogued.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnLogued.HorizontalScrollbarBarColor = true;
            this.pnLogued.HorizontalScrollbarHighlightOnWheel = false;
            this.pnLogued.HorizontalScrollbarSize = 10;
            this.pnLogued.Location = new System.Drawing.Point(99, 12);
            this.pnLogued.Name = "pnLogued";
            this.pnLogued.Size = new System.Drawing.Size(255, 352);
            this.pnLogued.TabIndex = 15;
            this.pnLogued.VerticalScrollbar = true;
            this.pnLogued.VerticalScrollbarBarColor = true;
            this.pnLogued.VerticalScrollbarHighlightOnWheel = true;
            this.pnLogued.VerticalScrollbarSize = 10;
            // 
            // metroButton3
            // 
            this.metroButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroButton3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.metroButton3.ForeColor = System.Drawing.Color.White;
            this.metroButton3.Location = new System.Drawing.Point(8, 168);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(239, 23);
            this.metroButton3.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroButton3.TabIndex = 12;
            this.metroButton3.Text = "Cardápio";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.UseStyleColors = true;
            this.metroButton3.Visible = false;
            // 
            // metroButton2
            // 
            this.metroButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroButton2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.metroButton2.ForeColor = System.Drawing.Color.White;
            this.metroButton2.Location = new System.Drawing.Point(8, 139);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(239, 23);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroButton2.TabIndex = 11;
            this.metroButton2.Text = "Auditoria Conta a Conta";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.UseStyleColors = true;
            this.metroButton2.Visible = false;
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroButton1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.metroButton1.ForeColor = System.Drawing.Color.White;
            this.metroButton1.Location = new System.Drawing.Point(8, 110);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(239, 23);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroButton1.TabIndex = 10;
            this.metroButton1.Text = "Faturamento";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Visible = false;
            // 
            // btnSairSelecaoRel
            // 
            this.btnSairSelecaoRel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSairSelecaoRel.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSairSelecaoRel.Location = new System.Drawing.Point(91, 320);
            this.btnSairSelecaoRel.Name = "btnSairSelecaoRel";
            this.btnSairSelecaoRel.Size = new System.Drawing.Size(73, 23);
            this.btnSairSelecaoRel.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnSairSelecaoRel.TabIndex = 9;
            this.btnSairSelecaoRel.Text = "Sair";
            this.btnSairSelecaoRel.UseSelectable = true;
            this.btnSairSelecaoRel.UseStyleColors = true;
            this.btnSairSelecaoRel.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnVendasdeProdutos
            // 
            this.btnVendasdeProdutos.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnVendasdeProdutos.ForeColor = System.Drawing.Color.White;
            this.btnVendasdeProdutos.Location = new System.Drawing.Point(8, 81);
            this.btnVendasdeProdutos.Name = "btnVendasdeProdutos";
            this.btnVendasdeProdutos.Size = new System.Drawing.Size(239, 23);
            this.btnVendasdeProdutos.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnVendasdeProdutos.TabIndex = 6;
            this.btnVendasdeProdutos.Text = "Vendas de Produtos";
            this.btnVendasdeProdutos.UseCustomBackColor = true;
            this.btnVendasdeProdutos.UseCustomForeColor = true;
            this.btnVendasdeProdutos.UseSelectable = true;
            this.btnVendasdeProdutos.UseStyleColors = true;
            this.btnVendasdeProdutos.Click += new System.EventHandler(this.btnProdutosVendidos_Click);
            this.btnVendasdeProdutos.MouseLeave += new System.EventHandler(this.btnProdutosVendidos_MouseLeave);
            // 
            // lblLoguedUsuarioNome
            // 
            this.lblLoguedUsuarioNome.AutoSize = true;
            this.lblLoguedUsuarioNome.Location = new System.Drawing.Point(70, 23);
            this.lblLoguedUsuarioNome.Name = "lblLoguedUsuarioNome";
            this.lblLoguedUsuarioNome.Size = new System.Drawing.Size(102, 19);
            this.lblLoguedUsuarioNome.TabIndex = 5;
            this.lblLoguedUsuarioNome.Text = "Usuário Logado";
            // 
            // lblLoguedLojaNome
            // 
            this.lblLoguedLojaNome.AutoSize = true;
            this.lblLoguedLojaNome.Location = new System.Drawing.Point(50, 1);
            this.lblLoguedLojaNome.Name = "lblLoguedLojaNome";
            this.lblLoguedLojaNome.Size = new System.Drawing.Size(93, 19);
            this.lblLoguedLojaNome.TabIndex = 4;
            this.lblLoguedLojaNome.Text = "Nome da Loja";
            // 
            // lblLoguedUsuario
            // 
            this.lblLoguedUsuario.AutoSize = true;
            this.lblLoguedUsuario.Location = new System.Drawing.Point(8, 23);
            this.lblLoguedUsuario.Name = "lblLoguedUsuario";
            this.lblLoguedUsuario.Size = new System.Drawing.Size(56, 19);
            this.lblLoguedUsuario.TabIndex = 3;
            this.lblLoguedUsuario.Text = "Usuário:";
            // 
            // lblLoguedLoja
            // 
            this.lblLoguedLoja.AutoSize = true;
            this.lblLoguedLoja.Location = new System.Drawing.Point(8, 1);
            this.lblLoguedLoja.Name = "lblLoguedLoja";
            this.lblLoguedLoja.Size = new System.Drawing.Size(36, 19);
            this.lblLoguedLoja.TabIndex = 2;
            this.lblLoguedLoja.Text = "Loja:";
            // 
            // lblTrial
            // 
            this.lblTrial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTrial.AutoSize = true;
            this.lblTrial.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblTrial.Location = new System.Drawing.Point(314, 35);
            this.lblTrial.Name = "lblTrial";
            this.lblTrial.Size = new System.Drawing.Size(107, 15);
            this.lblTrial.TabIndex = 16;
            this.lblTrial.Text = "Versão de Avaliação";
            this.lblTrial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTrial.Visible = false;
            // 
            // metroButton4
            // 
            this.metroButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroButton4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.metroButton4.ForeColor = System.Drawing.Color.White;
            this.metroButton4.Location = new System.Drawing.Point(8, 197);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(239, 23);
            this.metroButton4.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroButton4.TabIndex = 13;
            this.metroButton4.Text = "Descontos | Cancelamentos | Transferências";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.UseStyleColors = true;
            this.metroButton4.Visible = false;
            // 
            // FRM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(453, 395);
            this.ControlBox = false;
            this.Controls.Add(this.lblTrial);
            this.Controls.Add(this.pnLogued);
            this.Controls.Add(this.pnLogin);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblReportPlus);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.pbMinimize);
            this.Controls.Add(this.pbConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FRM_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfig)).EndInit();
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            this.pnLogued.ResumeLayout(false);
            this.pnLogued.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmbxLoja;
        private MetroFramework.Controls.MetroComboBox cmbxUsuarios;
        private MetroFramework.Controls.MetroLabel lblLoja;
        private MetroFramework.Controls.MetroLabel lblUsuario;
        private MetroFramework.Controls.MetroLabel lblSenha;
        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroTextBox txtbxSenha;
        private System.Windows.Forms.PictureBox pbConfig;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.PictureBox pbExit;
        private MetroFramework.Controls.MetroLabel lblReportPlus;
        private System.Windows.Forms.PictureBox pbLogo;
        private MetroFramework.Controls.MetroPanel pnLogin;
        private MetroFramework.Controls.MetroPanel pnLogued;
        private MetroFramework.Controls.MetroButton btnVendasdeProdutos;
        private MetroFramework.Controls.MetroLabel lblLoguedUsuarioNome;
        private MetroFramework.Controls.MetroLabel lblLoguedLojaNome;
        private MetroFramework.Controls.MetroLabel lblLoguedUsuario;
        private MetroFramework.Controls.MetroLabel lblLoguedLoja;
        private MetroFramework.Controls.MetroButton btnSairSelecaoRel;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroLabel lblTrial;
        private MetroFramework.Controls.MetroButton metroButton4;
    }
}

