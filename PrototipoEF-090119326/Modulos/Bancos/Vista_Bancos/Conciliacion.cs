using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista_Bancos
{
    public partial class Conciliacion : Form
    {
        public Conciliacion()
        {
            InitializeComponent();
        }

        private void generarConciliacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte_Conciliacion conci = new Reporte_Conciliacion();
            conci.Show();
        }
    }
}
