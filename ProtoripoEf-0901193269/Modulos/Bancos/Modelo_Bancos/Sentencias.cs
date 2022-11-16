using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
namespace Modelo_Bancos
{
    public class Sentencias
    {
        Conexion con = new Conexion();


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


        public void eliminar(string tabla, string condicion, int campo)
        {

            try
            {

                string sql = "delete from " + tabla + " where " + condicion + " " + campo + " ;";
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se puede eliminar por permisos asignados");
            }


        }

        public OdbcDataAdapter llenartabla(string tabla)
        {


            string sql = "select * from " + tabla + ";";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());

            return datatable;
        }
        public OdbcDataAdapter bitacoras(string tabla)
        {


            string sql = "select * from " + tabla + " where fk_id_aplicacion between 7000 and 7999;";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());

            return datatable;
        }
        public OdbcDataAdapter disponibilidads(string tabla)
        {


            string sql = "select nombre_banco,Nombre_cta,TCargos_montbancario,TAbonos_montbancario,SActual_montbancario from " + tabla 
                + " inner join Tbl_bancos on fk_bancos = Pk_idbancos;";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());

            return datatable;
        }

    }
}
