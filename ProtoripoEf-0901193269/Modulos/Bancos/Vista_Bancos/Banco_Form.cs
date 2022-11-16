using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista_Bancos
{

    public partial class Banco_Form : Form
    {
        Seguridad_Controlador.Controlador cnseg = new Seguridad_Controlador.Controlador();
        public Banco_Form()
        {
            InitializeComponent();
            HideStart();
        }
        private void HideStart()
        {
            //Metodo para cubrir los paneles
            panelConceptosBanc.Visible = false;
            panelPartidasCont.Visible = false;
            panelMantenimientos.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelConceptosBanc.Visible == true)
                panelConceptosBanc.Visible = false;
            if (panelPartidasCont.Visible == true)
                panelPartidasCont.Visible = false;
            if (panelMantenimientos.Visible == true)
                panelMantenimientos.Visible = false;
            if(panel1.Visible==true)
                panel1.Visible = false;
            if (panel2.Visible == true)
                panel2.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = true;
        }
        private void Banco_Form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMantenimientos);
        }

        private void btnConceptosBanc_Click(object sender, EventArgs e)
        {
            showSubMenu(panelConceptosBanc);
        }

        private void btnPartidasCont_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPartidasCont);
        }

        private void btnCheques_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDepositos_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNC_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnDisponibilidad_Click(object sender, EventArgs e)
        {
           
        }

        private void btnMovBanc_Click(object sender, EventArgs e)
        {
        }

        private void btnTipoDeCambio_Click(object sender, EventArgs e)
        {
           
        }

        private void btnPolizas_Click(object sender, EventArgs e)
        {
           
        }

        private void btnIngresosEgresos_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEgresos_Click(object sender, EventArgs e)
        {
           
        }

        private void btnRepBanc_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnBancos_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ReporFacturas repofac = new ReporFacturas();
            repofac.MdiParent = this;
            repofac.Show();
            logop.Visible = false;
        }

        private void btnCuentasBanc_Click(object sender, EventArgs e)
        {
           
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
           
        }

        private void CncBancario_Click(object sender, EventArgs e)
        {
           
        }

        private void btnTipoDeCambio_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnConcilacionBancaria_Click(object sender, EventArgs e)
        {
  
        }

        private void btnRepCuentasBanc_Click(object sender, EventArgs e)
        {
            
        }
        private void btnReportes_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panel1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHerramientas_Click(object sender, EventArgs e)
        {
            showSubMenu(panel2);
        }

        private void btnconsultaA_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Capa_VistaConsultas.Busqueda consultar = new Capa_VistaConsultas.Busqueda();
            consultar.MdiParent = this;
            consultar.StartPosition = FormStartPosition.CenterScreen;
            consultar.Show();

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnfactura_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Facturas fac = new Facturas();
            fac.MdiParent = this;
            fac.Show();
            logop.Visible = false;
        }
    }
}
