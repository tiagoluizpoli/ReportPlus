using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text.pdf;
using iTextSharp;
using System.Windows.Forms;
using System.Drawing.Text;

namespace ReportPlus.Tools.Export
{
    public class PdfExport
    {

        private void fontTest()
        {
            byte[] fontData = Properties.Resources.Roboto_Regular;

        }
        public void ExportGridToPdf(DataGridView dgw, string path)
        {
            //BaseFont bf = BaseFont.CreateFont(Properties.Resources.Roboto_Regular);
        }
    }
}
