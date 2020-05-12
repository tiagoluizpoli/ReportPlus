using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReportPlusActivator.Objetos;
using MySql.Data.MySqlClient;

namespace ReportPlusActivator.Database
{
    internal class db_comandos
    {
        internal static void CarregarUsuarios(List<_usuario> ListaUsuarios, ref string searchParam)
        {
            try
            {
                conexao.com.Parameters.AddWithValue("@search", "%" + searchParam + "%");
                conexao.com.CommandText = "select * from usuarios where nome like @search or login like @search;";
                conexao.con.Open();
                MySqlDataReader reader = conexao.com.ExecuteReader();
                while (reader.Read())
                {
                    ListaUsuarios.Add(new _usuario
                    {
                        id = Convert.ToUInt32(reader["id"]),
                        nome = Convert.ToString(reader["nome"]),
                        login = Convert.ToString(reader["login"]),
                        senha = Convert.ToString(reader["senha"]),
                        ativo = Convert.ToBoolean(reader["ativo"])
                    });
                }
                conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
