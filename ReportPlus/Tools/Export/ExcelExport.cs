﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using ReportPlus.Models;
using System.Threading;

namespace ReportPlus.Tools.Export
{
    public class ExcelExport
    {
        public static void ExportarRelatorioExcel(List<_reportData> listaReportData, _reportDataTotais totais, _FiltrosExport filtros, String path, bool data, bool hora)
        {
            try
            {
                
                XLWorkbook Pasta = new XLWorkbook();
                var back = XLColor.FromArgb(0, 0, 0);
                var fore = XLColor.FromArgb(255, 255, 255); 
                Excel_Script_Detalhamento(Pasta, listaReportData, "Detalhamento", ref data, ref hora, back, fore);
                Excel_Script_Totais(Pasta, totais, data, "Totais", back, fore);
                Excel_Script_Filtros(Pasta, filtros, "Filtros", back, fore);

                Pasta.SaveAs(path);
                Pasta.Dispose();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static void Excel_Script_Detalhamento(IXLWorkbook Pasta, List<_reportData> ListaReportData, string planilhaNome, ref bool data, ref bool hora, XLColor backColor, XLColor foreColor)
        {
            try
            {
                IXLWorksheet Planilha = Pasta.Worksheets.Add(planilhaNome);
                Planilha.Cell("A1").Value = "NUM LOJA";
                Planilha.Cell("B1").Value = "LOJA";
                Planilha.Cell("C1").Value = "VENDEDOR";
                Planilha.Cell("D1").Value = "GRUPO";
                Planilha.Cell("E1").Value = "CODIGO";
                Planilha.Cell("F1").Value = "PRODUTO";
                Planilha.Cell("G1").Value = "QUANTIDADE";
                Planilha.Cell("H1").Value = "VALOR UNITÁRIO";
                Planilha.Cell("I1").Value = "VALOR TOTAL";

                Planilha.Row(1).Height = 25;
                Planilha.SheetView.FreezeRows(1);
                Planilha.Row(1).Style.Font.SetFontSize(10).Alignment.WrapText = true;

                string dinamicRange = string.Empty;
                if (data)
                {
                    Planilha.Cell("J1").Value = "DATA";
                    Planilha.Cell("K1").Value = "NOME DIASEMANA";
                    if (hora)
                    {
                        Planilha.Cell("L1").Value = "HORA";
                        dinamicRange = "A1:L1";
                    }
                    else
                    {
                        dinamicRange = "A1:K1";
                    }
                }
                else
                {
                    dinamicRange  = "A1:I1";
                }

                var range = Planilha.Range(dinamicRange);
                range.Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                range.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                range.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                range.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                range.Style.Fill.BackgroundColor = backColor;
                range.Style.Font.SetBold().Font.FontColor = foreColor;





                int linha = 2;
                for (int i = 0; i < ListaReportData.Count; i++)
                {
                    
                    Planilha.Cell("A" + linha.ToString()).Value = ListaReportData[i].NUM_LOJA;
                    Planilha.Cell("B" + linha.ToString()).Value = ListaReportData[i].LOJA;
                    Planilha.Cell("C" + linha.ToString()).Value = ListaReportData[i].VENDEDOR;
                    Planilha.Cell("D" + linha.ToString()).Value = ListaReportData[i].GRUPO;
                    Planilha.Cell("E" + linha.ToString()).Value = ListaReportData[i].COD_PRODUTO;
                    Planilha.Cell("F" + linha.ToString()).Value = ListaReportData[i].PRODUTO;
                    Planilha.Cell("G" + linha.ToString()).Value = ListaReportData[i].QUANTIDADE;
                    Planilha.Cell("H" + linha.ToString()).Value = ListaReportData[i].VALOR_UNITARIO;
                    Planilha.Cell("I" + linha.ToString()).Value = ListaReportData[i].VALOR_TOTAL;
                    
                    

                    Planilha.Cell("A" + linha.ToString()).Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin).Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                    Planilha.Cell("B" + linha.ToString()).Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin);
                    Planilha.Cell("C" + linha.ToString()).Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin);
                    Planilha.Cell("D" + linha.ToString()).Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin).Alignment.SetHorizontal(XLAlignmentHorizontalValues.Left);
                    Planilha.Cell("E" + linha.ToString()).Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin).Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                    Planilha.Cell("F" + linha.ToString()).Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin);
                    Planilha.Cell("G" + linha.ToString()).Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin).Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                    Planilha.Cell("H" + linha.ToString()).Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin).Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                    Planilha.Cell("I" + linha.ToString()).Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin).Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

                    if (data)
                    {
                        Planilha.Cell("J" + linha.ToString()).Value = ListaReportData[i].DATA;
                        Planilha.Cell("K" + linha.ToString()).Value = ListaReportData[i].NOME_DIASEMANA;

                        Planilha.Cell("J" + linha.ToString()).Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin).Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                        Planilha.Cell("K" + linha.ToString()).Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin);

                        if (hora)
                        {
                            Planilha.Cell("L" + linha.ToString()).Value = ListaReportData[i].HORA.ToShortTimeString();
                            Planilha.Cell("L" + linha.ToString()).Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin).Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                        }
                    }

                    linha++;
                }
                linha--;

                Planilha.Column("A").Cells().Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin).NumberFormat.SetFormat("00000");
                Planilha.Column("H").Cells().Style.NumberFormat.Format = "R$0.00";
                Planilha.Column("I").Cells().Style.NumberFormat.Format = "R$0.00";


                

                Planilha.Column("A").Width = 10;
                Planilha.Column("B").Width = 30;
                Planilha.Column("C").Width = 30;
                Planilha.Column("D").Width = 30;
                Planilha.Column("E").Width = 10;
                Planilha.Column("F").Width = 40;
                Planilha.Column("G").Width = 12;
                Planilha.Column("H").Width = 12;
                Planilha.Column("I").Width = 12;
                if (data)
                {
                    Planilha.Column("J").Width = 12;
                    Planilha.Column("K").Width = 20;
                    if (hora)
                    {
                        Planilha.Column("L").Width = 12;
                    }
                }
                Planilha.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static void Excel_Script_Totais(IXLWorkbook Pasta, _reportDataTotais totais, bool data, string planilhaNome, XLColor backColor, XLColor foreColor)
        {
            try
            {
               
                IXLWorksheet Planilha = Pasta.Worksheets.Add(planilhaNome);

                #region Totais
                Planilha.Cell("A2").Value = "TOTAIS";
                Planilha.Cell("D2").Value = "QUANTIDADE PRODUTOS VENDIDOS:";
                Planilha.Cell("D3").Value = "VALOR PRODUTOS VENDIDOS:";
                Planilha.Cell("F2").Value = totais.TOTAL_QTD_PRODUTOS_VENDIDOS;
                Planilha.Cell("F3").Value = totais.TOTAL_VALOR_PRODUTOS_VENDIDOS;

                var rangeTotaisTiulo = Planilha.Range("A2:C3").Merge();
                rangeTotaisTiulo.Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin).Fill.BackgroundColor = backColor;
                rangeTotaisTiulo.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                rangeTotaisTiulo.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                rangeTotaisTiulo.Style.Font.SetBold().Font.FontColor = foreColor;
                rangeTotaisTiulo.Style.Font.FontSize = 20;


                var rangeTotaisQtdTitulo = Planilha.Range("D2:E2").Merge();
                rangeTotaisQtdTitulo.Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin).Font.FontSize = 11;
                rangeTotaisQtdTitulo.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
                rangeTotaisQtdTitulo.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                rangeTotaisQtdTitulo.Style.Font.Bold = true;

                var rangeTotaisValTitulo = Planilha.Range("D3:E3").Merge();
                rangeTotaisValTitulo.Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin).Font.FontSize = 11;
                rangeTotaisValTitulo.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
                rangeTotaisValTitulo.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                rangeTotaisValTitulo.Style.Font.Bold = true;

                var rangeTotaisQtd = Planilha.Range("F2:G2").Merge();
                rangeTotaisQtd.Style.Font.SetBold().Font.SetFontSize(16).Alignment.SetHorizontal(XLAlignmentHorizontalValues.Right).Alignment.SetVertical(XLAlignmentVerticalValues.Center).Border.SetOutsideBorder(XLBorderStyleValues.Thin);

                var rangeTotaisVal = Planilha.Range("F3:G3").Merge();
                rangeTotaisVal.Style.Font.SetBold().Font.SetFontSize(16).Alignment.SetHorizontal(XLAlignmentHorizontalValues.Right).Alignment.SetVertical(XLAlignmentVerticalValues.Center).Border.SetOutsideBorder(XLBorderStyleValues.Thin).NumberFormat.Format = "R$0.00";

                var rangeTotais = Planilha.Range("A2:G3");
                rangeTotais.Style.Border.SetOutsideBorder(XLBorderStyleValues.Medium);
                #endregion




                Planilha.Cell("A5").Value = "TOTAIS POR VENDEDOR";
                Planilha.Cell("E5").Value = "TOTAIS POR GRUPO";


                Planilha.Cell("A6").Value = "VENDEDOR";
                Planilha.Cell("B6").Value = "QUANTIDADE";
                Planilha.Cell("C6").Value = "VALOR TOTAL";

                Planilha.Cell("E6").Value = "GRUPO";
                Planilha.Cell("F6").Value = "QUANTIDADE";
                Planilha.Cell("G6").Value = "VALOR TOTAL";

                if (data)
                {
                    Planilha.Cell("I5").Value = "TOTAIS POR DATA";
                    Planilha.Cell("I6").Value = "DATA";
                    Planilha.Cell("J6").Value = "DIA DA SEMANA";
                    Planilha.Cell("K6").Value = "QUANTIDADE";
                    Planilha.Cell("L6").Value = "VALOR TOTAL";
                }

                Planilha.Row(2).Height = 25;
                Planilha.Row(3).Height = 25;
                Planilha.Row(4).Height = 25;
                Planilha.Row(5).Style.Font.SetFontSize(10).Alignment.WrapText = true;


                #region Vendedores

                var rangeTopVend = Planilha.Range("A5:C5").Merge();
                rangeTopVend.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                rangeTopVend.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                rangeTopVend.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                rangeTopVend.Style.Fill.BackgroundColor = backColor;
                rangeTopVend.Style.Font.SetBold().Font.FontColor = foreColor;

                var rangeVend = Planilha.Range("A6:c5");                
                rangeVend.Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                rangeVend.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                rangeVend.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                rangeVend.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                rangeVend.Style.Fill.BackgroundColor = backColor;
                rangeVend.Style.Font.SetBold().Font.FontColor = foreColor;

                #endregion

                #region Grupos

                var rangeTopGroup = Planilha.Range("E5:G5").Merge();
                rangeTopGroup.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                rangeTopGroup.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                rangeTopGroup.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                rangeTopGroup.Style.Fill.BackgroundColor = backColor;
                rangeTopGroup.Style.Font.SetBold().Font.FontColor = foreColor;

                var rangeGroup = Planilha.Range("E6:G6");
                rangeGroup.Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                rangeGroup.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                rangeGroup.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                rangeGroup.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                rangeGroup.Style.Fill.BackgroundColor = backColor;
                rangeGroup.Style.Font.SetBold().Font.FontColor = foreColor;
                #endregion

                #region Datas
                if (data)
                {
                    var rangeTopData = Planilha.Range("I5:L5").Merge();
                    rangeTopData.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                    rangeTopData.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    rangeTopData.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                    rangeTopData.Style.Fill.BackgroundColor = backColor;
                    rangeTopData.Style.Font.SetBold().Font.FontColor = foreColor;

                    var rangeData = Planilha.Range("I6:L6");
                    rangeData.Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                    rangeData.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                    rangeData.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    rangeData.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                    rangeData.Style.Fill.BackgroundColor = backColor;
                    rangeData.Style.Font.SetBold().Font.FontColor = foreColor;
                }
                #endregion

                #region Preenchimento

                int linha = 6;
                for (int i = 0; i < totais.LISTA_TOTAL_PRODUTOS_VENDIDOS_POR_VENDEDOR.Count; i++)
                {
                    
                    Planilha.Cell("A" + linha.ToString()).Value = totais.LISTA_TOTAL_PRODUTOS_VENDIDOS_POR_VENDEDOR[i].VENDEDOR_TOT;
                    Planilha.Cell("B" + linha.ToString()).Value = totais.LISTA_TOTAL_PRODUTOS_VENDIDOS_POR_VENDEDOR[i].QUANTIDADE_TOT_VEND;
                    Planilha.Cell("C" + linha.ToString()).Value = totais.LISTA_TOTAL_PRODUTOS_VENDIDOS_POR_VENDEDOR[i].VALOR_TOT_VEND;   

                    Planilha.Cell("A" + linha.ToString()).Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin);
                    Planilha.Cell("B" + linha.ToString()).Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin).Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                    Planilha.Cell("C" + linha.ToString()).Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin);
                    linha++;
                }
                

                linha = 6;
                for (int i = 0; i < totais.LISTA_TOTAL_PRODUTOS_VENDIDOS_POR_GRUPO.Count; i++)
                {

                    Planilha.Cell("E" + linha.ToString()).Value = totais.LISTA_TOTAL_PRODUTOS_VENDIDOS_POR_GRUPO[i].GRUPO_TOT;
                    Planilha.Cell("F" + linha.ToString()).Value = totais.LISTA_TOTAL_PRODUTOS_VENDIDOS_POR_GRUPO[i].QUANTIDADE_TOT_GRUPO;
                    Planilha.Cell("G" + linha.ToString()).Value = totais.LISTA_TOTAL_PRODUTOS_VENDIDOS_POR_GRUPO[i].VALOR_TOT_GRUPO;

                    Planilha.Cell("E" + linha.ToString()).Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin).Alignment.SetHorizontal(XLAlignmentHorizontalValues.Left);
                    Planilha.Cell("F" + linha.ToString()).Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin).Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                    Planilha.Cell("G" + linha.ToString()).Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin);
                    linha++;
                }
                linha--;


                if (data)
                {
                    linha = 6;
                    for (int i = 0; i < totais.LISTA_TOTAL_PRODUTOS_VENDIDOS_POR_DATA.Count; i++)
                    {

                        Planilha.Cell("I" + linha.ToString()).Value = totais.LISTA_TOTAL_PRODUTOS_VENDIDOS_POR_DATA[i].DATA_TOT;
                        Planilha.Cell("J" + linha.ToString()).Value = totais.LISTA_TOTAL_PRODUTOS_VENDIDOS_POR_DATA[i].NOME_DIASEMANA_TOT;
                        Planilha.Cell("K" + linha.ToString()).Value = totais.LISTA_TOTAL_PRODUTOS_VENDIDOS_POR_DATA[i].QUANTIDADE_TOT_DATA;
                        Planilha.Cell("L" + linha.ToString()).Value = totais.LISTA_TOTAL_PRODUTOS_VENDIDOS_POR_DATA[i].VALOR_TOT_DATA;

                        Planilha.Cell("I" + linha.ToString()).Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin);
                        Planilha.Cell("J" + linha.ToString()).Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin);
                        Planilha.Cell("K" + linha.ToString()).Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin).Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                        Planilha.Cell("L" + linha.ToString()).Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin);
                        linha++;
                    }
                    linha--;
                }


                #endregion



                Planilha.Column("C").Cells().Style.NumberFormat.Format = "R$0.00";
                Planilha.Column("G").Cells().Style.NumberFormat.Format = "R$0.00";

                Planilha.Column("A").Width = 30;
                Planilha.Column("B").Width = 12;
                Planilha.Column("C").Width = 12;

                Planilha.Column("E").Width = 30;
                Planilha.Column("F").Width = 12;
                Planilha.Column("G").Width = 12;

                Planilha.Column("D").Width = 3;
                Planilha.Column("H").Width = 3;


                if (data)
                {
                    Planilha.Column("L").Cells().Style.NumberFormat.Format = "R$0.00";

                    Planilha.Column("I").Width = 12;
                    Planilha.Column("J").Width = 17;
                    Planilha.Column("K").Width = 12;
                    Planilha.Column("L").Width = 12;
                }
                Planilha.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private static void Excel_Script_Filtros(IXLWorkbook Pasta, _FiltrosExport filtros, string planilhaNome, XLColor backColor, XLColor foreColor)
        {
            try
            {
                IXLWorksheet Planilha = Pasta.Worksheets.Add(planilhaNome);
                Planilha.ShowGridLines = false;
                Planilha.Columns("A:D").Width = 35;

                Planilha.Cell("A1").Value = "EXPORTADO DIA [ " + filtros.agora.ToShortDateString() + " ] ÀS [ " + filtros.agora.ToLongTimeString() + " ]";
                Planilha.Cell("C1").Value = "USUÁRIO: [ " + filtros.usuario.Codigo + " ]";
                Planilha.Cell("A2").Value = "LOJA: [ " + filtros.loja.Nome + " ]";
                Planilha.Cell("C2").Value = "CNPJ: [ " + filtros.loja.Cnpj + " ]";



                var rangeOutSideBorderA1B1 = Planilha.Range("A1:B1").Merge();
                rangeOutSideBorderA1B1.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                var rangeOutSideBorderA2B2 = Planilha.Range("A2:B2").Merge();
                rangeOutSideBorderA2B2.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                var rangeOutSideBorderC1D1 = Planilha.Range("C1:D1").Merge();
                rangeOutSideBorderC1D1.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                var rangeOutSideBorderC2D2 = Planilha.Range("C2:D2").Merge();
                rangeOutSideBorderC2D2.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                Planilha.Row(3).Height = 30;
                Planilha.Cell("A3").Value = "FILTROS";                
                Planilha.Cell("A3").Style.Font.FontSize = 25;
                var rangeTopFiltros = Planilha.Range("A3:D3").Merge();
                rangeTopFiltros.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                rangeTopFiltros.Style.Fill.BackgroundColor = backColor;
                rangeTopFiltros.Style.Font.SetBold().Font.FontColor = foreColor;

                Planilha.Row(4).Height = 25;
                Planilha.Row(4).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                Planilha.Row(4).Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                Planilha.Row(5).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                Planilha.Row(5).Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;


                Planilha.Cell("A4").Value = "PERÍODO";
                Planilha.Cell("c4").Value = "AGRUPAMENTO E ORDENAÇÃO";
                var rangeOutSideBorderA4B4 = Planilha.Range("A4:B4").Merge();
                rangeOutSideBorderA4B4.Style.Font.SetBold().Font.FontSize = 16;
                rangeOutSideBorderA4B4.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                var rangeOutSideBorderC4D4 = Planilha.Range("C4:D4").Merge();
                rangeOutSideBorderC4D4.Style.Font.SetBold().Font.FontSize = 16;
                rangeOutSideBorderC4D4.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;


                Planilha.Cell("A5").Value = "De [ " + filtros.periodoInicial.ToString() + " ] até [ " + filtros.periodoFinal.ToString() + " ]";
                var rangeOutSideBorderA5B5 = Planilha.Range("A5:B5").Merge();
                rangeOutSideBorderA5B5.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                if (filtros.agrupadoData)
                {
                    if (filtros.agrupadoHora)
                    {
                        Planilha.Cell("C5").Value = "Agrupado por [Data e Hora]";
                    }
                    else
                    {
                        Planilha.Cell("C5").Value = "Agrupado por [Data]";
                    }
                }
                else
                {
                    Planilha.Cell("C5").Value = "Não Agrupado";
                }

                if (filtros.data_vendedor)
                {
                    Planilha.Cell("D5").Value = "Ordenado por [Data]";
                }
                else
                {
                    Planilha.Cell("D5").Value = "Ordenado por [Vendedor]";
                }
                Planilha.Cell("C5").Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                Planilha.Cell("D5").Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                Planilha.Row(7).Height = 25;
                Planilha.Cell("A7").Value = "FILTRADO POR";
                var rangeOutSideBorderA7D7 = Planilha.Range("A7:D7").Merge();
                rangeOutSideBorderA7D7.Style.Font.SetBold().Font.FontSize = 16;
                rangeOutSideBorderA7D7.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                rangeOutSideBorderA7D7.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                rangeOutSideBorderA7D7.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                Planilha.Dispose();

                Planilha.Cell("A8").Value = "VENDEDORES";
                Planilha.Cell("B8").Value = "GRUPOS DE PRODUTO";
                Planilha.Cell("C8").Value = "PRODUTOS";
                Planilha.Cell("D8").Value = "DIAS DA SEMANA";
                var rangeOutSideBorderA8D8 = Planilha.Range("A8:D8");
                rangeOutSideBorderA8D8.Style.Font.SetBold();
                rangeOutSideBorderA8D8.Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                rangeOutSideBorderA8D8.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                rangeOutSideBorderA8D8.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                rangeOutSideBorderA8D8.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                rangeOutSideBorderA8D8.Style.Fill.BackgroundColor = backColor;
                rangeOutSideBorderA8D8.Style.Font.FontColor = foreColor;

                int count = 0;
                if (filtros.listaVendedores.Count > 0)
                {
                    count = 9;
                    foreach (var item in filtros.listaVendedores)
                    {
                        Planilha.Cell("A" + count.ToString()).Value = item.NomeVendedor;
                        Planilha.Cell("A" + count.ToString()).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        count++;
                    }
                }
                else
                {
                    Planilha.Cell("A9").Value = "Nenhum";
                    Planilha.Cell("A9").Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                }
                if (filtros.listaGrupos.Count > 0)
                {
                    count = 9;
                    foreach (var item in filtros.listaGrupos)
                    {
                        Planilha.Cell("B" + count.ToString()).Value = item.Descricao;
                        Planilha.Cell("B" + count.ToString()).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        count++;
                    }
                }
                else
                {
                    Planilha.Cell("B9").Value = "Nenhum";
                    Planilha.Cell("B9").Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                }
                if (filtros.listaProdutos.Count > 0)
                {
                    count = 9;
                    foreach (var item in filtros.listaProdutos)
                    {
                        Planilha.Cell("C" + count.ToString()).Value = item.descriproduto;
                        Planilha.Cell("C" + count.ToString()).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        count++;
                    }
                }
                else
                {
                    Planilha.Cell("C9").Value = "Nenhum";
                    Planilha.Cell("C9").Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                }
                if (filtros.listaDiaSemana.Count > 0)
                {
                    count = 9;
                    foreach (var item in filtros.listaDiaSemana)
                    {
                        Planilha.Cell("D" + count.ToString()).Value = item.NOME_DIASEMANA;
                        Planilha.Cell("D" + count.ToString()).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        count++;
                    }
                }
                else
                {
                    Planilha.Cell("D9").Value = "Nenhum";
                    Planilha.Cell("D9").Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
