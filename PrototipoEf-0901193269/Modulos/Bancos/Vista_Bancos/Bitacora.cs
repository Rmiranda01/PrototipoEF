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
    public partial class Bitacora : Form
    {
        CsControlador cn = new CsControlador();
        public Bitacora()
        {
            InitializeComponent();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            cn.filtrobitacora(dataGridView1.Tag.ToString(), dataGridView1);
        }
    }
}
