using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BE;
using DB;

//Libreria exclusiva para trabajar con SQLserver
using System.Data.SqlClient;
using System.Data;

namespace BL
{
    public class PeliculaBL
    {
        public void Insert(PeliculaBE peliculaBE)
        {
            using (SqlConnection sqlConn = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConn.Open();

                //Preparar SQL INSERT
                SqlCommand sqlCMD = sqlConn.CreateCommand();
                sqlCMD.CommandText = "insert into Peliculas(Titulo,Director,DuracionMinutos,Clasificacion) " +
                                     "values(@Titulo,@Director,@DuracionMinutos,@Clasificacion)";

                //Cargar parámetros
                sqlCMD.Parameters.AddWithValue("@Titulo", peliculaBE.titulo);
                sqlCMD.Parameters.AddWithValue("@Director", peliculaBE.director);
                sqlCMD.Parameters.AddWithValue("@DuracionMinutos", peliculaBE.durMInutos);
                sqlCMD.Parameters.AddWithValue("@Clasificacion", peliculaBE.clasificacion);

                //Ejecutar SQL Insert
                sqlCMD.ExecuteNonQuery();

                sqlConn.Close();
            }
        }

        public void Update(PeliculaBE peliculaBE)
        {
            using (SqlConnection sqlConn = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConn.Open();

                //Preparar SQL Update
                SqlCommand sqlCMD = sqlConn.CreateCommand();
                sqlCMD.CommandText = "update Peliculas set Titulo=@Titulo,Director=@Director,DuracionMinutos=@DuracionMinutos,Clasificacion=@Clasificacion " +
                                     "where PeliculaID=@PeliculaID";

                //Cargar parámetros
                sqlCMD.Parameters.AddWithValue("@Titulo", peliculaBE.titulo);
                sqlCMD.Parameters.AddWithValue("@Director", peliculaBE.director);
                sqlCMD.Parameters.AddWithValue("@DuracionMinutos", peliculaBE.durMInutos);
                sqlCMD.Parameters.AddWithValue("@Clasificacion", peliculaBE.clasificacion);
                sqlCMD.Parameters.AddWithValue("@PeliculaID", peliculaBE.peliculaID);

                //Ejecutar SQL Update
                sqlCMD.ExecuteNonQuery();

                sqlConn.Close();
            }
        }

        public void Delete(int ID)
        {
            using (SqlConnection sqlConn = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConn.Open();

                //Preparar SQL Update
                SqlCommand sqlCMD = sqlConn.CreateCommand();
                sqlCMD.CommandText = "delete from Peliculas where PeliculaID=@PeliculaID";

                //Cargar parámetros
                sqlCMD.Parameters.AddWithValue("@PeliculaID", ID);

                //Ejecutar SQL Delete
                sqlCMD.ExecuteNonQuery();

                sqlConn.Close();
            }
        }

        public PeliculaBE FindById(int ID)
        {
            PeliculaBE peliculaBE = null;

            using (SqlConnection sqlConn = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConn.Open();

                //Preparar SQL Select
                SqlCommand sqlCMD = sqlConn.CreateCommand();
                sqlCMD.CommandText = "select * from Peliculas where PeliculaID=@ID";

                //Cargar parámetros
                sqlCMD.Parameters.AddWithValue("@ID", ID);

                //Ejecutar SQL Delete
                SqlDataReader sqlDR = sqlCMD.ExecuteReader();

                //Verifica si hay filas encontradas
                if (sqlDR.Read())
                {
                    peliculaBE = new PeliculaBE();

                    peliculaBE.peliculaID = sqlDR.GetInt32(0);
                    peliculaBE.titulo = sqlDR.GetString(1);
                    peliculaBE.director = sqlDR.GetString(2);
                    peliculaBE.durMInutos = sqlDR.GetInt32(3);
                    peliculaBE.clasificacion = sqlDR.GetString(4);
                }

                sqlConn.Close();
            }
            return peliculaBE;
        }

        public DataTable FindAll()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection sqlConn = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConn.Open();

                string SQL = "select * from Peliculas";

                SqlDataAdapter sqlDA = new SqlDataAdapter(SQL, sqlConn);
                sqlDA.Fill(dataTable);

                sqlConn.Close();
            }
            return dataTable;
        }


        //public List<PeliculaBE> FindAll()
        //{
        //    List<PeliculaBE> peliculaList = new List<PeliculaBE>();

        //    using (SqlConnection sqlConn = new SqlConnection(ConnectionDB.SQLServer()))
        //    {
        //        sqlConn.Open();

        //        //Preparar SQL Select
        //        SqlCommand sqlCMD = sqlConn.CreateCommand();
        //        sqlCMD.CommandText = "select * from Peliculas order by PeliculaID";

        //        //Ejecutar SQL Select
        //        SqlDataReader sqlDR = sqlCMD.ExecuteReader();

        //        //Verifica si hay filas encontradas
        //        while (sqlDR.Read())
        //        {
        //            PeliculaBE peliculaBE = new PeliculaBE();

        //            peliculaBE.peliculaID = sqlDR.GetInt32(0);
        //            peliculaBE.titulo = sqlDR.GetString(1);

        //            peliculaList.Add(peliculaBE);
        //        }

        //        sqlConn.Close();
        //    }

        //    return peliculaList;
        //}

    }
}
