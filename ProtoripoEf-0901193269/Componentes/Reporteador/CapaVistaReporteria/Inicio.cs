using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CapaVistaReporteria
{
    public partial class Inicio : Form
    {
        string connectionString = @"Server=colchoneria.mysql.database.azure.com;Database=colchoneria;Uid=administrador;Pwd=Jm123456;";
        int idregistro =0;
        public Inicio()
        {
            InitializeComponent();
            cargarCategorias();
        }

        private void btn_examinar_Click(object sender, EventArgs e)
        {
            OpenFileDialog v1 = new OpenFileDialog();
            v1.Filter = "All files (*.*)|*.*";
            if (v1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = v1.FileName;

                string[] separatingStrings = { "\\" };

                string text = textBox1.Text;
                

                string[] words = text.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
                string db = "";
                Boolean ruta = false;

                for (int i = 0; i < words.Length; i++)
                {

                    if (ruta)
                    {
                        if (i < words.Length - 1)
                        {
                            db += words[i] + '\\';
                        }
                        else
                        {
                            db += words[i];
                        }
                    }
                    if (words[i].Equals("Reportes"))
                    {
                        ruta = true;
                    }
                }
                textBox1.Text = db;

            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("pa_reporteria_agregareditar", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_idregistro", idregistro);
                mySqlCmd.Parameters.AddWithValue("_ruta", textBox1.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_nombre_archivo", textBox2.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_aplicacion", comboBox1.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_estado", comboBox2.Text.Trim());
                mySqlCmd.ExecuteNonQuery();

                MessageBox.Show("Ingresado Correctamente");

                Clear();
            }

        }

        private void btn_ver_reporte_Click(object sender, EventArgs e)
        {
            string disp;
            disp = Convert.ToString(comboBox2.Text);
            if (disp == "Visible")
            {
            
                string r = textBox1.Text;
                visualizar b = new visualizar(r);
                b.Show();
            }
            else
            {
                MessageBox.Show("No esta habilitado el reporte");
            }
        }
        void GridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("pa_registro_ver", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtbregistro = new DataTable();
                sqlDa.Fill(dtbregistro);
                tabla_registro.DataSource = dtbregistro;
                tabla_registro.Columns[0].Visible = true;
            }

        }


        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            Clear();
            GridFill();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                string deleteQuery = "DELETE FROM colchoneria.tbl_regreporteria WHERE idregistro = " + textBox3.Text;
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand(deleteQuery, mysqlCon);
                mySqlCmd.ExecuteNonQuery();

                MessageBox.Show("Eliminado Correctamente");

                Clear();
            }
            
        }

        void Clear()
        {
            textBox3.Text= textBox1.Text = textBox2.Text = comboBox1.Text = comboBox2.Text = "";
            idregistro = 0;
            
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void tabla_registro_DoubleClick(object sender, EventArgs e)
        {
            btn_guardar.Enabled = false;
            btn_modificar.Enabled = true;
            btn_eliminar.Enabled = true;

            if (tabla_registro.CurrentRow.Index != -1)
                textBox3.Text = tabla_registro.CurrentRow.Cells[0].Value.ToString();
                textBox1.Text = tabla_registro.CurrentRow.Cells[1].Value.ToString();
                textBox2.Text = tabla_registro.CurrentRow.Cells[2].Value.ToString();
                comboBox1.Text = tabla_registro.CurrentRow.Cells[3].Value.ToString();
                comboBox2.Text = tabla_registro.CurrentRow.Cells[4].Value.ToString();
                idregistro = Convert.ToInt32(tabla_registro.CurrentRow.Cells[0].Value.ToString());
               
            
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {

            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("pa_reporteria_agregareditar", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_idregistro", idregistro);
                mySqlCmd.Parameters.AddWithValue("_ruta", textBox1.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_nombre_archivo", textBox2.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_aplicacion", comboBox1.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_estado", comboBox2.Text.Trim());
                mySqlCmd.ExecuteNonQuery();

                MessageBox.Show("Actualizado Correctamente");

                Clear();
            }
        }

        private void cargarCategorias()
        {
            comboBox1.DataSource = null;
            comboBox1.Items.Clear();
            string sql = "SELECT pk_id_aplicacion  FROM tbl_aplicaciones ORDER BY pk_id_aplicacion ASC ";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql,conexionBD);
                MySqlDataAdapter data = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                data.Fill(dt);

                comboBox1.ValueMember = "pk_id_aplicacion";
                comboBox1.DisplayMember = "pk_id_aplicacion";
                comboBox1.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar Aplicación" + ex.Message);
            }

            finally
            {
                conexionBD.Close();
            }
           
        }
    }
}
