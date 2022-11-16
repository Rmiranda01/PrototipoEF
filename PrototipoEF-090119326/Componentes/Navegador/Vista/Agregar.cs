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
    
    public partial class Agregar : Form
    {
        csControlador cn = new csControlador();
        Prueba pb = new Prueba();
        public Agregar()
        {
            InitializeComponent();
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            TextBox[] textbox = { textBox1, textBox2, textBox3, textBox4, textBox5 };
            cn.evaluartags(textbox, pb.dgv_tabla, "controlempleados", this);
            cn.llenartxt(textbox, pb.dgv_tabla);

            TextBox[] textbox2 = { textBox1, textBox2 };
            cn.crearid(textbox2, pb.dgv_tabla);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TextBox[] textbox = { textBox1, textBox2, textBox3, textBox4, textBox5 };
            
                cn.ingresar(textbox, pb.dgv_tabla);


            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
