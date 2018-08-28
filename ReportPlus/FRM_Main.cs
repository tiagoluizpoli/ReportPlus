using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReportPlus.Models;
using ReportPlus.DATABASE;
using ReportPlus.Tools;
using System.IO;

namespace ReportPlus
{
    public partial class FRM_Main : Form
    {
        public FRM_Main()
        {
            InitializeComponent();
            Win_Registry.ValidarGradeDeRegistros();
            CarregarLojas();
            PosicaoInicial();
            carregarLogo();
        }

        //##Métodos Privados

        //Posiciona ps elementos da maneira padrão
        private void PosicaoInicial()
        {
            pnLogin.Visible = true;
            pnLogued.Visible = false;
            if (cmbxLoja.SelectedIndex > -1)
            {
                cmbxLoja.SelectedIndex = 0;
            }
            txtbxSenha.Text = string.Empty;
            pbConfig.Visible = true;
        }
        


        //Carregar Lojas
        public void CarregarLojas()
        {
            try
            {
                List<_loja> lista_lojas = new List<_loja>();
                lista_lojas.Add(new _loja
                {
                    Sigla = "00000",
                    Nome = "Selecione uma Loja"
                });
                db_Loja.CarregarLojas(lista_lojas);
                cmbxLoja.ValueMember = "Sigla";
                cmbxLoja.DisplayMember = "Nome";
                cmbxLoja.DataSource = lista_lojas;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
            }
        }

        private void carregarLogo()
        {
            try
            {
                pbLogo.ImageLocation = Win_Registry.gravar_ler_pic_path();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        



        //Logica de Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cmbxUsuarios.DataSource != null)
            {
                if (txtbxSenha.Text == (cmbxUsuarios.SelectedItem as _usuario).Senha)
                {
                    pnLogin.Visible = false;
                    pnLogued.Visible = true;
                    pbConfig.Visible = false;
                    lblLoguedLojaNome.Text = (cmbxLoja.SelectedItem as _loja).Nome;
                    lblLoguedUsuarioNome.Text = (cmbxUsuarios.SelectedItem as _usuario).Codigo;

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Senha incorreta, tente novamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Hand, 200);
                }
            }
        }


        // PictureBoxes
        //Abrir Configurações (Simula Botão)
        private void pbConfig_Click(object sender, EventArgs e)
        {
            FRM_Config f = new FRM_Config();
            f.ShowDialog();
            carregarLogo();
        }
       




        

        //minimizar e fechar (Simula Botão)
        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        

        //Botões

        private void btnSair_Click(object sender, EventArgs e)
        {
            PosicaoInicial();

        }

        private void btnProdutosVendidos_Click(object sender, EventArgs e)
        {
            FRM_Report_ProdVend f = new FRM_Report_ProdVend();
            f.ShowDialog();
            
        }



        // Ação ao selecionar uma loja
        private void cmbxLoja_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if ((cmbxLoja.SelectedItem as _loja).Sigla != "00000")
                {
                    List<_usuario> lista_usuarios = new List<_usuario>();
                    db_Usuarios.CarregarUsuarios((cmbxLoja.SelectedItem as _loja).Sigla, lista_usuarios);
                    cmbxUsuarios.ValueMember = "Codigo";
                    cmbxUsuarios.DisplayMember = "Codigo";
                    cmbxUsuarios.DataSource = lista_usuarios;
                }
                else
                {
                    cmbxUsuarios.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
                this.Dispose();
            }
        }

        // entrar ao apertar Enter
        private void txtbxSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                e.Handled = true;
                e.SuppressKeyPress = true;
                btnLogin_Click(sender, e);
            }
        }

        private void btnProdutosVendidos_MouseLeave(object sender, EventArgs e)
        {
            if ((sender as Button).Focused)
            {
                lblLoguedLoja.Focus();
            }
        }
    }
}
