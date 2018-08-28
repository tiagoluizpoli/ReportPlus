using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ReportPlus.Tools;

namespace ReportPlus.DATABASE
{
    public class db_Connection
    {
        public static SqlConnection con = new SqlConnection();
        public static SqlCommand com = new SqlCommand();

        public static void AbrirConexao()
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
                string user = Win_Registry.gravar_ler_bd_user();
                string password = Win_Registry.gravar_ler_bd_password();
                user = PasswordEncryption.Decrypt(ref user);
                password = PasswordEncryption.Decrypt(ref password);
                con.ConnectionString = StringBuilding.MontarConnectionString(Win_Registry.gravar_ler_server_adress(), Win_Registry.gravar_ler_server_port(), Win_Registry.gravar_ler_database(), user, password); 
                com.Connection = con;
                con.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FecharConexao()
        {
            try
            {
                com.Parameters.Clear();
                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool verificarConexao()
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    FecharConexao();
                }
                string user = Win_Registry.gravar_ler_bd_user();
                string password = Win_Registry.gravar_ler_bd_password();
                user = PasswordEncryption.Decrypt(ref user);
                password = PasswordEncryption.Decrypt(ref password);
                con.ConnectionString = StringBuilding.MontarConnectionString(Win_Registry.gravar_ler_server_adress(), Win_Registry.gravar_ler_server_port(), Win_Registry.gravar_ler_database(), user, password);
                con.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        

    }
}
