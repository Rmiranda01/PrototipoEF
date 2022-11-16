using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_ControladorConsultas;
using System.Data.Odbc;


namespace Capa_VistaConsultas
{
  
    public partial class Busqueda : Form
    {
       
        csControldor cn = new csControldor();
        OdbcConnection con = new OdbcConnection("Dsn=Colchoneria");
        String tablabusqueda;
        public Busqueda()
        {
            InitializeComponent();
            CargarTablas(cboTabla);
            CargarTablas(cboTablaConsultaSimple);

            panel13.Enabled = false;
            panel15.Enabled = false;
            // groupBox3.Enabled = false;
            groupBox6.Enabled = false;
            groupBox4.Enabled = false;
            groupBox5.Enabled = false;


        }
        string consulta = "";

        public void CargarTablas(ComboBox comboBox1)
        {
            OdbcConnection con = new OdbcConnection("Dsn=Colchoneria");
            con.Open();
            comboBox1.DataSource = con.GetSchema("Tables");
            comboBox1.DisplayMember = "TABLE_NAME";
            con.Close();
        }




        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // Jonathan Xuyá 0901-19-
            //boton agregar de creacion de consulta

            Capa_ControladorConsultas.csControldor crud = new Capa_ControladorConsultas.csControldor();
            bool resultado = crud.InsertBusqueda(txtNombreConsulta.Text, cboTabla.Text, comboBox11.Text, textBox11.Text, textBox8.Text, null);

            if (resultado)

            {
                MessageBox.Show("Datos guardados");
            }

            textBox1.Text = (txtNombreConsulta.Text + "+" + cboTabla.Text + "+" + comboBox11.Text + "+" + textBox11.Text + "+");
            string columnasbd = comboBox11.Text;
            //CargarColumnas(columnasbd, comboBox11);
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            // Jonathan Xuyá 0901-19-
            //boton cancelar de creacion de consulta
            txtNombreConsulta.Clear();
            cboTabla.ResetText();
            comboBox11.ResetText();
            textBox11.Clear();



        }


        private void iconButton3_Click(object sender, EventArgs e)
        {
            // Jonathan Xuyá 0901-19-
            //boton agregar de creacion de consulta
            Capa_ControladorConsultas.csControldor crud = new Capa_ControladorConsultas.csControldor();
            bool resultado = crud.InsertBusquedaCompleja(comboBox13.Text, comboBox12.Text, textBox16.Text, null);
            if (resultado)
            {
                MessageBox.Show("Datos guardados");
            }
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            // Jonathan Xuyá 0901-19-
            //boton cancelar de creacion de consulta
            comboBox13.ResetText();
            comboBox12.ResetText();
            textBox16.Clear();

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            // Jonathan Xuyá 0901-19-
            //boton agregar de creacion de consulta
            Capa_ControladorConsultas.csControldor crud = new Capa_ControladorConsultas.csControldor();
            bool resultado = crud.InsertBusquedaCompleja(comboBox14.Text, comboBox15.Text, textBox9.Text, null);
            if (resultado)
            {
                MessageBox.Show("Datos guardados");
            }
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            // Jonathan Xuyá 0901-19-
            //boton cancelar de creacion de consulta
            comboBox13.ResetText();
            comboBox12.ResetText();
            textBox16.Clear();
        }

        private void iconButton5_Click(object sender, EventArgs e)

        {
            // Jonathan Xuyá 0901-19-
            //boton agregar de creacion de consulta
            Capa_ControladorConsultas.csControldor crud = new Capa_ControladorConsultas.csControldor();
            bool resultado = crud.InsertBusquedaCompleja1(comboBox16.Text, comboBox17.Text, null);
            if (resultado)
            {
                MessageBox.Show("Datos guardados");
            }
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            // Jonathan Xuyá 0901-19-
            //boton cancelar de creacion de consulta
            comboBox16.ResetText();
            comboBox17.ResetText();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Jonathan Xuyá 0901-19-
            //boton eliminar de creacion de consulta
            txtNombreConsulta.Clear();
            cboTabla.ResetText();
            comboBox11.ResetText();
            textBox11.Clear();
            comboBox16.ResetText();
            comboBox17.ResetText();
            comboBox13.ResetText();
            comboBox12.ResetText();
            textBox16.Clear();
            comboBox14.ResetText();
            comboBox15.ResetText();
            textBox9.Clear();
            textBox8.Clear();
            textBox1.Clear();

        }


        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

