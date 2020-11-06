using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupos_Aleatorios
{
    public partial class Form1 : Form
    {
        public Form1()
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
    }
}
