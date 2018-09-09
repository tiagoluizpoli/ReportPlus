using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReportPlus.Models;

namespace ReportPlus.Tools
{
    public class MontaFiltros
    {
        public static void MontaFiltroProdVend( bool data_vendedor, bool porVendedor, List<_vendedor> lista_vendedores, bool porGruposProduto, List<_grupoProduto> lista_grupoProduto, bool porProduto, List<_produto> lista_Produtos, bool porDiaSemana, List<_diaSemana> lista_DiasSemana, ref string complementoWhere, ref string complementoOrderBy)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                if (data_vendedor)
                {
                    //verdadeiro == ordenar por Data
                    complementoOrderBy = "order by M.data, m.motoqueiro,g.Descricao,p.DescriProduto, CAST(DATEPART (WEEKDAY, m.data)as int)";
                }
                else
                {
                    //falso == ordenar por vendedor
                    complementoOrderBy = "order by m.motoqueiro, M.data,g.Descricao,p.DescriProduto, CAST(DATEPART (WEEKDAY, m.data)as int)";
                }


                if (porVendedor || porGruposProduto || porProduto || porDiaSemana)
                {

                    if (porVendedor)
                    {
                        sb.Append(" and ");
                        sb.Append(Filtro_vendedores_string(lista_vendedores));
                    }
                    if (porGruposProduto)
                    {
                        sb.Append(" and ");
                        sb.Append(Filtro_GruposProduto_string(lista_grupoProduto));
                    }
                    if (porProduto)
                    {
                        sb.Append(" and ");
                        sb.Append(Filtro_Produtos_string(lista_Produtos));
                    }
                    if (porDiaSemana)
                    {
                        sb.Append(" and ");
                        sb.Append(Filtro_DiasSemana_string(lista_DiasSemana));
                    }
                    complementoWhere = sb.ToString();
                }
                else
                {
                    complementoWhere = string.Empty;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string Filtro_vendedores_string(List<_vendedor> lista_vendedores)
        {
            try
            {

                StringBuilder sb = new StringBuilder();
                sb.Append("(");
                if (lista_vendedores.Count > 1)
                {
                    foreach (var item in lista_vendedores)
                    {
                        if (lista_vendedores.IndexOf(item) > 0)
                        {
                            sb.Append(" or ");
                        }
                        sb.Append("m.Motoqueiro = '" + item.NomeVendedor + "'");
                    }
                }
                else if (lista_vendedores.Count == 1)
                {
                    sb.Append("m.Motoqueiro = '" + lista_vendedores[0].NomeVendedor + "'");
                }
                sb.Append(")");


                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static string Filtro_GruposProduto_string(List<_grupoProduto> lista_GruposProduto)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("(");
                if (lista_GruposProduto.Count > 1)
                {
                    foreach (var item in lista_GruposProduto)
                    {
                        if (lista_GruposProduto.IndexOf(item) > 0)
                        {
                            sb.Append(" or ");
                        }
                        sb.Append("g.Grupo = '" + item.Grupo + "'");
                    }
                }
                else if (lista_GruposProduto.Count == 1)
                {
                    sb.Append("g.Grupo = '" + lista_GruposProduto[0].Grupo + "'");
                }
                sb.Append(")");


                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static string Filtro_Produtos_string(List<_produto> lista_Produtos)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("(");
                if (lista_Produtos.Count > 1)
                {
                    foreach (var item in lista_Produtos)
                    {
                        if (lista_Produtos.IndexOf(item) > 0)
                        {
                            sb.Append(" or ");
                        }
                        sb.Append("p.CodProduto = '" + item.codproduto + "'");
                    }
                }
                else if (lista_Produtos.Count == 1)
                {
                    sb.Append("p.CodProduto = '" + lista_Produtos[0].codproduto + "'");
                }
                sb.Append(")");


                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static string Filtro_DiasSemana_string(List<_diaSemana> lista_DiasSemana)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("(");
                if (lista_DiasSemana.Count > 1)
                {
                    foreach (var item in lista_DiasSemana)
                    {
                        if (lista_DiasSemana.IndexOf(item) > 0)
                        {
                            sb.Append(" or ");
                        }
                        sb.Append("DATEPART (WEEKDAY, m.data) = '" + item.NUM_DIASEMANA + "'");
                    }
                }
                else if (lista_DiasSemana.Count == 1)
                {
                    sb.Append("DATEPART (WEEKDAY, m.data) = '" + lista_DiasSemana[0].NUM_DIASEMANA + "'");
                }
                sb.Append(")");


                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
