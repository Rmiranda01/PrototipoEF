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
    public partial class Clientes : Form
    {
        CsControlador cn = new CsControlador();
        string table = "clientes";
        public Clientes()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_codclie.Text == "" || txt_nombrecli.Text == "" || txt_direcli.Text == "" || txt_nitcli.Text == "" || txt_telcli.Text == "" || txt_codven.Text == "" || txt_estatuscli.Text == "")
            {
                MessageBox.Show("COMPLETAR INFORMACION");
            }
            else
            {

                TextBox[] textbox = { txt_codclie, txt_nombrecli, txt_direcli, txt_nitcli, txt_telcli, txt_codven,txt_estatuscli};
                cn.ingresar(textbox, table);
                string message = "Registro Guardado";
                MessageBox.Show(message);
                cn.llenartablaa(dataGridView1.Tag.ToString(), dataGridView1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "Deseas Eliminar el Registro?";
            string title = "Eliminar Registro";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                int campo = int.Parse(txt_codclie.Text);
                string condicion = "codigo_cliente = ";
                cn.eliminar(table, condicion, campo);
                cn.llenartablaa(dataGridView1.Tag.ToString(), dataGridView1);
                MessageBox.Show("Registro Eliminado");

            }
            else
            {
                cn.llenartablaa(dataGridView1.Tag.ToString(), dataGridView1);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cn.llenartablaa(dataGridView1.Tag.ToString(), dataGridView1);
        }
    }
}
