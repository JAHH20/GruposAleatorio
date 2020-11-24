using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GruposAleatoriosLibreria;

namespace Grupos_Aleatorios
{
    public partial class frmResultado : Form
    {

        public frmResultado()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void frmResultado_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();

            xla.Visible = true;

            Microsoft.Office.Interop.Excel.Workbook wb = xla.Workbooks.Add(Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet);

            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)xla.ActiveSheet;


           

            int i = 1;

            int j = 1;
            int cantgrupos = 0;
           
            foreach (ListViewGroup  group in listView1.Groups)

            {
                
                ws.Cells[i, j] = group.Header.ToString();
                //**********
           


                i++;
                //***********
                foreach (ListViewItem comp in listView1.Groups[cantgrupos].Items)

                {

                    ws.Cells[i, j] = comp.Text.ToString();

                    //MessageBox.Show(comp.Text.ToString());



                    i++;
                }

                cantgrupos++;
                j++;
                i = 1;
            }

            numeroExcel numero = new numeroExcel();

            ws.Columns.AutoFit();
            ws.Range["A1:"+numero.GetExcelColumnName(cantgrupos)+"1"].Font.Bold = true;
            ws.Range["A1:" + numero.GetExcelColumnName(cantgrupos) + "1"].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Silver);

        }
    }
}
