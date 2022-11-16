using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Capa_ModeloConsultas
{
    public class Sentencias
    {

        Conexion con = new Conexion();

        public OdbcDataAdapter llenartb1(string tabla) 
        {
            string sql = tabla;
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }
        public OdbcDataReader llenarcbotabla(string sql)
        {
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, con.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }
        public void insertarconsulta(string cadena)
        {
            try
            {
                OdbcCommand consulta = new OdbcCommand(cadena, con.conexion());
                consulta.ExecuteNonQuery();
            }
            catch (Exception Error)
            {
                Console.WriteLine("Error en modelo" + Error);
            }
        }
        public OdbcDataReader validarconsulta(string sql)
        {
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, con.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }
        public OdbcDataAdapter llenartb2(string sql)         {
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }
        public OdbcDataReader llenarcbonombreconsulta(string sql)
        {
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, con.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }
    }
}




