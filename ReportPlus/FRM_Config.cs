using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ReportPlus.Tools;
using ReportPlus.DATABASE;

namespace ReportPlus
{
    public partial class FRM_Config : Form
    {
        public FRM_Config()
        {
            InitializeComponent();
            pgrspnTesteConexao.Visible = false;
            lblMensagemDatabase.Visible = false;
            CarregarRegistros();
            carregarImagemlogo();
        }

        private void CarregarRegistros()
        {
            try
            {
                txtbxServerIP.Text = Win_Registry.gravar_ler_server_adress();
                txtbxServerPort.Text = Win_Registry.gravar_ler_server_port();
                txtbxDatabasePath.Text = Win_Registry.gravar_ler_database();
                string user = Win_Registry.gravar_ler_bd_user();
                string password = Win_Registry.gravar_ler_bd_password();
                txtbxUsuario.Text = PasswordEncryption.Decrypt(ref user);
                txtbxSenha.Text = PasswordEncryption.Decrypt(ref password);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }
       

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       

        private void txtbxServerPort_TextChanged(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char item in txtbxServerPort.Text)
            {
                if (char.IsNumber(item))
                {
                    sb.Append(item);
                }
            }
            txtbxServerPort.Text = sb.ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                               
                string user = txtbxUsuario.Text;
                string senha = txtbxSenha.Text;
                
                user = PasswordEncryption.Encrypt(ref user);
                senha = PasswordEncryption.Encrypt(ref senha);

                Win_Registry.gravar_server_adress(txtbxServerIP.Text);
                Win_Registry.gravar_server_port(txtbxServerPort.Text);
                Win_Registry.gravar_database(txtbxDatabasePath.Text);
                Win_Registry.gravar_bd_user(user);
                Win_Registry.gravar_bd_password(senha);

                if (bgWorker2.IsBusy != true)
                {
                    bgWorker2.RunWorkerAsync();
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        private void btnTestarConexao_Click(object sender, EventArgs e)
        {
            try
            {
                
                bgWorker.RunWorkerAsync(pgrspnTesteConexao);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }




        //background worker de verificação de conexão
        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                bgWorker.ReportProgress(1);
                e.Result = (bool)db_Connection.verificarConexao();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            if ((bool)e.Result)
            {
                MetroFramework.MetroMessageBox.Show(this, "Conexão realizada com sucesso.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information, 130);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Falha na conexão. Verifique os dados informados e tente novamente.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Warning, 130);
            }
            pgrspnTesteConexao.Visible = false;
            pgrspnTesteConexao.Spinning = false;
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pgrspnTesteConexao.Visible = true;
            pgrspnTesteConexao.Spinning = true;
            
        }




        
        //Background Worker que exibe a mensagem de salvo por alguns segundos
        private void bgWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            bgWorker2.ReportProgress(1);
            Thread.Sleep(4000);
                
        }

        private void bgWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblMensagemDatabase.Visible = false;
        }

        private void bgWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                lblMensagemDatabase.Visible = true;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }



        private void btn_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                if ((sender as Button).Focused)
                {
                    lblServerIP.Focus();
                }              
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }









        //###################### Pics ##############################

        private void carregarImagemlogo()
        {
            

            try
            {
                txtbxPicLogoPath.Text = Win_Registry.gravar_ler_pic_path();
                pbLogoImg.ImageLocation = txtbxPicLogoPath.Text;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }

        }

        private void btnSearchPicLogoPath_Click(object sender, EventArgs e)
        {
            try
            {
                opfdpic.AddExtension = true;
                opfdpic.CheckFileExists = true;
                opfdpic.DefaultExt = ".jpg";
                opfdpic.Title = "Selecione uma imagem para usar como \"Logo\" na tela inicial";

                opfdpic.Filter = "Todos os tipos de imagem|*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.tif;*.tiff|" + "BMP|*.bmp|GIF|*.gif|JPG|*.jpg;*.jpeg|PNG|*.png|TIFF|*.tif;*.tiff";
                opfdpic.ShowDialog();
                txtbxPicLogoPath.Text = opfdpic.FileName;
                pbLogoImg.ImageLocation = opfdpic.FileName;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        private void btnSavePicLogoPath_Click(object sender, EventArgs e)
        {
            try
            {
                Win_Registry.gravar_pic_path(txtbxPicLogoPath.Text);
                bgWorker3.RunWorkerAsync();

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        private void bgWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            //    bgWorker3.ReportProgress(1);
            //    Thread.Sleep(3000);

            for (int i = 1; i < 4; i++)
            {
                bgWorker3.ReportProgress(i);
                Thread.Sleep(1000);
            }
        }

        private void bgWorker3_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblMensagemPic.Visible = true;
            lblMensagemPic.Text = lblMensagemPic.Text + ".";
        }

        private void bgWorker3_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblMensagemPic.Visible = false;
            lblMensagemPic.Text = "Caminho de Imagem Salvo";
        }

        private void btnClearFocus_Click(object sender, EventArgs e)
        {
            try
            {
                if ((sender as Button).Focused)
                {
                    lblLogoPath.Focus();
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        
    }
}
