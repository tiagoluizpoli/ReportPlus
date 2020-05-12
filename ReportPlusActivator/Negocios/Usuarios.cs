using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReportPlusActivator.Objetos;
using ReportPlusActivator.Database;

namespace ReportPlusActivator.Negocios
{
    internal class Usuarios
    {
        private static List<_usuario> ListaUsuarios = new List<_usuario>();
        internal static bool ValidarLogin(string login, string senha)
        {
            try
            {
                string searchparam = string.Empty;
                bool validado = false;
                ListaUsuarios.Clear();
                db_comandos.CarregarUsuarios(ListaUsuarios, ref searchparam);

                foreach (var user in ListaUsuarios)
                {
                    if (user.login == login && user.senha == senha)
                    {
                        if (user.ativo)
                        {
                            validado = true;
                        }
                        else
                        {
                            validado = false;
                        }
                    }
                    else
                    {
                        validado = false;
                    }
                }
                return validado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
