using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seguridad_Controlador;


namespace Vista_Seguridad
{
    public partial class ListAplicaciones : Form
    {

        Controlador cn = new Controlador();
        string res;
        public ListAplicaciones()
        {
            InitializeComponent();
        }

        private void ListAplicaciones_Load(object sender, EventArgs e)
        {
            cn.llenarListAplicaciones(listAplicacionesDB.Tag.ToString(), listAplicacionesDB);
            //desabilitar();
        }

        public string getIds()
        {
            try
            {
                string dato;
                dato = listAplicacionesDB.CurrentCell.Value.ToString();
                //MessageBox.Show("Valor optenido es :  " + dato);
                //MessageBox.Show("Valor optenido es :  " + txtIds.Text);
                if (txtIds.Text == "")
                {
                    txtIds.Text = dato;
                }
                else
                {
                    string valor = txtIds.Text;
                    res = valor + "," + dato;
                    txtIds.Text = res;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtener las aplicaciones del perfil");
            }
            return res;
        }

        public string muestraIds()
        {
            string info = txtIds.Text;
            MessageBox.Show("Valor optenido es :  " + info);
            return info;
        }


        private void listAplicacionesDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getIds();
            //muestraIds();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*AsignacionAplicacion b = new AsignacionAplicacion();
            MessageBox.Show("Valor optenido es :  " + txtIds.Text);
            this.Hide();*/
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            muestraIds();
        }
    }
}
