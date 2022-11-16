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
    public partial class Disponibilidad : Form
    {
        CsControlador cn = new CsControlador();
        public Disponibilidad()
        {
            InitializeComponent();
        }

        private void btndisponibilidad_Click(object sender, EventArgs e)
        {
            cn.disponibilidad(dataGridView1.Tag.ToString(), dataGridView1);
        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
            ReporteDisponibilidad frm_dispo = new ReporteDisponibilidad();
            frm_dispo.Show();
        }
    }
}