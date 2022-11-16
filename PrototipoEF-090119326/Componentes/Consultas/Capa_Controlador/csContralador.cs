using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_ModeloConsultas;
using System.Data.Odbc;
using System.Data;
using System.Windows.Forms;

namespace Capa_ControladorConsultas 
{
    public class csControldor
    {
        Sentencias sn = new Sentencias();
        //rellena tabla controlador

        //datagread
        public DataTable llenartb2()
        {
            string consulta = "select * from tbl_consultainteligente";
            OdbcDataAdapter dt = sn.llenartb2(consulta);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        public DataTable llenartb3(string condicion)
        {
            string consulta = "select * from tbl_consultainteligente where nombre_consulta= " + '"' + condicion + '"';
            OdbcDataAdapter dt = sn.llenartb2(consulta);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }


        public void ejecutarconsulta(string condicion)
        {
            string sql = "DELETE FROM tbl_consultainteligente where nombre_consulta = " + '"' + condicion + '"' + ";";
            Console.WriteLine(sql);
            sn.insertarconsulta(sql);
        }

        public void editarconsulta(string nombre_consulta, string tabla_consulta, string campos_consulta, string alias_consulta)
        {
            string sql = "update" +
                " tbl_consultainteligente set tabla ='" + tabla_consulta + "'" + "'campos ='"+ campos_consulta + "'alias ='" + alias_consulta + "where nombre = '" + nombre_consulta + "'";
            Console.WriteLine(sql);
            sn.insertarconsulta(sql);
        }

        //Josue Amaya
        public DataTable BuscarBA(string tableN, DataTable dt)
        {
            OdbcConnection con = new OdbcConnection("Dsn=Colchoneria");
            try
            {
                con.Open();
                string cadena = " SELECT  * FROM " + tableN;
                OdbcDataAdapter datos = new OdbcDataAdapter(cadena, con);
                datos.Fill(dt);
            }
            catch
            {
            }
            con.Close();
            return dt;
        }

        public void editarconsulta1(string operador_consulta, string campos_consultas, string valor_consultas, string PkId)
        {
            string sql = "update" +
                " tbl_consultainteligente1 set operador ='" + operador_consulta + "'" + "'campos ='" + campos_consultas + "'valor ='" + valor_consultas + "where id = '" + PkId + "'";
            Console.WriteLine(sql);
            sn.insertarconsulta(sql);
        }

        public void editarconsulta2(string ordernar_consulta, string campo_consulta)
        {
            string sql = "update" +
                " tbl_consultainteligente2 set ordernar ='" + ordernar_consulta + "'" + "'campos ='" + campo_consulta;           
            Console.WriteLine(sql);
            sn.insertarconsulta(sql);
        }

        public void editarconsulta3(string campoeditar_consulta, string valoreditar_consulta)
        {
            string sql = "update" +
                " tbl_consultainteligente3 set campo ='" + campoeditar_consulta + "'" + "'valor ='" + valoreditar_consulta; 
            Console.WriteLine(sql);
            sn.insertarconsulta(sql);
        }


        //jonathan Xuya 
        OdbcConnection con = new OdbcConnection("FIL=MS Acces;DSN=colchoneria");
        public bool InsertBusqueda(string _nomb, string _cons, string _area, string _camp, string _cadena, string _IDE)
        {
            using (con)
            {
                OdbcCommand cmd = new OdbcCommand();
                con.Open();
                cmd.Connection = con;

                #region Query
                String query = @"INSERT INTO tbl_consultainteligente
                (nombre_consulta,tabla_consulta,campos_consultas,alias_consultas,cadena_consultas,  Pk_Id) VALUE(?,?,?,?,?,?);";
                #endregion
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;

                cmd.Parameters.Add("@nombre_consulta", OdbcType.VarChar).Value = _nomb;
                cmd.Parameters.Add("@tabla_consulta", OdbcType.VarChar).Value = _cons;
                cmd.Parameters.Add("@campos_consultas", OdbcType.VarChar).Value = _area;
                cmd.Parameters.Add("@alias_consultas", OdbcType.VarChar).Value = _camp;
                cmd.Parameters.Add("@cadena_consultas", OdbcType.VarChar).Value = _cadena;
                cmd.Parameters.Add("@Pk_Id", OdbcType.Int).Value = _IDE;


                cmd.ExecuteNonQuery();
                con.Close();
            }
            return true;
        }

        //Josue Amaya
        public DataTable BuscarPor(string datobuscar, string buscaren, string tableN, DataTable dt, Label lbl_cadena)
        {
            OdbcConnection con = new OdbcConnection("Dsn=Colchoneria");
            if (string.IsNullOrEmpty(datobuscar))
            {
                String textalert = " El campo buscar, se encuentra vacio ";
                MessageBox.Show(textalert);
            }
            else
            {
                try
                {

                    String cadenaB = "";
                    con.Open();
                    cadenaB = " SELECT * FROM " + tableN + " WHERE " + buscaren + " LIKE ('%" + datobuscar.Trim() + "%')";
                    lbl_cadena.Text = "Buscando : " + datobuscar + " En Columna : " + buscaren;
                    OdbcDataAdapter datos = new OdbcDataAdapter(cadenaB, con);
                    datos.Fill(dt);
                    OdbcCommand comando = new OdbcCommand(cadenaB, con);
                    OdbcDataReader leer;
                    leer = comando.ExecuteReader();

                }
                catch
                {
                    String textalert = " El dato : " + datobuscar + " No se encuentra en la Columna : " + buscaren;
                    MessageBox.Show(textalert);
                }

                con.Close();
            }
            return dt;
        }

        public bool InsertBusquedaCompleja(string _ope, string _camp, string _valo, string _IDE)
        {

            using (con)
            {
                OdbcCommand cmda = new OdbcCommand();
                con.Open();
                cmda.Connection = con;

                #region Query


                String query = @"INSERT INTO tbl_consultainteligente1 (operador_consulta,campos_consulta,valor_consultas,PkId) VALUE(?,?,?,?);";

                #endregion
                cmda.CommandType = CommandType.Text;
                cmda.CommandText = query;
                cmda.Parameters.Add("@operador_consulta", OdbcType.VarChar).Value = _ope;
                cmda.Parameters.Add("@campos_consulta", OdbcType.VarChar).Value = _camp;
                cmda.Parameters.Add("@valor_consultas", OdbcType.VarChar).Value = _valo;
                cmda.Parameters.Add("@PkId", OdbcType.Int).Value = _IDE;


                cmda.ExecuteNonQuery();
                con.Close();
            }
            return true;
        }
        public bool InsertBusquedaCompleja1(string _camp, string _IDE ,string _ope )
        {
            using (con)
            {
                OdbcCommand cmd = new OdbcCommand();
                con.Open();
                cmd.Connection = con;

                #region Query
                String query = @"INSERT INTO tbl_consultainteligente2 (ordenar_consulta, campo_consulta,PkId) VALUE(?,?,?);";
                #endregion
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;                
                cmd.Parameters.Add("@ordenar_consulta", OdbcType.VarChar).Value = _camp;
                cmd.Parameters.Add("@campo_consulta", OdbcType.VarChar).Value = _IDE;
                cmd.Parameters.Add("@PkId", OdbcType.Int).Value = _ope;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            return true;
        }
        public DataTable Nconsultas(DataTable dt2)
        {
            OdbcConnection conx = new OdbcConnection("Dsn = Colchoneria");
            try
            {
                conx.Open();
                OdbcCommand comand = new OdbcCommand();
                comand.Connection = conx;
                comand.CommandType = CommandType.Text;
                string cadena = "SELECT nombre_consulta FROM tbl_consultainteligente";
                comand.CommandText = cadena;
                OdbcDataAdapter datos = new OdbcDataAdapter(comand);
                datos.Fill(dt2);
                conx.Close();
            }
            catch
            {

            }
            return (dt2);
        }

        

    }
}

