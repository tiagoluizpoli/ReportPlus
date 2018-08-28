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
    public class db_Select
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

        public static void CarregarVendedores(string sigla, DateTime periodoInicial, DateTime periodoFinal, List<_vendedor> lista_vendedor)
        {
            try
            {
                db_Connection.com.Parameters.AddWithValue("@sigla", sigla);
                db_Connection.com.Parameters.AddWithValue("@periodoInicial", periodoInicial);
                db_Connection.com.Parameters.AddWithValue("@periodoFinal", periodoFinal);
                db_Connection.com.CommandText = "select CodVendedor, NomeVendedor from Vendedor where NomeVendedor in (select mov.Motoqueiro from mov where data between @periodoInicial and @periodoFinal) and loja = @sigla";
                db_Connection.AbrirConexao();
                SqlDataReader r = db_Connection.com.ExecuteReader();
                while (r.Read())
                {
                    lista_vendedor.Add(new _vendedor
                    {
                        CodVendedor = r["CodVendedor"].ToString(),
                        NomeVendedor = r["NomeVendedor"].ToString()
                    });
                }
                db_Connection.FecharConexao();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void CarregarGruposProduto(string sigla, DateTime periodoInicial, DateTime periodoFinal, List<_grupoProduto> lista_GrupoProdutos)
        {
            try
            {
                db_Connection.com.Parameters.AddWithValue("@sigla", sigla);
                db_Connection.com.Parameters.AddWithValue("@periodoInicial", periodoInicial);
                db_Connection.com.Parameters.AddWithValue("@periodoFinal", periodoFinal);
                db_Connection.com.CommandText = "select grupo.Descricao,grupo.grupo from grupo inner join produto on grupo.Grupo = produto.grupo where produto.codproduto in (select mov.Produto from mov where data between @periodoInicial and @periodoFinal) and grupo.loja = @sigla group by grupo.Descricao,grupo.grupo order by grupo.Descricao";
                db_Connection.AbrirConexao();
                SqlDataReader r = db_Connection.com.ExecuteReader();
                while (r.Read())
                {
                    lista_GrupoProdutos.Add(new _grupoProduto
                    {
                        Grupo = r["grupo"].ToString(),
                        Descricao = r["Descricao"].ToString()
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
