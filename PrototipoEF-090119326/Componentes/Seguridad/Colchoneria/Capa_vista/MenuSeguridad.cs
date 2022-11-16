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
    public partial class MenuSeguridad : Form
    {

        Controlador cn = new Controlador();

        public MenuSeguridad()
        {
            InitializeComponent();
            Button[] apps = { btnusuarios, btnaplicaciones, btnmodulos, button1, btnmodaplicacion, btnappperfil, btnperfilusuario, btncambiarcontra, btbitacor };
            cn.deshabilitarApps(apps);

            cn.getAccesoApp(1001, apps[0]);
            cn.getAccesoApp(1002, apps[1]);
            cn.getAccesoApp(1003, apps[2]);
            cn.getAccesoApp(1004, apps[3]);

            cn.getAccesoApp(1101, apps[4]);
            cn.getAccesoApp(1102, apps[5]);
            cn.getAccesoApp(1103, apps[6]);


            cn.getAccesoApp(1201, apps[7]);


            cn.getAccesoApp(1301, apps[8]);


        }

        private void customizeDesing()
        {
           
            panelTranportes.Visible = false;
            PanelAuditoria.Visible = false;
            panelayuda.Visible = false;
            panelseguridad.Visible = false;
        }

        private void hideSubMenu()
        {
            
            if (panelTranportes.Visible == true)
                panelTranportes.Visible = false;
            if (PanelAuditoria.Visible == true)
                PanelAuditoria.Visible = false;
            if (panelseguridad.Visible == true)
                panelseguridad.Visible = false;
            if (panelayuda.Visible == true)
                panelayuda.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnmanteniminetos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTranportes);
        }

        private void btnasignaciones_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelAuditoria);
        }

        private void btnbitacora_Click(object sender, EventArgs e)
        {
            showSubMenu(panelayuda);
        }

        private void btncontrase_Click(object sender, EventArgs e)
        {
            showSubMenu(panelseguridad);
        }

        private void btnusuarios_Click(object sender, EventArgs e)
        {
            Usuario b = new Usuario();
            b.MdiParent = this;
            b.Show();
            hideSubMenu();
        }

        private void btnaplicaciones_Click(object sender, EventArgs e)
        {
            Aplicacion b = new Aplicacion();
            b.MdiParent = this;
            b.Show();
            hideSubMenu();
        }

        private void btnmodulos_Click(object sender, EventArgs e)
        {
            Modulos b = new Modulos();
            b.MdiParent = this;
            b.Show();
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Perfiles b = new Perfiles();
            b.MdiParent = this;
            b.Show();
            hideSubMenu();
        }

        private void btnmodaplicacion_Click(object sender, EventArgs e)
        {
            AsignacionModuloAplicacion b = new AsignacionModuloAplicacion();
            b.MdiParent = this;
            b.Show();
            hideSubMenu();
        }

        private void btnappperfil_Click(object sender, EventArgs e)
        {
            AsignacionAplicacionesPerfiles b = new AsignacionAplicacionesPerfiles();
            b.MdiParent = this;
            b.Show();
            hideSubMenu();
        }

        private void btnperfilusuario_Click(object sender, EventArgs e)
        {
            AsignacionPerfiles b = new AsignacionPerfiles();
            b.MdiParent = this;
            b.Show();
            hideSubMenu();
        }

        private void btncambiarcontra_Click(object sender, EventArgs e)
        {
            Contrase b = new Contrase();
            //b.MdiParent = this;
            b.Show();
            hideSubMenu();
        }

        private void btbitacor_Click(object sender, EventArgs e)
        {
            Bitacora b = new Bitacora();
            b.MdiParent = this;
            b.Show();
            hideSubMenu();
        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnayuda_Click(object sender, EventArgs e)
        {
            AyudaMenuSeguridad b = new AyudaMenuSeguridad();
            b.Show();
        }

        private void MenuSeguridad_Load(object sender, EventArgs e)
        {

        }
    }
}
