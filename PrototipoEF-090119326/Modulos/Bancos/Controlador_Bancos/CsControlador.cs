using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo_Bancos;
using System.Data.Odbc;
using System.Data;
using System.Windows.Forms;

namespace Controlador_Bancos
{
    
   public  class CsControlador
    {
        Sentencias sn = new Sentencias();

        public void ingresar(TextBox[] textbox, string tabla)
        {
            string dato = " ";
            string tipo = " ";

            for (int x = 0; x < textbox.Length; x++)
            {

                if (x == textbox.Length - 1)
                {
                    dato += "'" + textbox[x].Text + "'";
                    tipo += textbox[x].Tag.ToString();
                }
                else
                {
                    dato += "'" + textbox[x].Text + "',";
                    tipo += textbox[x].Tag.ToString() + ",";
                }

            }
            sn.insertar(dato, tipo, tabla);
        }
        public void eliminar(string tabla, string condicion, int campo)
        {
            try
            {
                sn.eliminar(tabla, condicion, campo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se elimino");
                Console.WriteLine(ex.Message.ToString() + " \nNo se puede eliminar por permisos asignados");
            }


        }

        public void llenartablaa(string ntabla, DataGridView tabla)//Funcion para llenar tabla
        {
            try
            {
                OdbcDataAdapter dt = sn.llenartabla(ntabla);
                DataTable table = new DataTable();
                dt.Fill(table);
                tabla.DataSource = table;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }



        }
        public void bitacora(string ntabla, DataGridView tabla)//Funcion para llenar tabla
        {
            try
            {
                OdbcDataAdapter dt = sn.bitacoras(ntabla);
                DataTable table = new DataTable();
                dt.Fill(table);
                tabla.DataSource = table;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }

        }
        public void disponibilidad(string ntabla, DataGridView tabla)//Funcion para llenar tabla
        {
            try
            {
                OdbcDataAdapter dt = sn.disponibilidads(ntabla);
                DataTable table = new DataTable();
                dt.Fill(table);
                tabla.DataSource = table;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }

        }


    }
}
