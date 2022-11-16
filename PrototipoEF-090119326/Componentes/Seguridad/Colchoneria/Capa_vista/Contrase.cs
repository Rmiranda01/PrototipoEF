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
    public partial class Contrase : Form
    {
        public Contrase()
        {
            InitializeComponent();
        }

        Controlador cn = new Controlador();


        public void autenticar()
        {
            if (cn.validarLogin(TBusuario.Text, Controlador.SetHash(TBcontrasena.Text)))
            {
                Controlador.Username = Controlador.SetHash(TBusuario.Text);
                //cn.setBtitacora("0001", "login");
                Cambio b = new Cambio();
                b.MdiParent = this;
                b.Show();
                groupBox1.Visible = false;
            } else
            {
                MessageBox.Show("NO CONCIDEN LOS DATOS");
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            autenticar();
            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                // TBcontraseña.PasswordChar = '*';
                TBcontrasena.PasswordChar = '\0';
            }
            else
                       if (TBcontrasena.Text != "")
            {
                // TBcontraseña.PasswordChar = '\0';
                TBcontrasena.PasswordChar = '*';
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            AyudaContraseña b = new AyudaContraseña();
            b.Show();
        }
    }
}
