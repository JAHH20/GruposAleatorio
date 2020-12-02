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

        /// <summary>Cargar cada control del formulario "botones, textbox,labe, listbox"  <see cref="frmResultado" /> class.</summary>
        public frmResultado()
        {
            InitializeComponent();
        }

        /// <summary>boton btnSalir_Click cierra el formulario .</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnSalir_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void frmResultado_Load(object sender, EventArgs e)
        {

        }

        /// <summary>boton button1_Click para expotar al excel .</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();

            xla.Visible = true;

            Microsoft.Office.Interop.Excel.Workbook wb = xla.Workbooks.Add(Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet);

            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)xla.ActiveSheet;


           

            int i = 1;

            int j = 1;
            int cantgrupos = 0;
           //bucle que genera los encabezados de cada grupo.
            foreach (ListViewGroup  group in listView1.Groups)

            {
                
                ws.Cells[i, j] = group.Header.ToString();
                //**********
           


                i++;
                //bucle que genere los integrantes a su grupo respectivo.
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
            //constructor de numero a excel.
            numeroExcel numero = new numeroExcel();
            //para autoajustar la columna al ancho del contenido.
            //para que el encabezado tenga estilo negrita
            //para el color de la celda sea Silver
            ws.Columns.AutoFit();
            ws.Range["A1:"+numero.GetExcelColumnName(cantgrupos)+"1"].Font.Bold = true;
            ws.Range["A1:" + numero.GetExcelColumnName(cantgrupos) + "1"].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Silver);

        }
    }
}
