namespace ReportPlusActivator
{
    partial class FRM_ReportPlusActivator
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtbxUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnLogin = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxSenha = new System.Windows.Forms.TextBox();
            this.pnAtivacao = new System.Windows.Forms.Panel();
            this.btnSair2 = new System.Windows.Forms.Button();
            this.btnAtivar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbxCodAtivacao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbxCNPJ = new System.Windows.Forms.TextBox();
            this.pnLogin.SuspendLayout();
            this.pnAtivacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbxUsuario
            // 
            this.txtbxUsuario.Location = new System.Drawing.Point(67, 54);
            this.txtbxUsuario.Name = "txtbxUsuario";
            this.txtbxUsuario.Size = new System.Drawing.Size(190, 20);
            this.txtbxUsuario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuário";
            // 
            // pnLogin
            // 
            this.pnLogin.Controls.Add(this.btnSair);
            this.pnLogin.Controls.Add(this.btnEntrar);
            this.pnLogin.Controls.Add(this.label2);
            this.pnLogin.Controls.Add(this.txtbxSenha);
            this.pnLogin.Controls.Add(this.label1);
            this.pnLogin.Controls.Add(this.txtbxUsuario);
            this.pnLogin.Location = new System.Drawing.Point(12, 12);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Size = new System.Drawing.Size(321, 181);
            this.pnLogin.TabIndex = 2;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(168, 119);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(89, 23);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(67, 119);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(89, 23);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // txtbxSenha
            // 
            this.txtbxSenha.Location = new System.Drawing.Point(67, 93);
            this.txtbxSenha.Name = "txtbxSenha";
            this.txtbxSenha.PasswordChar = '*';
            this.txtbxSenha.Size = new System.Drawing.Size(190, 20);
            this.txtbxSenha.TabIndex = 2;
            // 
            // pnAtivacao
            // 
            this.pnAtivacao.Controls.Add(this.btnSair2);
            this.pnAtivacao.Controls.Add(this.btnAtivar);
            this.pnAtivacao.Controls.Add(this.label3);
            this.pnAtivacao.Controls.Add(this.txtbxCodAtivacao);
            this.pnAtivacao.Controls.Add(this.label4);
            this.pnAtivacao.Controls.Add(this.txtbxCNPJ);
            this.pnAtivacao.Location = new System.Drawing.Point(12, 199);
            this.pnAtivacao.Name = "pnAtivacao";
            this.pnAtivacao.Size = new System.Drawing.Size(321, 181);
            this.pnAtivacao.TabIndex = 6;
            this.pnAtivacao.Visible = false;
            // 
            // btnSair2
            // 
            this.btnSair2.Location = new System.Drawing.Point(168, 119);
            this.btnSair2.Name = "btnSair2";
            this.btnSair2.Size = new System.Drawing.Size(89, 23);
            this.btnSair2.TabIndex = 5;
            this.btnSair2.Text = "Sair";
            this.btnSair2.UseVisualStyleBackColor = true;
            // 
            // btnAtivar
            // 
            this.btnAtivar.Location = new System.Drawing.Point(67, 119);
            this.btnAtivar.Name = "btnAtivar";
            this.btnAtivar.Size = new System.Drawing.Size(89, 23);
            this.btnAtivar.TabIndex = 4;
            this.btnAtivar.Text = "Ativar";
            this.btnAtivar.UseVisualStyleBackColor = true;
            this.btnAtivar.Click += new System.EventHandler(this.btnAtivar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cod. Ativação";
            // 
            // txtbxCodAtivacao
            // 
            this.txtbxCodAtivacao.Location = new System.Drawing.Point(67, 93);
            this.txtbxCodAtivacao.Name = "txtbxCodAtivacao";
            this.txtbxCodAtivacao.Size = new System.Drawing.Size(190, 20);
            this.txtbxCodAtivacao.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "CNPJ";
            // 
            // txtbxCNPJ
            // 
            this.txtbxCNPJ.Location = new System.Drawing.Point(67, 54);
            this.txtbxCNPJ.Name = "txtbxCNPJ";
            this.txtbxCNPJ.Size = new System.Drawing.Size(190, 20);
            this.txtbxCNPJ.TabIndex = 0;
            // 
            // FRM_ReportPlusActivator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 398);
            this.Controls.Add(this.pnLogin);
            this.Controls.Add(this.pnAtivacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_ReportPlusActivator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Plus Activator";
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            this.pnAtivacao.ResumeLayout(false);
            this.pnAtivacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnLogin;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbxSenha;
        private System.Windows.Forms.Panel pnAtivacao;
        private System.Windows.Forms.Button btnSair2;
        private System.Windows.Forms.Button btnAtivar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbxCodAtivacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbxCNPJ;
    }
}

