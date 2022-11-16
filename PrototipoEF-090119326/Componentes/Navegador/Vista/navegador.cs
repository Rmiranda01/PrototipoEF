using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using NavegadorControlador;
using Vista;

namespace NavegadorVista
{
    public partial class Navegador : UserControl
    {
        
        csControlador cn = new csControlador();

        Seguridad_Controlador.Controlador cnseg = new Seguridad_Controlador.Controlador();
        public Navegador()
        {
            InitializeComponent();
        }

        public Form actual = new Form();
        public TextBox[] textbox = { };
        public TextBox[] textboxi = { };
        public DataGridView tabla;
        public static string idApp;

        public void consulta()
        {
            string tablan2 = tabla.Tag.ToString();
            /*Capa_VistaConsultas.Busqueda_Simple bs = new Capa_VistaConsultas.Busqueda_Simple();

            bs.tableN1 = tablan2;
            Console.WriteLine(tablan2);
            bs.BuscarT();
            bs.Show();
           
            Console.WriteLine(bs.tableN1);*/
            
            
        }
        



        int opcion;

       
        public void cargar(DataGridView dtabla, TextBox[] text, string BD)
        {
            IconButton[] botongc = {btnInsert, btnModificar, btnDelete, btnUpdate, btnConsultar, btnReporte, btnNext,
                btnBack,btnStart,btnEnd
            };
           
            cn.evaluartabla(dtabla);
            cn.inicializargrid(dtabla);
            cn.llenartablainicio(dtabla.Tag.ToString(), dtabla, text);
            cn.evaluartags(text, dtabla, BD);
            cn.desactivar(actual);
            bloqStart(botongc);
            /*cn.bloqueobtn(botongc);*/
            


        }
        public void bloqEnd(IconButton[] botongc3)
        {
            for (int i = 0; i < botongc3.Length; i++)
            {
                botongc3[i].Enabled = false;
            }
        }
        public void bloqStart(IconButton[] botongc)// bloque botones al principio
        {
            for (int i = 0; i < botongc.Length; i++)
            {
                botongc[i].Enabled = false;
            }
            
            int[] permisos= cnseg.getPermisosAplicaion(idApp);
            if (permisos[0] == 1)//Guardar
            {
                botongc[0].Enabled = true;
                botongc[3].Enabled = true;
                botongc[6].Enabled = true;
                botongc[7].Enabled = true;
                botongc[8].Enabled = true;
                botongc[9].Enabled = true;
            }
            if (permisos[1] == 1)//Modifcar
            { 
                botongc[1].Enabled = true;
                botongc[3].Enabled = true;
                botongc[6].Enabled = true;
                botongc[7].Enabled = true;
                botongc[8].Enabled = true;
                botongc[9].Enabled = true;
            }
            if (permisos[2] == 1)//Eliminar
            {
                botongc[2].Enabled = true;
                botongc[3].Enabled = true;
                botongc[6].Enabled = true;
                botongc[7].Enabled = true;
                botongc[8].Enabled = true;
                botongc[9].Enabled = true;
            }
            if (permisos[3] == 1)//Consultar
            {
                botongc[4].Enabled = true;
                botongc[3].Enabled = true;
                botongc[6].Enabled = true;
                botongc[7].Enabled = true;
                botongc[8].Enabled = true;
                botongc[9].Enabled = true;
            }
            if (permisos[4] == 1)//Reportes
            {
                botongc[5].Enabled = true;
            }

        }
       


        private void btnExit_Click(object sender, EventArgs e)
        {
            actual.Close();
        }

