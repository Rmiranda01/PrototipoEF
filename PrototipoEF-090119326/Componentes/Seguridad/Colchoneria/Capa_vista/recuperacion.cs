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
    public partial class recuperacion : Form
    {
        public recuperacion()
        {
            InitializeComponent();
        }

        Controlador cn = new Controlador();

        public void autenticar()
        {

            if (cn.validarRecuperacion(TBusuario.Text, Controlador.SetHash(TxtRe.Text)))
            {
                Controlador.Username = Controlador.SetHash(TBusuario.Text);
                //cn.setBtitacora("0001", "login");
                //cn.setBtitacora("8000", "Recuperacion Contraseña");
                Cambio b = new Cambio();
                b.MdiParent = this;
                b.Show();
                groupBox1.Visible = false;
            } else
            {
                MessageBox.Show("No conciden los datos");
            }
        }

        public string llenap()
        {
            return cn.llenarPregunta(TBusuario.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            autenticar();
            
        }

        private void recuperacion_Load(object sender, EventArgs e)
        {

        }

        private void TBusuario_Leave(object sender, EventArgs e)
        {
            string res;
            res = llenap();
            TxtPa.Text = res;
        }

        private void TxtRe_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
