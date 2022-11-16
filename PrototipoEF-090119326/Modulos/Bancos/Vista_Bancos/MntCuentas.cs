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
    public partial class MntCuentas : Form
    {
        CsControlador cn = new CsControlador();
        public MntCuentas()
        {
            InitializeComponent();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "7002";
            TextBox[] Grupotextbox = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8 };
            TextBox[] Idtextbox = { textBox1, textBox2 };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, Grupotextbox, "tbl_ctabancarias");
        }

        private void checkBox1_ClientSizeChanged(object sender, EventArgs e)
        {
          
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            monedapanel.Visible = true;
            cn.llenartablaa(dataGridView2.Tag.ToString(), dataGridView2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bancospanel.Visible = true;
            cn.llenartablaa(dataGridView3.Tag.ToString(), dataGridView3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            miembrospanel.Visible = true;
            cn.llenartablaa(dataGridView4.Tag.ToString(), dataGridView4);
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox7.Text = dataGridView4.CurrentRow.Cells[0].Value.ToString();
            textBox12.Text = dataGridView4.CurrentRow.Cells[1].Value.ToString();
            miembrospanel.Visible = false;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox4.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBox9.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            monedapanel.Visible = false;
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox5.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            textBox10.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            bancospanel.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox8.Text = "1";
            }
            if (checkBox1.Checked == false)
            {
                textBox8.Text = "0";
            }
        }
    }
}
