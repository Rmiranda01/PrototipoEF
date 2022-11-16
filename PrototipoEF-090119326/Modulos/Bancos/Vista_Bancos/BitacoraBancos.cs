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
    public partial class BitacoraBancos : Form
    {
        CsControlador cn = new CsControlador();
        public BitacoraBancos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.bitacora(dataGridView1.Tag.ToString(), dataGridView1);
        }
    }
}
