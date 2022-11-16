using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;

namespace Vista
{
    public partial class Prueba : Form
    {
        csControlador cn = new csControlador();
        public Prueba()
        {
            InitializeComponent();
        }
        
        private void btnInsert_Click(object sender, EventArgs e)
        {
            Agregar ag = new Agregar();
            ag.Show();
        }

        private void Prueba_Load(object sender, EventArgs e)
        {
            cn.llenartablaa(dgv_tabla.Tag.ToString(), dgv_tabla);


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
             
            
            Modificar mo = new Modificar();
            mo.numero = cn.buscarposicion(dgv_tabla);
            mo.Show();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Eliminar el = new Eliminar();
            el.numero = cn.buscarposicion(dgv_tabla);
            el.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            cn.moverseIF(dgv_tabla, "i");
            cn.llenartablaa(dgv_tabla.Tag.ToString(), dgv_tabla);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            cn.moverseIF( dgv_tabla, "i");
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            cn.moverseIF(dgv_tabla, "f");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            cn.moverseIF(dgv_tabla, "b");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            cn.moverseIF(dgv_tabla, "s");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
