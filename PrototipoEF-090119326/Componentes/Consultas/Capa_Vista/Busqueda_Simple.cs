using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Capa_VistaConsultas
{
    // Josue Amaya 0901-19-12421
    // Busqueda Simple Usuario 
    public partial class Busqueda_Simple : Form
    {
        Capa_ControladorConsultas.csControldor csn = new Capa_ControladorConsultas.csControldor();

        public String tableN1 ="";
        String datobuscar = "";
        String buscaren ="";
        String cadenaB = "";

        public Busqueda_Simple()
        {
            InitializeComponent();
            panelResultado.Visible = true;
           
        }

        private void btn_SalirBA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_CancelarBA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void BuscarT()
        {
            string tableN = tableN1;
            DataTable dt = new DataTable();
            csn.BuscarBA(tableN, dt);
            if (dt.Rows.Count > 0)
            {
                panelResultado.Visible = true;
                dgvDato.DataSource = dt;
            }
        }

        private void Busqueda_Avanzada_Load(object sender, EventArgs e)
        {

        }

        private void pnl_BuscarBA_Paint(object sender, PaintEventArgs e)
        {
            cbox_columnas.Items.Clear();
        }

        private void panelResultado_Paint(object sender, PaintEventArgs e)
        {
            CargarColumnas(cbox_columnas , tableN1);
        }



        private void bnt_buscaPor_Click(object sender, EventArgs e)
        {
            datobuscar = txt_BuscaPor.Text;
            buscaren = cbox_columnas.Text;

            BuscaPor(datobuscar , buscaren , tableN1);
            CargarColumnas(cbox_columnas, tableN1);
            cadenaB = "";

        }

        public void CargarColumnas(ComboBox cbox_columnas, String tableN)
        {
            int ndgv = dgvDato.Columns.Count;

            for (int i = 0; i < ndgv; i++)
            {
                String nameC;
                nameC = dgvDato.Columns[i].HeaderText;
                int ncbx = cbox_columnas.Items.Count;
                if (ncbx < ndgv)
                {
                    cbox_columnas.Items.Add(nameC);
                }
            }
        }

        private void BuscaPor(string datobuscar, string buscaren, string tableN)
        {
            DataTable dt = new DataTable();
            csn.BuscarPor(datobuscar, buscaren, tableN, dt, lbl_cadena);

            if (dt.Rows.Count > 0)
            {
                panelResultado.Visible = true;
                dgvDato.DataSource = dt;
                cadenaB = "";
                datobuscar = "";
                buscaren = "";
                txt_BuscaPor.Text = "";
            }
        }

        private void dgvDato_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbo_buscaren_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
