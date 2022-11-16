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
    public partial class Cambio : Form
    {
        public Cambio()
        {
            InitializeComponent();
        }
        string table = "tbl_usuarios";
        Controlador cn = new Controlador();

        private void limpiar()
        {
            txtBusqueda.Text = "";
            txtcontraseña.Text = "";
        }



        private void button1_Click(object sender, EventArgs e)
        {
            TextBox[] textbox = { txtcontraseña };
            txtcontraseña.Text = Seguridad_Controlador.Controlador.SetHash(txtcontraseña.Text);
            string valor1 = txtBusqueda.Text;
            string campo = "username_usuario = ";
            cn.actualizarcontra(textbox, table, campo, valor1);
            cn.setBtitacora("1201", "Modifico Contraseña");
            limpiar();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                // TBcontraseña.PasswordChar = '*';
                txtcontraseña.PasswordChar = '\0';
            }
            else
                       if (txtcontraseña.Text != "")
            {
                // TBcontraseña.PasswordChar = '\0';
                txtcontraseña.PasswordChar = '*';
            }
        }
    }
}
