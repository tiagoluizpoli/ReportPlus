using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReportPlus.Models;
using ReportPlus.DATABASE;
using System.Data.SqlClient;

namespace ReportPlus.DATABASE
{
    public class db_Usuarios
    {
        public static void CarregarUsuarios(string loja, List<_usuario> lista_usuario)
        {
            try
            {
                db_Connection.com.Parameters.AddWithValue("@loja", loja);
                db_Connection.com.CommandText = "select Codigo, Senha from usuario where loja = @loja and Enabled = 1";
                db_Connection.AbrirConexao();
                SqlDataReader r = db_Connection.com.ExecuteReader();
                while (r.Read())
                {
                    lista_usuario.Add(new _usuario
                    {
                        Codigo = r["Codigo"].ToString(),
                        Senha = r["Senha"].ToString()                        
                    });
                }
                db_Connection.FecharConexao();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
