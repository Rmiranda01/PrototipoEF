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
    public partial class Ventas : Form
    {
        CsControlador cn = new CsControlador();
        string table = "ventas_encabezado";
        public Ventas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "Deseas Eliminar el Registro?";
            string title = "Eliminar Registro";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                int campo = int.Parse(txtnumven.Text);
                string condicion = "documento_ventaenca = ";
                cn.eliminar(table, condicion, campo);
                cn.llenartablaa(dataGridView1.Tag.ToString(), dataGridView1);
                MessageBox.Show("Registro Eliminado");

            }
            else
            {
                cn.llenartablaa(dataGridView1.Tag.ToString(), dataGridView1);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtnumven.Text == "" || txtcodcli.Text == "" || txtfech.Text == "" || txttotal.Text == "" || txtestatus.Text == "")
            {
                MessageBox.Show("COMPLETAR INFORMACION");
            }
            else
            {

                TextBox[] textbox = { txtnumven, txtcodcli, txtfech, txttotal, txtestatus};
                cn.ingresar(textbox, table);
                string message = "Registro Guardado";
                MessageBox.Show(message);
                cn.llenartablaa(dataGridView1.Tag.ToString(), dataGridView1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cn.llenartablaa(dataGridView1.Tag.ToString(), dataGridView1);
        }
    }
}
