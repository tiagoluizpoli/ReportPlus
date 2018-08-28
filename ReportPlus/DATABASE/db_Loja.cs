using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReportPlus.Models;
using System.Data.SqlClient;

namespace ReportPlus.DATABASE
{
    public class db_Loja
    {
        public static void CarregarLojas(List<_loja> lista_lojas)
        {
            try
            {
                db_Connection.AbrirConexao();
                db_Connection.com.CommandText = "select Sigla, Nome from Loja where Ativo = 1";
                SqlDataReader r = db_Connection.com.ExecuteReader();
                while (r.Read())
                {
                    lista_lojas.Add(new _loja
                    {
                        Sigla = r["Sigla"].ToString(),
                        Nome = r["Nome"].ToString()
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
