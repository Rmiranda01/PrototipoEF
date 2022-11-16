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
    public partial class Eliminar : Form
    {
        csControlador cn = new csControlador();
        Prueba pb = new Prueba();
        public Eliminar()
        {
            InitializeComponent();
        }
        public int numero;
        private void Eliminar_Load(object sender, EventArgs e)
        {
            TextBox[] textbox = { textBox1, textBox2, textBox3, textBox4, textBox5 };
            cn.evaluartags(textbox, pb.dgv_tabla, "controlempleados", this);
            cn.llenartablaa(pb.dgv_tabla.Tag.ToString(), pb.dgv_tabla, numero, textbox);
            cn.desactivar(this);
            
            

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TextBox[] textbox = { textBox1, textBox2, textBox3, textBox4, textBox5 };
            cn.delete(textbox, pb.dgv_tabla);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
