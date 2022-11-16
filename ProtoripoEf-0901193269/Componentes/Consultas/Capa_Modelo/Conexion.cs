using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Capa_ModeloConsultas
{
    public class Conexion
    {
            //Clase de conexion --------------
            public OdbcConnection conexion()
            {
                //creacion de la conexion via ODBC
                OdbcConnection conn = new OdbcConnection("Dsn=Colchoneria");
                try
                {
                    conn.Open();
                }
                catch (OdbcException)
                {
                    Console.WriteLine("No Conectó");
                }
                return conn;
            }

            //metodo para cerrar la conexion
            public void desconexion(OdbcConnection conn)
            {
                try
                {
                    conn.Close();
                }
                catch (OdbcException)
                {
                    Console.WriteLine("No Conectó");
                }
            }
        }
}
