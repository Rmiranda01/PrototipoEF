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
    public partial class Login : Form
    {

        //string tab = "usuario";
      //  string da1 = "usuario";
        //string da2 = "contra";
        Controlador cn = new Controlador();
        // prueba pr = new prueba();
        //prueba b = new prueba();

        public Login()
        {
            InitializeComponent();
        }

        



        public void login()
        {
            if (cn.validarLogin(TBusuario.Text,TBcontrasena.Text))
            {
               // Controlador.Username = Controlador.SetHash(TBusuario.Text);

                
                Menup b = new Menup();
                cn.setBtitacora("1", "IngLogin");
                b.Show();
                this.Hide();

                /* if (cn.getAccesoModulos(1000))
                 {

                     cn.setBtitacora("1000", "Seguridad");
                 };
                  if (cn.getAccesoModulos(2000))
                 {

                     cn.setBtitacora("2000", "Logistica");
                 };
                 if (cn.getAccesoModulos(3000))
                 {

                     cn.setBtitacora("3000", "Compra y Venta");
                 };
                 if (cn.getAccesoModulos(5000))
                 {

                     cn.setBtitacora("5000", "Produccion");
                 };
                 if (cn.getAccesoModulos(6000))
                 {

                     cn.setBtitacora("6000", "Nominas");
                 };
                 if (cn.getAccesoModulos(7000))
                 {

                     cn.setBtitacora("7000", "Bancos");
                 };
                 if (cn.getAccesoModulos(8000))
                 {

                     cn.setBtitacora("8000", "Contabilidad");
                 };*/
            }
            else
            {
                MessageBox.Show("Contraseña o Usuario Incorrecta");
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            login();  
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

        private void button2_Click(object sender, EventArgs e)
        {
            recuperacion b = new recuperacion();
            b.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
