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
        }

        private void TxtRe_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
