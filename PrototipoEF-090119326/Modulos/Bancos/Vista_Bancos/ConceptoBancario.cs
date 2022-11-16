using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista_Bancos
{
   
    public partial class ConceptoBancario : Form
    {
        int indice,indice2;
        public ConceptoBancario()
        {
            InitializeComponent();
        }

        private void ConceptoBancario_Load(object sender, EventArgs e)
        {
            textBox4.Enabled = false;
            textBox5.Enabled = false;
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "7004";
            TextBox[] Grupotextbox = { textBox1,textBox2,textBox3,textBox4,textBox5};
            TextBox[] Idtextbox = { textBox1, textBox2 };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, Grupotextbox, "Tbl_ConceptosBancario");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            indice = comboBox1.SelectedIndex;
            switch (indice) 
            {
                case 0:
                    textBox4.Text = "Cargo";
                    break;
                case 1:
                    textBox4.Text = "Abono";
                    break;
            }


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            indice2 = comboBox2.SelectedIndex;
            switch (indice2)
            {
                case 0:
                    textBox5.Text = "0";
                    break;
                case 1:
                    textBox5.Text = "1";
                    break;
            }
        }
    }
}
