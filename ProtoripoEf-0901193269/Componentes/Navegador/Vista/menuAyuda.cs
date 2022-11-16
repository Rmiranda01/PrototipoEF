using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class menuAyuda : Form
    {
        public menuAyuda()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            pnl_agregar.Visible = true;
            pnl_modificar.Visible = false;
            pnl_flechas.Visible = false;
            pnl_preguntas.Visible = false;
            pnl_actualizar.Visible = false;
            pnl_eliminar.Visible = false;
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            pnl_agregar.Visible = false;
            pnl_modificar.Visible = true;
            pnl_flechas.Visible = false;
            pnl_preguntas.Visible = false;
            pnl_actualizar.Visible = false;
            pnl_eliminar.Visible = false;
        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void btn_flechas_Click(object sender, EventArgs e)
        {
            pnl_agregar.Visible = false;
            pnl_modificar.Visible = false;
            pnl_flechas.Visible = true;
            pnl_preguntas.Visible = false;
            pnl_actualizar.Visible = false;
            pnl_eliminar.Visible = false;
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            pnl_agregar.Visible = false;
            pnl_modificar.Visible = false;
            pnl_flechas.Visible = false;
            pnl_preguntas.Visible = false;
            pnl_actualizar.Visible = true;
            pnl_eliminar.Visible = false;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            pnl_agregar.Visible = false;
            pnl_modificar.Visible = false;
            pnl_flechas.Visible = false;
            pnl_preguntas.Visible = false;
            pnl_actualizar.Visible = false;
            pnl_eliminar.Visible = true;
        }

        private void btn_preguntas_Click(object sender, EventArgs e)
        {
            pnl_agregar.Visible = false;
            pnl_modificar.Visible = false;
            pnl_flechas.Visible = false;
            pnl_preguntas.Visible = true;
            pnl_actualizar.Visible = false;
            pnl_eliminar.Visible = false;
        }
    }
}
