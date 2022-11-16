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
    public partial class AsignacionModuloAplicacion : Form
    {
        Controlador cn = new Controlador();
        string table = "tbl_asignacionmoduloaplicacion";
        public AsignacionModuloAplicacion()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            txtCadenas.Text = "";
            txtIdAplicacion.Text = "";
            txtIdModulo.Text = "";
        }

        public void ocultar()
        {
            txtIdAplicacion.Visible = false;
        }

        public void getIds()
        {
            try
            {
                string dato;
                dato = listAplicacionesDB.CurrentCell.Value.ToString();
                if (txtCadenas.Text == "")
                {
                    txtCadenas.Text = dato;
                }
                else
                {
                    string valor = txtCadenas.Text;
                    txtCadenas.Text = valor + "," + dato;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtener las aplicaciones del perfil");
            }
        }

        public void getId()
        {
            try
            {
                string dato;
                dato = ListModulo.CurrentCell.Value.ToString();
                txtIdModulo.Text = dato;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtener las aplicaciones del perfil");
            }
        }

        public void actualizardatagriew()
        {
            string id = txtIdModulo.Text; 
            cn.llenarListApliUsuariosstring(listAplicacionPerfil.Tag.ToString(), listAplicacionPerfil, id);
        }

        private void AsignacionModuloAplicacion_Load(object sender, EventArgs e)
        {
            cn.llenarListAplicaciones(listAplicacionesDB.Tag.ToString(), listAplicacionesDB);
            cn.llenarListModulo(ListModulo.Tag.ToString(), ListModulo);
            Size = new Size(593, 379);
            ocultar();
        }

        private void listAplicacionesDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getIds();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            char[] delimiterChars = { ',' };
            string text = txtCadenas.Text;
            string[] words = text.Split(delimiterChars);

            foreach (var word in words)
            {
                txtIdAplicacion.Text = word;
                TextBox[] textbox = { txtIdModulo, txtIdAplicacion };
                cn.ingresar(textbox, table);
            }
            string message = "Registro Guardado";

            actualizardatagriew();
            limpiar();
            MessageBox.Show(message);
            cn.setBtitacora("1101", "Asigno Modulo-Aplicacion");
            //593; 379
            Size = new Size(593, 379);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListModulo.Visible = false;
            /*958; 379*/
            if (listAplicacionesDB.Visible == false)
            {
                listAplicacionesDB.Visible = true;
                Size = new Size(958, 379);
            }
            else
            {
                //623; 455
                listAplicacionesDB.Visible = false;
                Size = new Size(593, 379);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listAplicacionesDB.Visible = false;
            /*958; 379*/
            if (ListModulo.Visible == false)
            {
                ListModulo.Visible = true;
                Size = new Size(958, 379);
            }
            else
            {
                //623; 455
                ListModulo.Visible = false;
                Size = new Size(593, 379);
            }
        }

        private void ListModulo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getId();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtIdModulo.Text;
            if(texto == "")
            {
                string message = "Debe Ingresar un ID Modulo";
                MessageBox.Show(message);
            }
            else
            {
                actualizardatagriew();
                limpiar();
            }
            
        }

        private void listAplicacionPerfil_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string message = "Deseas Eliminar el Registro?";
            string title = "Eliminar Registro";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                String dato1 = listAplicacionPerfil.CurrentRow.Cells[0].Value.ToString();
                String dato2 = listAplicacionPerfil.CurrentRow.Cells[2].Value.ToString();

                /*string message2= "Debe "+ dato1 + " "+ dato2 + "";
                MessageBox.Show(message2);*/
                int campo1 = int.Parse(dato1);
                string condicion1 = txtIdModulo.Tag.ToString();
                int campo2 = int.Parse(dato2);
                string condicion2 = txtIdAplicacion.Tag.ToString();
                cn.eliminarAsiganaciones(table, condicion1, campo1, condicion2, campo2);
                cn.setBtitacora("1101", "Elimino Modulo-Aplicacion");
                listAplicacionPerfil.Columns.Clear();
            }
            else
            {
                limpiar();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AyudaAsignacionModuloAplicacion b = new AyudaAsignacionModuloAplicacion();
            b.Show();
        }
    }
}
