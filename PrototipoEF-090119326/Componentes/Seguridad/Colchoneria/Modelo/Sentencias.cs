using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelo_Seguridad
{
    public class Sentencias
    {
        Conexion con = new Conexion();

        public string[] queryLogin(string user)
        {
            string[] Campos = new string[300];
            string[] auto = new string[300];
            int i = 0;
            string datos = "pk_id_usuario, username_usuario, password_usuario";
            string sql = "SELECT " + datos + " FROM tbl_usuarios where username_usuario='" + user + "';";
            try
            {
                OdbcCommand command = new OdbcCommand(sql, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Campos[i] = reader.GetValue(0).ToString();
                    Campos[(i + 1)] = reader.GetValue(1).ToString();
                    Campos[(i + 2)] = reader.GetValue(2).ToString();
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en query hacia la tabla de usuarios"); }
            return Campos;
        }

        public string[] queryRecuperacion(string user)
        {
            string[] Campos = new string[300];
            string[] auto = new string[300];
            int i = 0;
            string datos = "pk_id_usuario, username_usuario, respuesta";
            string sql = "SELECT " + datos + " FROM tbl_usuarios where username_usuario='" + user + "';";
            try
            {
                OdbcCommand command = new OdbcCommand(sql, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Campos[i] = reader.GetValue(0).ToString();
                    Campos[(i + 1)] = reader.GetValue(1).ToString();
                    Campos[(i + 2)] = reader.GetValue(2).ToString();
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en query hacia la tabla de usuarios"); }
            return Campos;
        }






        public void insertBitacora(string values)
        {
            string campos = "fk_id_usuario, fk_id_aplicacion, fecha_bitacora, hora_bitacora, host_bitacora, ip_bitacora, accion_bitacora";
            string sql = "INSERT INTO tbl_bitacoraDeEventos (" + campos + ") values (" + values + ");";
            OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
            cmd.ExecuteNonQuery();
        }

        public string queryNombreApp(string app)
        {
            string nombreApp = "";
            string sql = "SELECT nombre_aplicacion FROM tbl_aplicaciones where pk_id_aplicacion='" + app + "';";
            try
            {
                OdbcCommand command = new OdbcCommand(sql, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    nombreApp = reader.GetValue(0).ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtener el nombre de la aplicación");
            }
            return nombreApp;
        }

        public int[] getPerfilesUsuario(string user)
        {
            int[] perfiles = new int[100];
            int i = 0;
            string sql = "SELECT fk_id_perfil FROM tbl_asignacionesPerfilsUsuario WHERE fk_id_usuario='" + user + "';";
            try
            {
                OdbcCommand command = new OdbcCommand(sql, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    perfiles[i] = int.Parse(reader.GetValue(0).ToString());
                    i++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtener el nombre de la aplicación");
            }

            return perfiles;
        }

        public int[] getPerfilAplicacion(int perfil)
        {
            int[] modulos = new int[300];
            int i = 0;
            string sql = "SELECT fk_id_aplicacion FROM tbl_permisosAplicacionPerfil WHERE fk_id_perfil='" + perfil + "';";
            try
            {
                OdbcCommand command = new OdbcCommand(sql, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    modulos[i] = int.Parse(reader.GetValue(0).ToString());
                    i++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtener las aplicaciones del perfil");
            }
            return modulos;
        }

        public Boolean getAuthPerfilAplicacion(int perfil, int idApp)
        {
            Boolean result = false;
            string sql = "SELECT fk_id_aplicacion FROM tbl_permisosAplicacionPerfil WHERE fk_id_perfil='" + perfil + "' AND fk_id_aplicacion='" + idApp + "';";
            try
            {
                OdbcCommand command = new OdbcCommand(sql, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (int.Parse(reader.GetValue(0).ToString()) == idApp)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtener las aplicaciones del perfil");
            }
            return result;
        }

        public int getModuloAplicacion(int aplicacion)
        {
            int idModulo = 0;
           // int i = 0;
            string sql = "SELECT fk_id_modulos FROM tbl_AsignacionModuloAplicacion where fk_id_aplicacion='" + aplicacion + "';";
            try
            {
                OdbcCommand command = new OdbcCommand(sql, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    idModulo = int.Parse(reader.GetValue(0).ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtener el modulo de la aplicacion #" + aplicacion);
            }

            return idModulo;
        }

        public int[] getPermisos(int perfil, int aplicacion)
        {
            int[] permisos = new int[5];
            int i = 0;
            string campos = "guardar_permiso, modificar_permiso, eliminar_permiso, buscar_permiso, imprimir_permiso";
            string sql = "SELECT " + campos + " FROM tbl_permisosAplicacionPerfil WHERE fk_id_perfil='" + perfil + "' AND fk_id_aplicacion='" + aplicacion + "';";
            try
            {
                OdbcCommand command = new OdbcCommand(sql, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    permisos[i] = int.Parse(reader.GetValue(0).ToString());
                    permisos[i + 1] = int.Parse(reader.GetValue(1).ToString());
                    permisos[i + 2] = int.Parse(reader.GetValue(2).ToString());
                    permisos[i + 3] = int.Parse(reader.GetValue(3).ToString());
                    permisos[i + 4] = int.Parse(reader.GetValue(4).ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtener las aplicaciones del perfil");
            }
            return permisos;
        }


        public OdbcDataAdapter buscarlogin(string tabla, string dato1, string dato2)
        {
            
            string sql = "SELECT usuario, contra FROM " + tabla + " where usuario='" +dato1+ "' and contra='" +dato2+"';" ;
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public void insertar(string dato, string tipo, string tabla)
        {
            string sql = "insert into " + tabla + "(" + tipo + ") values (" + dato + ")";
            try
            {
            
            OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
            cmd.ExecuteNonQuery(); 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtener");
            }
        }

        public void busqueda(TextBox[] textbox, string tabla,int num, string condicion)
        {
            string sql = "Select *from " + tabla + " where "+ condicion +" " + num+ ";" ;
            OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
            cmd.ExecuteNonQuery();
            

        }

        public string getPregunta(string username)
        {
            string pregunta = "";
            string sql = "SELECT pregunta FROM tbl_usuarios WHERE username_usuario='" + username + "';";
            try
            {
                OdbcCommand command = new OdbcCommand(sql, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    pregunta = reader.GetValue(0).ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtener");
            }
            return pregunta;
        }


        public string[] buscarusua(string username)
        {
            string[] permisos = new string[10];
            int i = 0;

            
            string sql = "SELECT pregunta FROM tbl_usuarios WHERE username_usuario='" + username + "';";

            try
            {
                OdbcCommand command = new OdbcCommand(sql, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    permisos[i] = reader["username_usuario"].ToString();
                    /*permisos[i + 1] = int.Parse(reader.GetValue(1).ToString());
                    permisos[i + 2] = int.Parse(reader.GetValue(2).ToString());
                    permisos[i + 3] = int.Parse(reader.GetValue(3).ToString());
                    permisos[i + 4] = int.Parse(reader.GetValue(4).ToString());
                    permisos[i + 5] = int.Parse(reader.GetValue(5).ToString());
                    permisos[i + 6] = int.Parse(reader.GetValue(6).ToString());*/
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtener las aplicaciones del perfil");
            }
            return permisos;


        }


        public OdbcDataAdapter llenarTbl(string tabla)// metodo  que obtinene el contenio de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT * FROM " + tabla + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }
       

        public void actualizar(string dato, string condicion, string tabla,int num)
        {

            string sql = "Update " + tabla + " " + dato + " where " + condicion + " " + num+ "; ";
            OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
            cmd.ExecuteNonQuery();

        }

        public void eliminar(string tabla,string condicion,int campo)
        {

            try{
                
                string sql = "delete from " + tabla + " where " + condicion + " " + campo + " ;";
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery(); }
                catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se puede eliminar por permisos asignados");
            }
        }

        public void eliminarAsiganaciones(string tabla, string condicion1, int campo1, string condicion2, int campo2)
        {
            try
            {

                string sql = "DELETE FROM " + tabla + " where (" + condicion1 + " = " + campo1 + ") and ("+ condicion2 + " =" + campo2 + ");";
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se puede eliminar por permisos asignados");
            }


        }



        public void actualizarcontra(string dato, string condicion, string tabla, string usu)
        {

            string sql = "Update " + tabla + " " + dato + " where " + condicion + " " +"'"+ usu +"'"+ "; ";
            OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
            cmd.ExecuteNonQuery();

        }


        public OdbcDataAdapter llenartabla(string tabla)
        {
            string sql = "select * from " + tabla + ";";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }

        public OdbcDataAdapter selectList(string tabla, string campo)
        {
            string sql = "select *from " + tabla + " where fk_id_usuario = " +campo+ ";";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public OdbcDataAdapter selectPerfilUsuario(string tabla, string campo)
        {
            string sql = "select *from tbl_permisosaplicacionesusuario where fk_id_usuario = " + campo + ";";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public OdbcDataAdapter llenarListaAplicaciones(string tabla)
        {
            string sql = "Select pk_id_aplicacion as ID, nombre_aplicacion as Nombre, descripcion_aplicacion as Descripcion from  " + tabla + ";";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }

        public OdbcDataAdapter llenarListaModulos(string tabla)
        {
            string sql = "select pk_id_modulos as Modulo, nombre_modulo as Nombre, descripcion_modulo as Descripcion from " + tabla + ";";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }

        public OdbcDataAdapter llenarListaUsuarios(string tabla)
        {
            string sql = "Select pk_id_usuario as ID, nombre_usuario as nombre, username_usuario as Usuario from " + tabla + ";";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }

        public OdbcDataAdapter llenarListaApliUsuario(string tabla,string id)
        {
            string sql = "Select *from "+ tabla + " where ID = "+ id + " ;";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }

        public OdbcDataAdapter llenarListaPerfiles(string tabla)
        {
            string sql = "Select pk_id_perfil as ID, nombre_perfil as Nombre, descripcion_perfil as Descripcion from  " + tabla + ";";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }

    }
}
