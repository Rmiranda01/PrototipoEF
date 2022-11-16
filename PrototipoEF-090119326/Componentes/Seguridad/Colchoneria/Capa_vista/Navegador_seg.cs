using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista_Seguridad
{
    public partial class Navegador_seg : Form
    {
        public Navegador_seg()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario b = new Usuario();
            b.MdiParent = this;
            b.Show();
        }

        private void aplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aplicacion b = new Aplicacion();
            b.MdiParent = this;
            b.Show();
        }

        private void perfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Perfiles b = new Perfiles();
            b.MdiParent = this;
            b.Show();
        }

        private void módulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modulos b = new Modulos();
            b.MdiParent = this;
            b.Show();
        }

        private void asignacionesDeAplicacionesAUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsignacionAplicacion b = new AsignacionAplicacion();
            b.MdiParent = this;
            b.Show();
        }

        private void asignaciónDePerfilesAUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsignacionPerfiles b = new AsignacionPerfiles();
            b.MdiParent = this;
            b.Show();
        }

        private void asignaciónDeAplicacionesAPerfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsignacionAplicacionesPerfiles b = new AsignacionAplicacionesPerfiles();
            b.MdiParent = this;
            b.Show();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contrase b = new Contrase();
         
            b.Show();
        }

        private void bitacoraIngresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitacora b = new Bitacora();
            b.MdiParent = this;
            b.Show();
        }

        private void bITACORAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void asignacionDeModuloAAplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsignacionModuloAplicacion b = new AsignacionModuloAplicacion();
            b.MdiParent = this;
            b.Show();
        }

        private void mANTENIMIENTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
