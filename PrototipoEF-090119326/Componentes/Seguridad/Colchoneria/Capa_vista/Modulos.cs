using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seguridad_Controlador;

namespace Vista_Seguridad
{
    public partial class Modulos : Form
    {
        string table = "tbl_modulos";

        Controlador cn = new Controlador();

        public Modulos()
        {
            InitializeComponent();
        }
        
        public void Limpiar()
        {
            txtBuscar.Text = "";
            txtDescripcion.Text = "";
            txtIdModulo.Text = "";
            txtNombre.Text = "";
        }

        public void checkbox()
        {
            if (checkBox1.Checked)
            {
                txtact.Text = "1";
            }
            else
            {
                txtact.Text = "0";
            }
        }



        private void button8_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (txtIdModulo.Text == "" || txtDescripcion.Text == "" || txtNombre.Text == "")
            {
                MessageBox.Show("COMPLETAR INFORMACION");
            }
            else
            {
                checkbox();
                TextBox[] textbox = { txtIdModulo, txtDescripcion, txtNombre, txtact };
                cn.ingresar(textbox, table);
                cn.setBtitacora("1003", "Creo Modulo");
                string message = "Registro Guardado";
                Limpiar();
                MessageBox.Show(message);
                //actualizardatagriew();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            TextBox[] textbox = { txtBuscar, txtDescripcion, txtIdModulo, txtNombre };
            int valor1 = int.Parse(txtBuscar.Text);
            string campo = "idModulo = ";
            //string num = txtBusqueda.Tag.ToString();
            cn.buscar(textbox, table, valor1, campo);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtIdModulo.Text == "" || txtDescripcion.Text == "" || txtNombre.Text == "")
            {
                MessageBox.Show("COMPLETAR INFORMACION");
            }
            else
            {
                checkbox();
                TextBox[] textbox = { txtBuscar, txtDescripcion, txtNombre, txtact };
                int valor1 = int.Parse(txtBuscar.Text);
                string campo = "pk_id_modulos = ";
                cn.actualizar(textbox, table, campo, valor1);
                cn.setBtitacora("1003", "Modifico Modulo");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string message = "Deseas Eliminar el Registro?";
            string title = "Eliminar Registro";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                int campo = int.Parse(txtBuscar.Text);
                string condicion = "pk_id_modulos = ";
                cn.eliminar(table, condicion, campo);
                cn.setBtitacora("1003", "Elimino Modulo");
                //this.Close();
            }
            else
            {
                Limpiar();
                //this.Close();
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            AyudaModulo b = new AyudaModulo();
            b.Show();
        }
    }
}
