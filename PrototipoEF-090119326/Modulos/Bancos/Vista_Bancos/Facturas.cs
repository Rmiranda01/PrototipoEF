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
    public partial class Facturas : Form
    {
        CsControlador cn = new CsControlador();
        string table = "registro_factura";

        public Facturas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void navegador1_Load(object sender, EventArgs e)
        {
          NavegadorVista.Navegador.idApp = "1";
            TextBox[] Grupotextbox = { txt_noFac,txt_producto,txt_cant,txt_pre,txt_nit };
            TextBox[] Idtextbox = { txt_noFac,txt_producto };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, Grupotextbox, "registro_factura");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.llenartablaa(dataGridView1.Tag.ToString(), dataGridView1);
        }

        private void navegador1_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_noFac.Text == "" || txt_producto.Text == "" || txt_cant.Text == "" || txt_pre.Text == "" || txt_nit.Text == "")
            {
                MessageBox.Show("COMPLETAR INFORMACION");
            }
            else
            {

                TextBox[] textbox = { txt_noFac, txt_producto, txt_cant, txt_pre, txt_nit};
                cn.ingresar(textbox, table);
                string message = "Registro Guardado";
                MessageBox.Show(message);
                cn.llenartablaa(dataGridView1.Tag.ToString(), dataGridView1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string message = "Deseas Eliminar el Registro?";
            string title = "Eliminar Registro";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                int campo = int.Parse(txt_noFac.Text);
                string condicion = "pk_no_fac = ";
                cn.eliminar(table, condicion, campo);
                cn.llenartablaa(dataGridView1.Tag.ToString(), dataGridView1);
                MessageBox.Show("Registro Eliminado");

            }
            else
            {
                cn.llenartablaa(dataGridView1.Tag.ToString(), dataGridView1);

            }
        }
    }
}
