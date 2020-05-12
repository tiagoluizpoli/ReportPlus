using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReportPlusActivator.Negocios;

namespace ReportPlusActivator
{
    public partial class FRM_ReportPlusActivator : Form
    {
        public FRM_ReportPlusActivator()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Usuarios.ValidarLogin(txtbxUsuario.Text, txtbxSenha.Text))
                {
                    pnAtivacao.Visible = true;
                    pnLogin.Visible = false;
                }
                else
                {
                    MessageBox.Show("Usuário ou Senha incorretos!");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnAtivar_Click(object sender, EventArgs e)
        {

        }
    }
}
