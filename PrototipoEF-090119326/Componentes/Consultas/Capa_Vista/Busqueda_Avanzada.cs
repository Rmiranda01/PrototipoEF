using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Capa_VistaConsultas
{
    // Josue Amaya 0901-19-12421
    //busqueda Avanzada 
    public partial class Busqueda_Avanzada : Form
    {
        Capa_ControladorConsultas.csControldor csn = new Capa_ControladorConsultas.csControldor();

        String tableN;
        String datobuscar = "";
        String buscaren = "";
        String cadenaB = "";

        public Busqueda_Avanzada()
        {
            InitializeComponent();
            btn_BuscarBA.Enabled = true;
            CargoCombo(cbo_buscaren);

        }

        private void CargoCombo(ComboBox cbo_buscaren)
        {
            OdbcConnection con = new OdbcConnection("Dsn=Colchoneria");
            con.Open();
            cbo_buscaren.DataSource = con.GetSchema("Tables");
            cbo_buscaren.DisplayMember = "TABLE_NAME";
            con.Close();
        }

        private void btn_SalirBA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bnt_nuevaBA_Click(object sender, EventArgs e)
        {
            panelResultado.Visible = false;
            btn_BuscarBA.Enabled = true;
            cbox_columnas.Items.Clear();
            lbl_cadena.Text = "";
            btn_BuscarBA.Enabled = true;
        }

        private void btn_BuscarBA_Click(object sender, EventArgs e)
        {
            tableN = cbo_buscaren.Text;
            BuscarBA(tableN,dgvDato);
        }

        public void BuscarBA(string tableN, DataGridView dgvDato)
        {
            DataTable dt = new DataTable();
            csn.BuscarBA(tableN, dt);

            if (dt.Rows.Count > 0)
            {
                panelResultado.Visible = true;
                dgvDato.DataSource = dt;
            }
            else
            {
                String textalert = " Error al consultar Tabla ";
                MessageBox.Show(textalert);
            }
        }

        private void pnl_BuscarBA_Paint(object sender, PaintEventArgs e)
        {
            CargarColumnas(cbox_columnas, tableN);
        }

        private void bnt_buscaPor_Click(object sender, EventArgs e)
        {
            datobuscar = txt_BuscaPor.Text;
            buscaren = cbox_columnas.Text;

            BuscaPor(datobuscar, buscaren, tableN);
            CargarColumnas(cbox_columnas, tableN);
            cadenaB = "";
        }

        public void CargarColumnas(ComboBox cbox_columnas, String tableN)
        {
            cbox_columnas.Items.Clear();
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

        public void BuscaPor(string datobuscar, string buscaren, string tableN)
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

        private void btn_HelpmeBS_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "../../../../Ayuda/Componentes/Consultas/Ayuda_Busqueda_Avanzada/BsimpleHelp.chm", "Bavanzada.html");
        }

        private void Busqueda_Avanzada_Load(object sender, EventArgs e)
        {

        }

        private void panelResultado_Paint(object sender, PaintEventArgs e)
        {
            btn_BuscarBA.Enabled = false;
        }
    }
}
