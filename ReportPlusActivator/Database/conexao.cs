using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using ReportPlusActivator.Funcoes;

namespace ReportPlusActivator.Database
{
    internal class conexao
    {
        internal static MySqlConnection con = new MySqlConnection(MontarStringDeCoxao());
        internal static MySqlCommand com = new MySqlCommand("", con);

        internal static void AbrirConexao()
        {
            try
            {
                //com.Connection = con;
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                else
                {
                    FecharConexao();
                    con.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        internal static void FecharConexao()
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    com.Parameters.Clear();
                    con.Close();
                    com.CommandTimeout = 600;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static string MontarStringDeCoxao()
        {
            try
            {
                return @"Server="+WinReg.gravar_ler_bd_serveradress()+";Port="+WinReg.gravar_ler_bd_serverport()+ ";Database=ReportManagement;Uid="+WinReg.gravar_ler_bd_user()+";Pwd="+WinReg.gravar_ler_bd_password()+";";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
