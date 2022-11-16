using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seguridad_Controlador;

namespace Vista_Seguridad
{
    public partial class Usuario : Form
    {
        string table = "tbl_usuarios";
        Controlador cn = new Controlador();

        public Usuario()
        {
            InitializeComponent();
        }

        public void validaringre()
        {
            checks();
            checkbox();
            if (txtusername.Text == "" || txtcontraseña.Text == "" || txtnombre.Text == "" || txtapellido.Text == "" || txtemail.Text == "" || TxtPAA.Text == "" || TxtPA.Text == "")
            {

                MessageBox.Show("Debe completar la informacion");



            }
            else
            {
                checks();
                checkbox();
                TextBox[] textbox = { txtnombre, txtapellido, txtcontraseña, txtusername, txtemail, txtestado, TxtPAA, TxtPA };
                txtcontraseña.Text = Seguridad_Controlador.Controlador.SetHash(txtcontraseña.Text);
                TxtPA.Text = Seguridad_Controlador.Controlador.SetHash(TxtPA.Text);
                cn.ingresar(textbox, table);
                cn.setBtitacora("1001", "Crea Nuevo Usuario");
                string message = "Registro Guardado";
                limpiar();
                MessageBox.Show(message);
            }

        }

        public void validaractua()
        {
            checks();
            checkbox();
            if (txtusername.Text == "" || txtcontraseña.Text == "" || txtnombre.Text == "" || txtapellido.Text == "" || txtemail.Text == "" || TxtPAA.Text == "" || TxtPA.Text == "")
            {

                MessageBox.Show("Debe completar la informacion");



            }
            else
            {
                checks();
                checkbox();
                TextBox[] textbox = { txtnombre, txtapellido, txtcontraseña, txtusername, txtemail, txtestado, TxtPAA, TxtPA };
                txtcontraseña.Text = Seguridad_Controlador.Controlador.SetHash(txtcontraseña.Text);
                int valor1 = int.Parse(txtBusqueda.Text);
                string campo = "pk_id_usuario = ";
                cn.actualizar(textbox, table, campo, valor1);
                cn.setBtitacora("1001", "Actualiza Usuario");
            }

        }



        public void limpiar()
        {
            txtBusqueda.Text = "";
            txtusername.Text = "";
            txtcontraseña.Text = "";
            txtnombre.Text = "";
            txtapellido.Text = "";
            txtemail.Text = "";
            txtestado.Text = "";
            CmbPA.Text = "";
            TxtPA.Text = "";
            TxtPAA.Text = "";
        }

        public void checkbox()
        {
            if (checkBox1.Checked)
            {
                txtestado.Text = "1";
            }
            else
            {
                txtestado.Text = "0";
            }
        }

        private void button5_Click(object sender, EventArgs e)// boton salir
        {
            
            this.Hide();
        }

        public void checks()
        {
            string pregunta;
            pregunta = CmbPA.Text;

            TxtPAA.Text = pregunta;

        }

        private void llenap()
        {
            string[] permisos = new string[10];
            
            //MessageBox.Show(message);
            string[] dato = cn.buscarusu(txtBusqueda.Text);
            MessageBox.Show(" hola "+ dato[0]);

        }


        private void button3_Click(object sender, EventArgs e)//boton guardar
        {
            validaringre();
        }

        private void button1_Click(object sender, EventArgs e) //Boton Buscar
        {
            TextBox[] textbox = { txtnombre, txtapellido, txtcontraseña, txtusername, txtemail, txtestado };
            int valor1 = int.Parse(txtBusqueda.Text);
            string campo = "pk_id_usuario = ";
            cn.buscar(textbox,table, valor1,campo);
        }

        private void button4_Click(object sender, EventArgs e) //boton modificar
        {
            validaractua();
        }

        private void button2_Click(object sender, EventArgs e)// boton nuevo
        {
            limpiar();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            txtestado.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)// boton eliminar
        {
            string message = "Deseas Eliminar el Registro?";
            string title = "Eliminar Registro";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            try
            {


                if (result == DialogResult.Yes)
                {

                    int campo = int.Parse(txtBusqueda.Text);
                    string condicion = "pk_id_usuario = ";
                    cn.eliminar(table, condicion, campo);
                    cn.setBtitacora("1001", "Elimina un Usuario");
                    string message1 = "Registro eliminado / Estado de usuario deshabilitado";
                    limpiar();
                    MessageBox.Show(message1);
                }
                else
                {
                    limpiar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se puede eliminar por permisos asignados");
                Console.WriteLine(ex.Message.ToString() + " \nNo se puede eliminar por permisos asignados");
            }
        }

        private void txtestado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            llenap();

        }

        private void check_CheckedChanged(object sender, EventArgs e)
        {
            if (check.Checked == true)
            {
                // TBcontraseña.PasswordChar = '*';
                txtcontraseña.PasswordChar = '\0';
            }
            else
                      if (txtcontraseña.Text != "")
            {
                // TBcontraseña.PasswordChar = '\0';
                txtcontraseña.PasswordChar = '*';
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ayudausuario b = new ayudausuario();
            //b.MdiParent = this;
            b.Show();
        }
    }
}
