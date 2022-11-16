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
    public partial class Perfiles : Form
    {

        string table = "tbl_perfiles";
        Controlador cn = new Controlador();

        public Perfiles()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            txtbuscar.Text = "";
            txtdescripcion.Text = "";
            txtestado.Text = "";
            txtnombre.Text = "";
        }

        public void checkbox()
        {
            if (checkBox1.Checked)
            {
                txtestado.Text = "1";
            }
            else
            {
                txtestado.Text = "0";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e) //Boton Nuevo
        {
            limpiar();
        }

        private void button3_Click(object sender, EventArgs e) //Boton Ingresar
        {
            if (txtdescripcion.Text == "" || txtnombre.Text == "")
            {
                MessageBox.Show("COMPLETAR INFORMACION");
            }
            else
            {
                checkbox();
                TextBox[] textbox = { txtdescripcion, txtestado, txtnombre };
                cn.ingresar(textbox, table);
                cn.setBtitacora("1004", "Crea un perfil");
                string message = "Registro Guardado";
                limpiar();
                MessageBox.Show(message);
            }

        }

        private void Perfiles_Load(object sender, EventArgs e)
        {
            txtestado.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e) //Boton Actualizar
        {
            if (txtdescripcion.Text == "" || txtnombre.Text == "")
            {
                MessageBox.Show("COMPLETAR INFORMACION");
            }
            else
            {
                checkbox();
                TextBox[] textbox = { txtdescripcion, txtestado, txtnombre };
                int valor1 = int.Parse(txtbuscar.Text);
                string campo = "pk_id_perfil = ";
                cn.actualizar(textbox, table, campo, valor1);
                cn.setBtitacora("1004", "Modifico un perfil");
                string message2 = "Registro actualizado";
                limpiar();
                MessageBox.Show(message2);
            }
        }

        private void button7_Click(object sender, EventArgs e) //Boton Eliminar
        {
            string message = "Deseas Eliminar el Registro?";
            string title = "Eliminar Registro";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                int campo = int.Parse(txtbuscar.Text);
                string condicion = "pk_id_perfil = ";
                cn.eliminar(table, condicion, campo);
                cn.setBtitacora("1004", "Elimino un perfil");
                string message1 = "Registro eliminado";
                limpiar();
                MessageBox.Show(message1);
            }
            else
            {
                limpiar();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AyudaPerfiles b = new AyudaPerfiles();
            b.Show();
        }
    }
}
