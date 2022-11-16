using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.Odbc;
using FontAwesome.Sharp;
using NavegadorModelo;

namespace NavegadorControlador
{
 
    public class csControlador
    {
        Sentencias sn = new Sentencias();
        
        Seguridad_Controlador.Controlador cnseg = new Seguridad_Controlador.Controlador();

        int next, mov;

        
       
        public void llenartablaa(string ntabla, DataGridView tabla)//Funcion para llenar tabla
        {
            try
            {
                OdbcDataAdapter dt = sn.llenartabla(ntabla);
                DataTable table = new DataTable();
                dt.Fill(table);
                tabla.DataSource = table;
            }
           catch(Exception e)
            {
                MessageBox.Show("Error:" +e);
            }
            


        }

        public int buscarposicion(DataGridView tabla)
        {
            int posicionamiento = 0;
            try
            {
                posicionamiento = tabla.CurrentRow.Index;
            }

            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }
            return posicionamiento;
        }
        public void llenartablainicio(string ntabla, DataGridView tabla, TextBox[] textbox)//Funcion para llenar tabla
        {
            try
            {
                int permiso = comprobacionvacio(tabla);

                if(permiso != 0)
                {
                    OdbcDataAdapter dt = sn.llenartabla(ntabla);
                    DataTable table = new DataTable();
                    dt.Fill(table);
                    tabla.DataSource = table;


                    for (int x = 0; x < table.Columns.Count; x++)
                    {

                        textbox[x].Text = table.Rows[0][x].ToString();

                    }
                }
                else
                {
                    OdbcDataAdapter dt = sn.llenartabla(ntabla);
                    DataTable table = new DataTable();
                    dt.Fill(table);
                    tabla.DataSource = table;
                }

                
            }

            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }
        }
        public void llenartabla5(string ntabla, DataGridView tabla, TextBox[] textbox, int posicion)//Funcion para llenar tabla
        {
            try
            {
                OdbcDataAdapter dt = sn.llenartabla(ntabla);
                DataTable table = new DataTable();
                dt.Fill(table);
                
                
                for (int x = 0; x < table.Columns.Count; x++)
                {
                    textbox[x].Text = table.Rows[posicion][x].ToString();
                    textbox[x].Enabled = false;


                }
            }

            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }
        }
        public void llenartxt(TextBox[] textbox, DataGridView tabla)//Llena los textbox con datos del datagriedview

        {
            try
            {
                int permiso = comprobacionvacio(tabla);
                if(permiso != 0)
                {
                    for (int x = 0; x < tabla.ColumnCount; x++)
                    {
                        textbox[x].Text = tabla.CurrentRow.Cells[x].Value.ToString();


                    }
                }
                else
                {

                }
               

            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }


        }



        public void limpiar(Control control)// limpia Componentes
        {
            try
            {
                foreach (var txt in control.Controls)
                {
                    if (txt is TextBox)
                    {
                        ((TextBox)txt).Clear();
                    }
                    else if (txt is ComboBox)
                    {
                        ((ComboBox)txt).SelectedItem = 0;
                    }
                    else if (txt is CheckBox)
                    {
                        ((CheckBox)txt).Checked = false;
                    }
                }
            }
            

            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }
        }

        public void activar(Control control)// Activa componentes
        {
            try
            {
                foreach (var txt in control.Controls)
                {
                    if (txt is TextBox)
                    {
                        ((TextBox)txt).Enabled = true;
                    }
                    else if (txt is ComboBox)
                    {
                        ((ComboBox)txt).Enabled = true;
                    }
                    else if (txt is CheckBox)
                    {
                        ((CheckBox)txt).Enabled = true;
                    }
                    else if (txt is DateTimePicker)
                    {
                        ((DateTimePicker)txt).Enabled = true;
                    }
                }
            }
            

            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }
        }


        public void desactivar(Control control)//Desactiva componentes
        {
            try
            {
                foreach (var txt in control.Controls)
                {
                    if (txt is TextBox)
                    {
                        ((TextBox)txt).Enabled = false;
                    }
                    else if (txt is ComboBox)
                    {
                        ((ComboBox)txt).Enabled = false;
                    }
                    else if (txt is CheckBox)
                    {
                        ((CheckBox)txt).Enabled = false;
                    }
                    else if (txt is DateTimePicker)
                    {
                        ((DateTimePicker)txt).Enabled = false;
                    }
                }
            }
            
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }
        }

        public void enfocar(TextBox[] textbox)//desabilita el primer textbox y enfoca el segundo
        {
            try
            {
                textbox[0].Enabled = false;
                textbox[1].Focus();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }
            
        }

        
         public void moverseIF(DataGridView tabla, string mover)//Metodo para moverse al inicio, final, siguiente, anterior
        {
            try
            {
                int permiso = comprobacionvacio(tabla);
                if(permiso != 0)
                {
                    int fin = (tabla.Rows.Count - 2); ;
                    int posicion;

                    if (mover.Equals("i"))
                    {
                        posicion = 0;
                        tabla.CurrentCell = tabla.Rows[posicion].Cells[tabla.CurrentCell.ColumnIndex];

                    }
                    else if (mover.Equals("f"))
                    {
                        posicion = fin;
                        tabla.CurrentCell = tabla.Rows[posicion].Cells[tabla.CurrentCell.ColumnIndex];

                    }
                    else if (mover.Equals("b"))
                    {
                        mov = tabla.CurrentRow.Index - 1;
                        if (mov >= 0)
                        {
                            tabla.CurrentCell = tabla.Rows[mov].Cells[tabla.CurrentCell.ColumnIndex];

                        }


                    }
                    else if (mover.Equals("s"))
                    {
                        next = tabla.CurrentRow.Index + 1;
                        if (next < tabla.Rows.Count - 1)
                        {
                            tabla.CurrentCell = tabla.Rows[next].Cells[tabla.CurrentCell.ColumnIndex];

                        }
                    }
                }
                
            }
            catch(Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
            


        }

      
        public void delete(TextBox[] textbox, DataGridView tabla, IconButton[] botones, string idApp, Control control)
        {
            try
            {
                int permiso = comprobacionvacio(tabla);
                if(permiso != 0)
                {
                    string campo = textbox[0].Tag.ToString();
                    int clave = int.Parse(textbox[0].Text);

                    sn.eliminar(clave, campo, tabla.Tag.ToString());
                    cnseg.setBtitacora(idApp, "Eliminar");
                    MessageBox.Show("Dato Eliminado");
                    bloquearbotonesGC(botones, true);
                    desactivar(control);
                    /*for (int x = 0; x < textbox.Length; x++)
                    {
                        textbox[x].Enabled = false;


                    }*/
                }
                
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }

            
               
        }
        public void ingresar(TextBox[] textbox, DataGridView tabla, IconButton[] botones, String idApp, Control control)//Crea cadenas de datos para la insercion
        {   
            try
            {   
                string autorizazcion = evaluarcampos(textbox);


                if (autorizazcion == "si")
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

                    sn.insertar(dato, tipo, tabla.Tag.ToString());
                    
                    cnseg.setBtitacora(idApp, "Guardar");
                    MessageBox.Show("Dato Insertado");
                    bloquearbotonesGC(botones, true);
                    desactivar(control);
                    /*for (int x = 0; x < textbox.Length; x++)
                    {
                        textbox[x].Enabled = false;
                    }*/

                }
                else if (autorizazcion == "no")
                {

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
            
           
            


        }


        public void crearid(TextBox[] textbox, DataGridView tabla)//Crea el id siguiente a ingresar
        {
            try
            {
                int incremento = 0;
                textbox[0].Enabled = false;
                textbox[1].Focus();
                int permiso = comprobacionvacio(tabla);
                if(permiso != 0)
                {
                    string resultado = sn.buscarid(tabla.Tag.ToString(), textbox[0].Tag.ToString());
                    incremento = Convert.ToInt32(resultado) + 1;
                    textbox[0].Text = incremento.ToString();
                }
                else
                {
                    incremento =  1;
                    textbox[0].Text = incremento.ToString();
                }
               
                

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
            

            
        }

        public void actualizar(TextBox[] textbox, DataGridView tabla, IconButton[] botones, string idApp, Control control)//Crea cadenas de datos para la actualizacion
        {
            try
            {
                int permiso = comprobacionvacio(tabla);

                if(permiso != 0)
                {
                    string autorizazcion = evaluarcampos(textbox);
                    bool comporbar = comprobaractualizacion(tabla, textbox);

                    if (autorizazcion == "no" && comporbar == false)
                    {



                    }
                    else if (autorizazcion == "si" && comporbar == true)
                    {
                        string dato = " ";
                        string condicion = "(" + textbox[0].Tag.ToString() + " = '" + textbox[0].Text + "')";

                        for (int x = 1; x < textbox.Length; x++)
                        {

                            if (x == textbox.Length - 1)
                            {
                                dato += " " + textbox[x].Tag.ToString() + " = '" + textbox[x].Text + "' ";

                            }
                            else if (x == 1)
                            {
                                dato += "SET " + textbox[x].Tag.ToString() + " = '" + textbox[x].Text + "', ";

                            }
                            else
                            {
                                dato += " " + textbox[x].Tag.ToString() + " = '" + textbox[x].Text + "', ";

                            }

                        }

                        sn.actualizar(dato, condicion, tabla.Tag.ToString());
                        cnseg.setBtitacora(idApp, "Modificar");
                        MessageBox.Show("Dato actualizado");
                        bloquearbotonesGC(botones, true);
                        desactivar(control);
                        /*for (int x = 0; x < textbox.Length; x++)
                        {
                            textbox[x].Enabled = false;
                        }*/
                    }

                


                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
            


        }

        public void bloquearbotonesGC(IconButton[] boton, bool bloqueo)//bloquea botones  guardar y cancelar
        {
            try
            {
                if(bloqueo == true)//si es true bloquea botones
                {
                    boton[0].Enabled = false;
                    boton[1].Enabled = false;
                }
               else if(bloqueo == false)//si es true desbloquea botones
                {
                    boton[0].Enabled = true;
                    boton[1].Enabled = true;
                }

                
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
            
        }
        
        string evaluarcampos(TextBox[] textbox)//metodo para evaluar campos vacios
        {
            string autorizacion = " ";
            try
            {
                for (int x = 0; x < textbox.Length; x++)
                {
                    if (textbox[x].Text.Length == 0)
                    {
                        MessageBox.Show("Por favor llenar el campo: " + textbox[x].Tag.ToString());
                        autorizacion = "no";
                        break;

                    }
                    else if (textbox[x].Text.Length != 0)
                    {
                        autorizacion = "si";
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
           
            

            return autorizacion;
        }

       public void evaluartags(TextBox[] textbox, DataGridView tabla, string BD)//Metodo para evaluar los tags
        {

            try
            {
                OdbcDataAdapter dt = sn.buscarnombretabla2(tabla.Tag.ToString(), textbox.Length, BD);
                DataTable table = new DataTable();
                dt.Fill(table);
                string[] datos = new string[textbox.Length];
                for(int x = 0; x< textbox.Length; x++)
                {
                    datos[x] = textbox[x].Tag.ToString();
                }

                Array.Sort(datos);
               
                for (int x = 0; x < textbox.Length; x++)
                {

                    if (datos[x] != table.Rows[x][0].ToString())
                    {
                        string mensaje = "Por favor Verificar el nombre de la columna: " + table.Rows[x][0].ToString();
                        MessageBox.Show(mensaje, " Error Campo  ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                            Application.Exit();
                            break;
                        
                    }
                    else
                    {
                        //MessageBox.Show(datos[x]);
                    }
                }
            }
            catch (Exception e)
            {
               
            }

            


         }
        
            bool comprobaractualizacion (DataGridView tabla, TextBox[] textbox)
        {
            bool permiso = false;
            try
            {
                
                int conteo = 0;
                string[] datos = new string[textbox.Length];
                datos = sn.comprobaciondellenado(tabla.Tag.ToString(), textbox[0].Tag.ToString(), textbox[0].Text, textbox.Length);

                for (int x = 0; x < textbox.Length; x++)
                {
                    if (datos[x].Equals(textbox[x].Text))
                    {
                        conteo += 1;
                    }
                }

                if (conteo.Equals(textbox.Length))
                {
                    permiso = false;
                    MessageBox.Show("No ha realizado ninguna modificación");

                }
                else
                {
                    permiso = true;

                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
            

            return permiso;
        }

        
        public void inicializargrid (DataGridView tabla)
        {
            tabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void evaluartabla(DataGridView tabla)//Metodo para evaluar el nombre de la tabla
        {

            try
            {
                OdbcDataAdapter dt = sn.buscarnombretabla();
                DataTable table = new DataTable();
                dt.Fill(table);

                int conteo = 0;

                for (int x = 0; x < table.Rows.Count; x++)
                {

                    if (tabla.Tag.ToString() != table.Rows[x][0].ToString())
                    {
                         conteo += 1;
                    }
                    
                }
                if(conteo == table.Rows.Count)
                {
                    string mensaje = "La tabla: " + tabla.Tag.ToString() + " no aparece en la Base de datos ";
                    MessageBox.Show(mensaje," Error Tabla ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }

        }

        public int comprobacionvacio(DataGridView tabla)
        {
            int resultado = 0;
            resultado = sn.estadotabla(tabla.Tag.ToString());

            return resultado;
        }
     
        /*
        public void bloqueobtn(IconButton[] boton)//Metodo para evaluar el nombre de la tabla
        {
            string[] seguridad = new string[7];
            seguridad = sn.buscarseguridad(8,2000);
            int [] evaluacion = new int [7];
            

            try
            { 
                for (int x = 0; x < 7; x++)
                {
                    evaluacion[x] = Convert.ToInt32(seguridad[x]);
                    if (evaluacion[x] == 0)
                    {
                        boton[x-2].Enabled = false;



                    }
                }




            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
        }*/

        public void reporte(string id1)
        {
            
                string ubicacion1 = "";
                string estado1 = "";
                estado1 = sn.reporteestado(id1);
                ubicacion1 = sn.reporteestado1(id1);
            if (estado1 == "Visible")
            {
               /*CapaVistaReporteria.visualizar b = new CapaVistaReporteria.visualizar(ubicacion1);
                b.Show();*/
            }
            else if(ubicacion1=="") {
                MessageBox.Show("No se encuentra guardado el reporte de la aplicación =  " + id1);
            }
            else
            {
                MessageBox.Show("No esta habilitado el reporte");
            }
                               
                
               
            
           
        }

     }
}