            // textBox1.Text = txtNombreConsulta.Text+ cboTabla.Text+ comboBox11.Text+ textBox11.Text;
        }

       
        //Diana Victores 9959-19-1471
        public void actualizaconsultas(DataGridView dataGridView)
        {
            //metodo actualizaconsultas para boton consultas de Buscar/Eliminar
            //Diana Victores 9959-19-1471
            DataTable dt = cn.llenartb2();
            dataGridView.DataSource = dt;
        }

        //boton eliminar de la forma Buscar/Eliminar - Diana Victores 9959-19-1471
        private void iconButton12_Click(object sender, EventArgs e)
        {
            //Diana Victores 9959-19-1471
            //boton eliminar de Buscar/Eliminar
            cn.ejecutarconsulta(txtNombreConsultaBusquedaElimar.Text);
            if (MessageBox.Show("Desea eliminar el registro", "Desea eliminar el registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
            
            MessageBox.Show("Las consultas con nombre " + txtNombreConsultaBusquedaElimar.Text + " Han sido eliminadas");
            actualizaconsultas(dgvBUSCARyELIMINAR);
            txtNombreConsultaBusquedaElimar.Text = "";
        }
        }
        public void actualizaconsultas2(string condicion)
        {
            DataTable dt = cn.llenartb3(condicion);
            dgvBUSCARyELIMINAR.DataSource = dt;
        }
        //private void ConsultasInteligentes_Load(object sender, EventArgs e)
        //{

        //    llenarcboquery();
        //    tablaseditar();
        //}



        private void cbonombreconsulta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboTablaConsultaSimple_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txttablaeditar.Text = cboTablaConsultaSimple.SelectedItem.ToString();
            //chkSelectTodosConsultaSimple.Enabled = true;
        }

        string query = "registro_consultas";
        
        private void iconButton28_Click(object sender, EventArgs e)
        {
            //Joselyne Rivera 0901-17-05
            //boton Agregar Editar
            actualizaconsultas(dgvBUSCARyELIMINAR);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarConsultas(cboQueryy);
            CargarConsultas(cbonombrebuscar);
        }

        private void cboCampoAgruparEDITAR_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboAgruparEDITAR_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAgruparEditar.SelectedIndex == 1)
            {
                groupBox7.Enabled = true;
            }
            else
            {
                groupBox7.Enabled = false;
                rdbAscEDITAR.Checked = false;
                rdbdescEDITAR.Checked = false;
            }
        }

        private void btnAgregarAgruparOrdenarEDITAR_Click(object sender, EventArgs e)
        {
            //Joselyne Rivera 0901-17-05
            //boton Agregar Editar
            Capa_ControladorConsultas.csControldor crud = new Capa_ControladorConsultas.csControldor();
            bool resultado = crud.InsertBusquedaCompleja1(cboAgruparEditar.Text, cboCampoAgruparEditar.Text, null);
            if (resultado)
            {
                MessageBox.Show("Datos guardados");
            }
        }

        private void btnAgregarComparacionEDITAR_Click(object sender, EventArgs e)
        {
            //Diana Victores 9959-19-1471
            //boton agregar de Editar
            Capa_ControladorConsultas.csControldor crud = new Capa_ControladorConsultas.csControldor();
            bool resultado = crud.InsertBusquedaCompleja(cboTipoComparadorEditar.Text, cboCampoEditar.Text, txtValorComparacionEDITAR.Text, null);
            if (resultado)
            {
                MessageBox.Show("Datos guardados");
            }
        }

        private void btnagregarCONSULTACOMPLEJAEDITAR_Click(object sender, EventArgs e)
        {
            // Joselyne Rivera 0901-18-
            //boton agregar de Editar 
            Capa_ControladorConsultas.csControldor crud = new Capa_ControladorConsultas.csControldor();
            bool resultado = crud.InsertBusquedaCompleja(cboOperadorLogicoEDITAR.Text, cboCampoConsultaComplejaEditar.Text, txtvalorConsultaComplejaEDITAR.Text, null);
            if (resultado)
            {
                MessageBox.Show("Datos guardados");
            }
        }

        private void chkcondicioneseditar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkcondicioneseditar.Checked == true)

            {
                groupBox4.Enabled = true;
                groupBox5.Enabled = true;
                groupBox6.Enabled = true;
            }
            else
            {
                groupBox4.Enabled = false;
                groupBox5.Enabled = false;
                groupBox6.Enabled = false;
            }

        }


        private void btnAgregarCONSULTASIMPLE_Click(object sender, EventArgs e)
        {
            // Diana Victores 9959-19-1471
            //boton agregar de Editar
            Capa_ControladorConsultas.csControldor crud = new Capa_ControladorConsultas.csControldor();
            bool resultado = crud.InsertBusqueda(txtcamposelectoseditar.Text, cboTablaConsultaSimple.Text, cboCamposEDITAR.Text, txtNombreAlias.Text, txtCadenaGeneradaEDITAR.Text,  null);

            if (resultado)

            {
                MessageBox.Show("Datos guardados");
            }

            txtTablaConsulta.Text = (txtcamposelectoseditar.Text + "+" + cboTablaConsultaSimple.Text + "+" + cboCamposEDITAR.Text + "+" + txtNombreAlias.Text +"+" + txtCadenaGeneradaEDITAR.Text + "+");
            string columnasbd = comboBox11.Text;
            //CargarColumnas(columnasbd, comboBox11);
        }

        private void chkSelectTodosConsultaSimple_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkSelectTodosConsultaSimple.Checked == true)
            //{
            //    txtNombreAlias.Text = "";
            //    txtNombreAlias.Enabled = false;
            //    cboCamposEDITAR.Text = "";
            //    cboCamposEDITAR.Enabled = false;
            //    txtcamposelectoseditar.Text = "";
            //}
            //else
            //{
            //    txtNombreAlias.Text = "";
            //    txtNombreAlias.Enabled = true;
            //    cboCamposEDITAR.Text = "";
            //    cboCamposEDITAR.Enabled = true;
            //}
        }

        private void iconButton25_Click(object sender, EventArgs e)
        {
            //Diana Victores - Joselyne Rivera 
            actualizaconsultas2(txtNombreConsultaBusquedaElimar.Text);
        }

        private void btnActualizarBUSCARyELIMINAR_Click(object sender, EventArgs e)
        {
            //Joselyne Rivera 0901-17-05
            //boton Agregar Editar
            string transfiere = txtNombreConsultaBusquedaElimar.Text;
            cbonombrebuscar.Text = transfiere;
            txtTablaConsulta.Text = transfiere;
            groupBox2.Enabled = true;
            tbpBuscarEliminar.Show();
            tbpEditar.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            // Jonathan Xuyá 0901-19-
            //boton agregar de creacion de consulta
            Capa_ControladorConsultas.csControldor crud = new Capa_ControladorConsultas.csControldor();
            textBox8.Text = "SELECT FROM" + "*" + "_" + "WHERE" + query + "_" + "INSERTED" + "";
            txtNombreConsulta.Clear();
            cboTabla.ResetText();
            comboBox11.ResetText();
            textBox11.Clear();
            comboBox16.ResetText();
            comboBox17.ResetText();
            comboBox13.ResetText();
            comboBox12.ResetText();
            textBox16.Clear();
            comboBox14.ResetText();
            comboBox15.ResetText();
            textBox9.Clear();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {



            if (checkBox3.Checked == true)

            {
                panel15.Enabled = true;
                panel13.Enabled = true;
            }
            else
            {
                panel15.Enabled = false;
                panel13.Enabled = false;
                //checkBox3.Checked = false;

            }


        }

        public void habilitaciones()
        {
            panel15.Enabled = false;
            panel13.Enabled = false;
            checkBox3.Checked = false;


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboQueryy.SelectedIndex = cboQueryy.SelectedIndex;
            txtCadenaGeneradaConsulta.Text = cboQueryy.SelectedItem.ToString();
            consulta = txtCadenaGeneradaConsulta.Text;
        }

        private void cbosubquery_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //private void iconButton27_Click(object sender, EventArgs e)
        //{
        //    actualizardatagrid();
        //}

        //private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    DataTable dt = cn.llenartb1(consulta);
        //    dataGridView2.DataSource = dt;
        //}

        private void cbonombreconsulta_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtTablaConsulta.Text = cbonombrebuscar.SelectedItem.ToString();
            groupBox2.Enabled = true;
        }

        private void cboTabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            tablabusqueda = "";
            comboBox11.Items.Clear();
            comboBox12.Items.Clear();
            comboBox15.Items.Clear();
            comboBox17.Items.Clear();
            tablabusqueda = cboTabla.Text;
            CargarColumnas(comboBox11, comboBox12, comboBox15, comboBox17, tablabusqueda);

        }

        private void CargarColumnas(ComboBox comboBox1, ComboBox comboBox2, ComboBox comboBox3, ComboBox comboBox4, string @string)
        {
            DataTable dt = new DataTable();
            try
            {
                string cadena = " SELECT  * FROM " + tablabusqueda;
                OdbcDataAdapter datos = new OdbcDataAdapter(cadena, con);
                datos.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dgv_prueba.DataSource = dt;
                    int ndgv = dgv_prueba.Columns.Count;

                    for (int i = 0; i < ndgv; i++)
                    {
                        String nameC;
                        nameC = dgv_prueba.Columns[i].HeaderText;
                        int ncbx = comboBox1.Items.Count;
                        if (ncbx < ndgv)
                        {
                            comboBox1.Items.Add(nameC);
                            comboBox2.Items.Add(nameC);
                            comboBox3.Items.Add(nameC);
                            comboBox4.Items.Add(nameC);
                        }
                    }
                }
            }
            catch
            {
                /*  String textalert = " Error al consultar Tabla ";
                  MessageBox.Show(textalert);*/
            }
            con.Close();
        }

        private void cboCamposEDITAR_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboTablaConsultaSimple_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            tablabusqueda = "";
            cboCamposEDITAR.Items.Clear();
            cboCampoConsultaComplejaEditar.Items.Clear();
            cboCampoEditar.Items.Clear();
            cboCampoAgruparEditar.Items.Clear();
            tablabusqueda = cboTablaConsultaSimple.Text;
            CargarColumnas(cboCamposEDITAR,cboCampoConsultaComplejaEditar,cboCampoEditar,cboCampoAgruparEditar, tablabusqueda);



           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tbpEditar_Click(object sender, EventArgs e)
        {

        }

        private void tbpCreacion_Click(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        public void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboTabla_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void cboTabla_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox11_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cboTabla_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iconButton13_Click(object sender, EventArgs e)
        {
            //Joselyne Rivera 0901-17-05
            //boton Agregar Editar
        }

        private void cboCampoConsultaComplejaEDITAR_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboCampoEDITAR_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTablaConsulta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelarAgruparOrdenarEDITAR_Click(object sender, EventArgs e)
        {
            //Joselyne Rivera 0901-17-05
            //boton Cancelar Editar
            cboAgruparEditar.ResetText();
            cboCampoAgruparEditar.ResetText();
        }

        private void btnCancelarCONSULTACOMPLEJAEDITAR_Click(object sender, EventArgs e)
        {
            // Joselyne Rivera 0901-17-05
            //boton cancelar Editar
            cboOperadorLogicoEDITAR.ResetText();
            cboCampoConsultaComplejaEditar.ResetText();
//cbocompand.ResetText();
            txtvalorConsultaComplejaEDITAR.Clear();
        }

        private void txtcancelarComparacionEDITAR_Click(object sender, EventArgs e)
        {
            // Diana Victores 9959-19-1471
            //boton cancelar Editar
            cboTipoComparadorEditar.ResetText();
            cboCampoEditar.ResetText();
         //   cbocompwhere.ResetText();
            txtValorComparacionEDITAR.Clear();
        }

        private void btnCancelarCONSULTASIMPLE_Click(object sender, EventArgs e)
        {
            // Diana Victores 9959-19-1471
            //boton cancelar de Editar
            txtcamposelectoseditar.Clear();
            cboTablaConsultaSimple.ResetText();
            cboCamposEDITAR.ResetText();
            txtNombreAlias.Clear();
            txtTablaConsulta.Clear();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //Diana Victores 9959-19-1471
            //boton Eliminar Editar
            txtcamposelectoseditar.Clear();
            cboTablaConsultaSimple.ResetText();
            cboCamposEDITAR.ResetText();
            txtNombreAlias.Clear();
            txtTablaConsulta.Clear();

            cboOperadorLogicoEDITAR.ResetText();
            cboCampoConsultaComplejaEditar.ResetText();
         //   cbocompand.ResetText();
            txtvalorConsultaComplejaEDITAR.Clear();
            cboTipoComparadorEditar.ResetText();
            cboCampoEditar.ResetText();
         //   cbocompwhere.ResetText();
            txtValorComparacionEDITAR.Clear();
            cboAgruparEditar.ResetText();
            cboCampoAgruparEditar.ResetText();
            txtCadenaGeneradaEDITAR.Clear();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            //Diana Victores 9959-19-1471
            //Boton Editar

            cn.editarconsulta(cboTablaConsultaSimple.Text, cboCamposEDITAR.Text, txtNombreAlias.Text, txtcamposelectoseditar.Text);
            cn.editarconsulta1(cboOperadorLogicoEDITAR.Text, cboCampoConsultaComplejaEditar.Text, txtvalorConsultaComplejaEDITAR.Text, cbocompand.Text);
            cn.editarconsulta2(cboAgruparEditar.Text, cboCampoAgruparEditar.Text);
            cn.editarconsulta3(cboCamposEDITAR.Text, txtvalorConsultaComplejaEDITAR.Text);

            //insert cadena
            Capa_ControladorConsultas.csControldor crud2 = new Capa_ControladorConsultas.csControldor();
            txtCadenaGeneradaEDITAR.Text = "SELECT FROM" + "*" + "_" + "WHERE" + query + "_" + "INSERTED" + "";
            
            
            //clear
            //txtcamposelectoseditar.Clear();
            //cboTablaConsultaSimple.ResetText();
            //cboCamposEDITAR.ResetText();
            //txtNombreAlias.Clear();
            //txtTablaConsulta.Clear();

            //cboOperadorLogicoEDITAR.ResetText();
            //cboCampoConsultaComplejaEditar.ResetText();
            //cbocompand.ResetText();
            //txtvalorConsultaComplejaEDITAR.Clear();
            //cboTipoComparadorEditar.ResetText();
            //cboCampoEditar.ResetText();
            //cbocompwhere.ResetText();
            //txtValorComparacionEDITAR.Clear();
            //cboAgruparEditar.ResetText();
            //cboCampoAgruparEditar.ResetText();
            //txtCadenaGeneradaEDITAR.Clear();


        }
        String datobuscar = "";
        String buscaren = "";
        private void iconButton27_Click(object sender, EventArgs e)
        {
            actualizaconsultas(dataGridView2);
            // Joselyne Rivera 0901-18-  - No se realizo
            // Diana Victores 9959-19-1471 -- llamada al text
            //Josue Amaya 0901-19-12421   --llamada del comboBox
            //boton buscar de Consultas
            
            //Diana Victores
            datobuscar = txtCadenaGeneradaConsulta.Text;
            buscaren = cboQueryy.Text;
            actualizaconsultas2(txtCadenaGeneradaConsulta.Text);

            //Cargarconsultas(cboQueryy);
            //Cargarconsultas(cboQueryy);

            Capa_ControladorConsultas.csControldor crudbuscar = new Capa_ControladorConsultas.csControldor();
            txtCadenaGeneradaConsulta.Text = "SELECT FROM" + "*" + "_" + "WHERE" + query + "_" + "INSERTED" + "";
            
            //Josue Amaya


        }

        private void btnagregarcamposeditar_Click(object sender, EventArgs e)
        {

        }

        private void x(object sender, EventArgs e)
        {

        }

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            
        }

        private void tbpCreacion_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
           // Help.ShowHelp(this, "AyudaConsulta.chm", "ConsultaAvanzada.html");

        }

        public void CargarConsultas(ComboBox cboQueryy)
        {
            con.Open();
            DataTable dt2 = new DataTable();
            //cn.Nconsultas(dt2);
            OdbcCommand comand = new OdbcCommand();
            comand.Connection = con;
            comand.CommandType = CommandType.Text;
            string cadena = "SELECT nombre_consulta FROM tbl_consultainteligente";
            comand.CommandText = cadena;
            OdbcDataAdapter datos = new OdbcDataAdapter(comand);
            datos.Fill(dt2);
            cboQueryy.DataSource = dt2;
            cboQueryy.DisplayMember = "tbl_consultainteligente";
            cboQueryy.ValueMember = "nombre_consulta";
            con.Close();
        }
    }
 }
    
    



