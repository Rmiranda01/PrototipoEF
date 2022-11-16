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
    public partial class AsignacionPerfiles : Form
    {
        string table = "tbl_asignacionesperfilsusuario";

        Controlador cn = new Controlador();

        public AsignacionPerfiles()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            txtCadenas.Text = "";
            txtIdUsuario.Text = "";
            txtIdPerfil.Text = "";
        }

        public void ocultar()
        {
            txtIdPerfil.Visible = false;
        }

        public void getIds()
        {
            try
            {
                string dato;
                dato = listPerfilesDB.CurrentCell.Value.ToString();
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
                dato = ListUsuario.CurrentCell.Value.ToString();
                txtIdUsuario.Text = dato;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtener las aplicaciones del perfil");
            }
        }

        public void actualizardatagriew()
        {
            string id = txtIdUsuario.Text;
            cn.llenarListApliUsuariosstring(listPerfilUsuario.Tag.ToString(), listPerfilUsuario, id);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {

            char[] delimiterChars = { ',' };
            string text = txtCadenas.Text;
            string[] words = text.Split(delimiterChars);

            foreach (var word in words)
            {
                txtIdPerfil.Text = word;
                TextBox[] textbox = { txtIdPerfil, txtIdUsuario };
                cn.ingresar(textbox, table);
            }
            string message = "Registro Guardado";
            actualizardatagriew();
            limpiar();
            MessageBox.Show(message);
            cn.setBtitacora("1103", "Asigno Perfil-Aplicacion");
            listPerfilesDB.Visible = false;
            //663; 369
            Size = new Size(663, 369);
        }

        private void AsignacionPerfiles_Load(object sender, EventArgs e)
        {
            cn.llenarListPerfiles(listPerfilesDB.Tag.ToString(), listPerfilesDB);
            cn.llenarListUsuarios(ListUsuario.Tag.ToString(), ListUsuario);
            Size = new Size(663, 369);
            ocultar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string texto = txtIdUsuario.Text;
            if (texto == "")
            {
                string message = "Debe Ingresar un ID Usuario";
                MessageBox.Show(message);
            }
            else
            {
                actualizardatagriew();
                limpiar();
            }
            
           
        }

        private void listAplicacionesDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getIds();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListUsuario.Visible = false;
            //1040; 369
            if (listPerfilesDB.Visible == false)
            {
                listPerfilesDB.Visible = true;
                Size = new Size(1040, 369);
            }
            else
            {
                listPerfilesDB.Visible = false;
                Size = new Size(663, 369);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listPerfilesDB.Visible = false;
                //1040; 369
            if (ListUsuario.Visible == false)
            {
                ListUsuario.Visible = true;
                Size = new Size(1040, 369);
            }
            else
            {
                ListUsuario.Visible = false;
                Size = new Size(663, 369);
            }
        }

        private void ListUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getId();
        }

        private void listPerfilUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string message = "Deseas Eliminar el Registro?";
            string title = "Eliminar Registro";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                String dato1 = listPerfilUsuario.CurrentRow.Cells[0].Value.ToString();
                String dato2 = listPerfilUsuario.CurrentRow.Cells[3].Value.ToString();
                int campo1 = int.Parse(dato1);
                string condicion1 = txtIdUsuario.Tag.ToString();
                int campo2 = int.Parse(dato2);
                string condicion2 = txtIdPerfil.Tag.ToString();
                cn.eliminarAsiganaciones(table, condicion1, campo1, condicion2, campo2);
                listPerfilUsuario.Columns.Clear();
                cn.setBtitacora("1103", "Elimino Perfil-Aplicacion");
            }
            else
            {
                limpiar();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AyudaAsignacionPerfilesUsuario b = new AyudaAsignacionPerfilesUsuario();
            b.Show();
        }
    }
}
