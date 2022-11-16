using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador_Bancos;
namespace Vista_Bancos
{
    public partial class MovBancos : Form
    {
        CsControlador cn = new CsControlador();
        public MovBancos()
        {
            InitializeComponent();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "7002";
            TextBox[] Grupotextbox = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7 };
            TextBox[] Idtextbox = { textBox1, textBox2 };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, Grupotextbox, "Tbl_Movimientos_bancos");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelpago.Visible = true;
            cn.llenartablaa(dataGridView2.Tag.ToString(), dataGridView2);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txtPago.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            panelpago.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelconcepto.Visible = true;
            cn.llenartablaa(dataGridView3.Tag.ToString(), dataGridView3);
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            txtconcepto.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            panelconcepto.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pncbanco.Visible = true;
            cn.llenartablaa(dataGridView4.Tag.ToString(), dataGridView4);
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox5.Text = dataGridView4.CurrentRow.Cells[0].Value.ToString();
            txtcuenta.Text = dataGridView4.CurrentRow.Cells[1].Value.ToString();
            pncbanco.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pncuentabancaria.Visible = true;
            cn.llenartablaa(dataGridView5.Tag.ToString(), dataGridView5);
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox6.Text = dataGridView5.CurrentRow.Cells[0].Value.ToString();
            txtCbancaria.Text = dataGridView5.CurrentRow.Cells[1].Value.ToString();
            pncuentabancaria.Visible = false;
        }
    }
}
