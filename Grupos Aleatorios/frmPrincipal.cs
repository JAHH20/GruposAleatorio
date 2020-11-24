
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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAgregarParticipante_Click(object sender, EventArgs e)
        {
            String participante;

            participante = textBox1.Text;

            if (textBox1.TextLength == 0)
            {
                MessageBox.Show("Ingrese un participante.", "Aviso");
            }
            else
            {
                listBox1.Items.Add(participante);
                textBox1.Text = "";
                textBox1.Focus();
            }

        }

      

        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            while (listBox1.SelectedItems.Count > 0)
            {
                listBox1.Items.Remove(listBox1.SelectedItems[0]);
            }
           
        }

        private void btnGenerarGrupos_Click(object sender, EventArgs e)
        {
            
            // Get the names into an array.
            int num_people = listBox1.Items.Count;
            string[] names = new string[num_people];
            listBox1.Items.CopyTo(names, 0);
            
            // Randomize.
            Randomizer.Randomize(names);

            frmResultado Resultado = new frmResultado();
            // Divide the names into groups.
            int num_groups = int.Parse(txtGruposCantidad.Text);
         
         
            int a = 1;
            int i = 0;
            float limite= num_people / num_groups; ;
         

            do {

                ListViewGroup grupos = new ListViewGroup("Grupo N°" + a + ": ", HorizontalAlignment.Left);
                for (double b = 0; b < limite; b++)
                {
                                  
                
                        Resultado.listView1.Items.Add(new ListViewItem(names[i], grupos));

                    i++;
                }
             
                Resultado.listView1.Groups.Add(grupos);
                a++;
                if (num_people % num_groups != 0 && a == num_groups)
                {

                    limite = limite + 1;

                }

            } while (a <= num_groups);

               
            Resultado.ShowDialog();

        }

        

        

     
        private void CheckEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnAgregarParticipante_Click(sender, e);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnAgregarParticipante_Click(sender, e);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int count = listBox1.Items.Count;
            if (Clipboard.ContainsText(TextDataFormat.Text))
            {
                string[] clipboardText = Clipboard.GetText(TextDataFormat.Text).Split(Environment.NewLine.ToCharArray());
                foreach (string clipboard in clipboardText)
                {
                    listBox1.Items.Add(clipboard.Trim());
                    if (clipboard.ToString().Length == 0)
                    {
                       listBox1.Items.Remove(clipboard);
                    }
                            

                }
                               
            }
        }
    }
}
