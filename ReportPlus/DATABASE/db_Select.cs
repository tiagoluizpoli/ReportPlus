using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReportPlus.Models;
using ReportPlus.DATABASE;
using System.Data.SqlClient;
using System.Threading;
using System.ComponentModel;


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
                db_Connection.FecharConexao();
                throw ex;
            }
        }



        #region Carregar Filtros

        public static void CarregarVendedores(string sigla, DateTime periodoInicial, DateTime periodoFinal, List<_vendedor> lista_vendedor)
        {
            try
            {
                db_Connection.com.Parameters.AddWithValue("@sigla", sigla);
                db_Connection.com.Parameters.AddWithValue("@periodoInicial", periodoInicial);
                db_Connection.com.Parameters.AddWithValue("@periodoFinal", periodoFinal);
                db_Connection.com.CommandText = "select Motoqueiro from mov where horario between @periodoInicial and @periodoFinal and loja = @sigla group by Motoqueiro";
                db_Connection.AbrirConexao();
                SqlDataReader r = db_Connection.com.ExecuteReader();
                while (r.Read())
                {
                    lista_vendedor.Add(new _vendedor
                    {
                        
                        NomeVendedor = r["Motoqueiro"].ToString()
                    });
                }
                db_Connection.FecharConexao();
            }
            catch (Exception ex)
            {
                db_Connection.FecharConexao();
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
                db_Connection.com.CommandText = "select grupo.Descricao,grupo.grupo from grupo inner join produto on grupo.Grupo = produto.grupo where produto.codproduto in (select mov.Produto from mov where Data between @periodoInicial and @periodoFinal) and grupo.loja = @sigla group by grupo.Descricao,grupo.grupo order by grupo.Descricao";
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
                db_Connection.FecharConexao();
                throw ex;
            }
        }

        public static void CarregarProdutos(string sigla, DateTime periodoInicial, DateTime periodoFinal, List<_produto> lista_Produtos)
        {
            try
            {
                db_Connection.com.Parameters.AddWithValue("@sigla", sigla);
                db_Connection.com.Parameters.AddWithValue("@periodoInicial", periodoInicial);
                db_Connection.com.Parameters.AddWithValue("@periodoFinal", periodoFinal);
                db_Connection.com.CommandText = "select p.codproduto, p.descriproduto from produto p inner join mov m on p.codproduto = m.produto where p.codproduto in (select mov.produto from mov where data between @periodoInicial and @periodoFinal) and p.loja = @sigla group by p.DescriProduto,p.codproduto order by p.DescriProduto";
                db_Connection.AbrirConexao();
                SqlDataReader r = db_Connection.com.ExecuteReader();
                while (r.Read())
                {
                    lista_Produtos.Add(new _produto
                    {
                        codproduto = r["codproduto"].ToString(),
                        descriproduto = r["descriproduto"].ToString()
                    });
                }
                db_Connection.FecharConexao();
            }
            catch (Exception ex)
            {
                db_Connection.FecharConexao();
                throw ex;
            }
        }

        public static void CarregarDiaSemana(string sigla, DateTime periodoInicial, DateTime periodoFinal, List<_diaSemana> lista_DiaSemana)
        {
            try
            {
                db_Connection.com.Parameters.AddWithValue("@sigla", sigla);
                db_Connection.com.Parameters.AddWithValue("@periodoInicial", periodoInicial);
                db_Connection.com.Parameters.AddWithValue("@periodoFinal", periodoFinal);
                db_Connection.com.CommandText = @"SET LANGUAGE 'Portuguese'; SELECT CAST(DATEPART (WEEKDAY, m.data)as int)NUM_DIASEMANA, DATENAME(weekday, m.Data) AS NOME_DIASEMANA from mov m where m.loja = @sigla and m.data between @periodoInicial and @periodoFinal group by  CAST(DATEPART (WEEKDAY, m.data)as int), DATENAME(weekday, m.Data) order by CAST(DATEPART (WEEKDAY, m.data)as int);";
                db_Connection.AbrirConexao();
                SqlDataReader r = db_Connection.com.ExecuteReader();
                while (r.Read())
                {
                    lista_DiaSemana.Add(new _diaSemana
                    {
                        NUM_DIASEMANA = Convert.ToInt32(r["NUM_DIASEMANA"]),
                        NOME_DIASEMANA = r["NOME_DIASEMANA"].ToString().ToUpper()
                    });
                }
                db_Connection.FecharConexao();
            }
            catch (Exception ex)
            {
                db_Connection.FecharConexao();
                throw ex;
            }
        }

        #endregion

        #region Carregar Relatório
        public static void CarregarRelatorio(string sigla, DateTime periodoInicial, DateTime periodoFinal ,List<_reportData> lista_ReportData,_reportDataTotais totais, ref string complementoWhere, ref string complementoOrderBy, BackgroundWorker bgw, bool ordData, bool ordHora)
        {
            try
            {
                string query = string.Empty;

                #region Seleciona Query

                
                if (ordData)
                {
                    if (ordHora)
                    {
                        query = @"SET LANGUAGE 'Portuguese'; SELECT l.sigla as NUM_LOJA, l.nome as LOJA, m.motoqueiro as VENDEDOR, g.Descricao AS GRUPO,  m.descricao as PRODUTO, m.Valor as VALOR_UNITARIO, sum(m.Qtde * m.Valor) as VALOR_TOTAL, sum(m.Qtde) as QUANTIDADE, m.data as DATA, DATEPART (WEEKDAY, m.data) AS NUM_DIASEMANA,  DATENAME(weekday, m.Data) AS NOME_DIASEMANA,  m.Horario as HORA, p.Grupo AS COD_GRUPO, p.CodProduto as COD_PRODUTO from mov m inner join Produto p on m.Produto = p.CodProduto inner join GRUPO g on p.Grupo = g.Grupo inner join LOJA l on l.sigla = p.loja where p.loja = @sigla and m.loja = @sigla and g.loja = @sigla and m.data between @periodoInicial and @periodoFinal " + complementoWhere + " group by m.Descricao, m.motoqueiro, p.CodProduto, p.Grupo, g.Descricao,m.Valor,m.data,l.sigla,l.nome,p.DescriProduto,m.Horario " + complementoOrderBy;
                    }
                    else
                    {
                        query = @"SET LANGUAGE 'Portuguese'; SELECT l.sigla as NUM_LOJA, l.nome as LOJA, m.motoqueiro as VENDEDOR, g.Descricao AS GRUPO,  m.descricao as PRODUTO, m.Valor as VALOR_UNITARIO, sum(m.Qtde * m.Valor) as VALOR_TOTAL, sum(m.Qtde) as QUANTIDADE, m.data as DATA, DATEPART (WEEKDAY, m.data) AS NUM_DIASEMANA,  DATENAME(weekday, m.Data) AS NOME_DIASEMANA, p.Grupo AS COD_GRUPO, p.CodProduto as COD_PRODUTO from mov m inner join Produto p on m.Produto = p.CodProduto inner join GRUPO g on p.Grupo = g.Grupo inner join LOJA l on l.sigla = p.loja where p.loja = @sigla and m.loja = @sigla and g.loja = @sigla and m.data between @periodoInicial and @periodoFinal " + complementoWhere + " group by m.Descricao, m.motoqueiro, p.CodProduto, p.Grupo, g.Descricao,m.Valor,m.data,l.sigla,l.nome,p.DescriProduto " + complementoOrderBy;
                    }
                }
                else
                {
                    query = @"SET LANGUAGE 'Portuguese'; SELECT l.sigla as NUM_LOJA, l.nome as LOJA, m.motoqueiro as VENDEDOR, g.Descricao AS GRUPO,  m.descricao as PRODUTO, m.Valor as VALOR_UNITARIO, sum(m.Qtde * m.Valor) as VALOR_TOTAL, sum(m.Qtde) as QUANTIDADE, p.Grupo AS COD_GRUPO, p.CodProduto as COD_PRODUTO from mov m inner join Produto p on m.Produto = p.CodProduto inner join GRUPO g on p.Grupo = g.Grupo inner join LOJA l on l.sigla = p.loja where p.loja = @sigla and m.loja = @sigla and g.loja = @sigla and m.data between @periodoInicial and @periodoFinal " + complementoWhere + " group by m.Descricao, m.motoqueiro, p.CodProduto, p.Grupo, g.Descricao,m.Valor,l.sigla,l.nome,p.DescriProduto " + complementoOrderBy;
                }
                #endregion



                db_Connection.com.Parameters.AddWithValue("@sigla", sigla);
                db_Connection.com.Parameters.AddWithValue("@periodoInicial", periodoInicial);
                db_Connection.com.Parameters.AddWithValue("@periodoFinal", periodoFinal);
                db_Connection.com.CommandText = query;
                db_Connection.AbrirConexao();
                SqlDataReader r = db_Connection.com.ExecuteReader();
                while (r.Read())
                {
                    if (ordData)
                    {
                        if (ordHora)
                        {
                            lista_ReportData.Add(new _reportData
                            {
                                NUM_LOJA = Convert.ToString(r["NUM_LOJA"]),
                                LOJA = Convert.ToString(r["LOJA"]),
                                VENDEDOR = Convert.ToString(r["VENDEDOR"]),
                                COD_GRUPO = Convert.ToInt32(r["COD_GRUPO"]),
                                GRUPO = Convert.ToString(r["GRUPO"]),
                                COD_PRODUTO = Convert.ToInt32(r["COD_PRODUTO"]),
                                PRODUTO = Convert.ToString(r["PRODUTO"]),
                                QUANTIDADE = Convert.ToDouble(r["QUANTIDADE"]),
                                VALOR_UNITARIO = Convert.ToDouble(r["VALOR_UNITARIO"]),
                                VALOR_TOTAL = Convert.ToDouble(r["VALOR_TOTAL"]),
                                DATA = Convert.ToDateTime(r["DATA"]),
                                HORA = Convert.ToDateTime(r["HORA"]),
                                NUM_DIASEMANA = Convert.ToInt32(r["NUM_DIASEMANA"]),
                                NOME_DIASEMANA = r["NOME_DIASEMANA"].ToString().ToUpper(),
                            });
                            totais.TOTAL_QTD_PRODUTOS_VENDIDOS += Convert.ToDouble(r["QUANTIDADE"]);
                            totais.TOTAL_VALOR_PRODUTOS_VENDIDOS += Convert.ToDouble(r["VALOR_TOTAL"]);
                        }
                        else
                        {
                            lista_ReportData.Add(new _reportData
                            {
                                NUM_LOJA = Convert.ToString(r["NUM_LOJA"]),
                                LOJA = Convert.ToString(r["LOJA"]),
                                VENDEDOR = Convert.ToString(r["VENDEDOR"]),
                                COD_GRUPO = Convert.ToInt32(r["COD_GRUPO"]),
                                GRUPO = Convert.ToString(r["GRUPO"]),
                                COD_PRODUTO = Convert.ToInt32(r["COD_PRODUTO"]),
                                PRODUTO = Convert.ToString(r["PRODUTO"]),
                                QUANTIDADE = Convert.ToDouble(r["QUANTIDADE"]),
                                VALOR_UNITARIO = Convert.ToDouble(r["VALOR_UNITARIO"]),
                                VALOR_TOTAL = Convert.ToDouble(r["VALOR_TOTAL"]),
                                DATA = Convert.ToDateTime(r["DATA"]),
                                NUM_DIASEMANA = Convert.ToInt32(r["NUM_DIASEMANA"]),
                                NOME_DIASEMANA = r["NOME_DIASEMANA"].ToString().ToUpper()
                            });
                            totais.TOTAL_QTD_PRODUTOS_VENDIDOS += Convert.ToDouble(r["QUANTIDADE"]);
                            totais.TOTAL_VALOR_PRODUTOS_VENDIDOS += Convert.ToDouble(r["VALOR_TOTAL"]);
                        }
                    }
                    else
                    {
                        lista_ReportData.Add(new _reportData
                        {
                            NUM_LOJA = Convert.ToString(r["NUM_LOJA"]),
                            LOJA = Convert.ToString(r["LOJA"]),
                            VENDEDOR = Convert.ToString(r["VENDEDOR"]),
                            COD_GRUPO = Convert.ToInt32(r["COD_GRUPO"]),
                            GRUPO = Convert.ToString(r["GRUPO"]),
                            COD_PRODUTO = Convert.ToInt32(r["COD_PRODUTO"]),
                            PRODUTO = Convert.ToString(r["PRODUTO"]),
                            QUANTIDADE = Convert.ToDouble(r["QUANTIDADE"]),
                            VALOR_UNITARIO = Convert.ToDouble(r["VALOR_UNITARIO"]),
                            VALOR_TOTAL = Convert.ToDouble(r["VALOR_TOTAL"]),
                        });
                        totais.TOTAL_QTD_PRODUTOS_VENDIDOS += Convert.ToDouble(r["QUANTIDADE"]);
                        totais.TOTAL_VALOR_PRODUTOS_VENDIDOS += Convert.ToDouble(r["VALOR_TOTAL"]);
                       
                    }
                    bgw.ReportProgress(lista_ReportData.Count, false);
                }
                db_Connection.FecharConexao();
            }
            catch (Exception ex)
            {
                db_Connection.FecharConexao();
                throw ex;
            }
        }

        public static int carregarRelatorioCount(string sigla, DateTime periodoInicial, DateTime periodoFinal, ref string complementoWhere, ref string complementoOrderBy)
        {
            try
            {
                db_Connection.com.Parameters.AddWithValue("@sigla", sigla);
                db_Connection.com.Parameters.AddWithValue("@periodoInicial", periodoInicial);
                db_Connection.com.Parameters.AddWithValue("@periodoFinal", periodoFinal);
                db_Connection.com.CommandText = @"SELECT count(m.loja) from mov m inner join Produto p on m.Produto = p.CodProduto inner join GRUPO g on p.Grupo = g.Grupo inner join LOJA l on l.sigla = p.loja where m.loja = @sigla and m.data between @periodoInicial and @periodoFinal " + complementoWhere;
                db_Connection.AbrirConexao();
                int r = Convert.ToInt32(db_Connection.com.ExecuteScalar());
                db_Connection.FecharConexao();
                return r;
            }
            catch (Exception ex)
            {
                db_Connection.FecharConexao();
                throw ex;
            }
        }
        #endregion
    }
}
