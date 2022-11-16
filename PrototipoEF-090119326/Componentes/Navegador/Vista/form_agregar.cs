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
using FontAwesome.Sharp;


namespace Vista
{
    public partial class form_agregar : Form
    {
        csControlador cn = new csControlador();
        navegador nv = new navegador();
        public form_agregar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
          
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            TextBox[] textbox = { textBox1, textBox2, textBox3, textBox4, textBox5 };
            cn.ingresar(textbox, nv.dgv_tabla);
            this.Close();
            
            
        }

        private void form_agregar_Load(object sender, EventArgs e)
        {
            cn.limpiar(this);
            cn.activar(this);
            TextBox[] textbox = { textBox1, textBox2 };
            cn.crearid(textbox, nv.dgv_tabla);
        }
    }
}