        private void ComponenteNavegador_Load(object sender, EventArgs e)
        {
            IconButton[] botongc = { btnSave, btnCancelar };
            cn.bloquearbotonesGC(botongc, true);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            cn.moverseIF(tabla, "b");
            cn.llenartxt(textbox, tabla);
            cn.desactivar(actual);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            cn.moverseIF(tabla, "s");
            cn.llenartxt(textbox, tabla);
            cn.desactivar(actual);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            cn.moverseIF(tabla, "i");
            cn.llenartxt(textbox, tabla);
            cn.desactivar(actual);
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            cn.moverseIF(tabla, "f");
            cn.llenartxt(textbox, tabla);
            cn.desactivar(actual);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            IconButton[] botongc = { btnSave, btnCancelar };
            IconButton[] botongc3 = {btnInsert, btnModificar, btnDelete, btnUpdate, btnConsultar, btnReporte, btnNext,
                btnBack,btnStart,btnEnd
            };
            bloqEnd(botongc3);
            opcion = 1;
            cn.limpiar(actual);
            cn.activar(actual);
            cn.crearid(textboxi, tabla);
            cn.bloquearbotonesGC(botongc, false);
            


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            opcion = 3;
            int permiso = cn.comprobacionvacio(tabla);
            if (permiso != 0)
            {
                IconButton[] botongc = { btnSave, btnCancelar };
                cn.bloquearbotonesGC(botongc, false);
                IconButton[] botongc3 = {btnInsert, btnModificar, btnDelete, btnUpdate, btnConsultar, btnReporte, btnNext,
                btnBack,btnStart,btnEnd
            };
                bloqEnd(botongc3);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            opcion = 2;
            int permiso = cn.comprobacionvacio(tabla);
            if(permiso != 0)
            {
                cn.activar(actual);
                cn.enfocar(textboxi);
                IconButton[] botongc = { btnSave, btnCancelar };
                cn.bloquearbotonesGC(botongc, false);
                IconButton[] botongc3 = {btnInsert, btnModificar, btnDelete, btnUpdate, btnConsultar, btnReporte, btnNext,
                btnBack,btnStart,btnEnd
            };
                bloqEnd(botongc3);
            }
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            IconButton[] botongc = { btnSave, btnCancelar };
           
            if (opcion == 1)
            {
                cn.ingresar(textbox, tabla, botongc, idApp, actual);
                IconButton[] botongc2 = {btnInsert, btnModificar, btnDelete, btnUpdate, btnConsultar, btnReporte, btnNext,
                btnBack,btnStart,btnEnd
                };
                bloqStart(botongc2);

                //cn.bloquearbotonesGC(botongc, true);
            }
            else if (opcion == 2)
            {
                cn.actualizar(textbox, tabla, botongc, idApp, actual);
                IconButton[] botongc2 = {btnInsert, btnModificar, btnDelete, btnUpdate, btnConsultar, btnReporte, btnNext,
                btnBack,btnStart,btnEnd
                };
                bloqStart(botongc2);
                // cn.bloquearbotonesGC(botongc, true);
            }
            else if(opcion == 3)
            {
                DialogResult resultado = MessageBox.Show("Desea eliminar el Resgistro", "Eliminar", MessageBoxButtons.YesNo);
                if(resultado == DialogResult.Yes)
                {
                    
                    cn.delete(textbox, tabla, botongc, idApp, actual);
                    IconButton[] botongc2 = {btnInsert, btnModificar, btnDelete, btnUpdate, btnConsultar, btnReporte, btnNext,
                    btnBack,btnStart,btnEnd
                    };
                    bloqStart(botongc2);
                    //cn.bloquearbotonesGC(botongc, true);
                }
                else if(resultado == DialogResult.No)
                {

                    cn.limpiar(actual);
                    cn.desactivar(actual);
                    cn.llenartxt(textbox, tabla);
                    cn.bloquearbotonesGC(botongc, true);
                }
               
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cn.limpiar(actual);
            cn.desactivar(actual);
            cn.llenartxt(textbox, tabla);
            IconButton[] botongc = { btnSave, btnCancelar };
            cn.bloquearbotonesGC(botongc, true);
            opcion = 0;
            IconButton[] botongc2 = {btnInsert, btnModificar, btnDelete, btnUpdate, btnConsultar, btnReporte, btnNext,
                btnBack,btnStart,btnEnd
                };
            bloqStart(botongc2);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            cn.llenartablainicio(tabla.Tag.ToString(), tabla, textbox);
            cn.moverseIF(tabla, "i");
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Ayuda ayuda = new Ayuda();
            ayuda.Show();

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            consulta();
            cnseg.setBtitacora(idApp, "Consulta");
            



        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            cnseg.setBtitacora(idApp, "Reportes");
            Report();
            /*CapaVista.Consulta rp = new CapaVista.Consulta();
            rp.Show();*/
            //Reportes.Vista cr = new Reportes.Vista();
            /*
             * Form 'fcr' = new 'cr.BusquedaAvanzada';
             */
        }

        public void Report()
        {
            
            cn.reporte(idApp);

        }
    }
}
