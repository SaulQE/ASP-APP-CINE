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
    public class FuncionBL
    {
        public void Insert(FuncionBE funcionBE)
        {
            using (SqlConnection sqlConn = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConn.Open();

                //Preparar SQL INSERT
                SqlCommand sqlCMD = sqlConn.CreateCommand();
                sqlCMD.CommandText = "insert into Funciones(PeliculaID,SalaID,FechaHora) " +
                                     "values(@peliculaID,@salaID,@fechaHora)";

                //Cargar parámetros
                sqlCMD.Parameters.AddWithValue("@peliculaID", funcionBE.peliculaID);
                sqlCMD.Parameters.AddWithValue("@salaID", funcionBE.salaID);
                sqlCMD.Parameters.AddWithValue("@fechaHora", funcionBE.fechaHora);

                //Ejecutar SQL Insert
                sqlCMD.ExecuteNonQuery();

                sqlConn.Close();
            }
        }

        public void Update(FuncionBE funcionBE)
        {
            using (SqlConnection sqlConn = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConn.Open();

                //Preparar SQL Update
                SqlCommand sqlCMD = sqlConn.CreateCommand();
                sqlCMD.CommandText = "update Funciones set PeliculaID=@PeliculaID,SalaID=@SalaID,FechaHora=@FechaHora " +
                                     "where funcionID=@funcionID";

                //Cargar parámetros
                sqlCMD.Parameters.AddWithValue("@PeliculaID", funcionBE.peliculaID);
                sqlCMD.Parameters.AddWithValue("@SalaID", funcionBE.salaID);
                sqlCMD.Parameters.AddWithValue("@FechaHora", funcionBE.fechaHora);
                sqlCMD.Parameters.AddWithValue("@funcionID", funcionBE.funcionID);

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
                sqlCMD.CommandText = "delete from Funciones where funcionID=@ID";

                //Cargar parámetros
                sqlCMD.Parameters.AddWithValue("@ID", ID);

                //Ejecutar SQL Delete
                sqlCMD.ExecuteNonQuery();

                sqlConn.Close();
            }
        }

        public FuncionBE FindById(int ID)
        {
            FuncionBE funcionBE = null;

            using (SqlConnection sqlConn = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConn.Open();

                //Preparar SQL Select
                SqlCommand sqlCMD = sqlConn.CreateCommand();
                sqlCMD.CommandText = "select * from Funciones where funcionID=@funcionID";

                //Cargar parámetros
                sqlCMD.Parameters.AddWithValue("@funcionID", ID);

                //Ejecutar SQL Delete
                SqlDataReader sqlDR = sqlCMD.ExecuteReader();

                //Verifica si hay filas encontradas
                if (sqlDR.Read())
                {
                    funcionBE = new FuncionBE();

                    funcionBE.funcionID = sqlDR.GetInt32(0);
                    funcionBE.peliculaID = sqlDR.GetInt32(1);
                    funcionBE.salaID = sqlDR.GetInt32(2);
                    funcionBE.fechaHora = sqlDR.GetDateTime(3);
                }

                sqlConn.Close();
            }

            return funcionBE;
        }

        public DataTable FindAll_DataTable()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection sqlConn = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConn.Open();

                string SQL = "select * from VistaFunciones";

                SqlDataAdapter sqlDA = new SqlDataAdapter(SQL, sqlConn);
                sqlDA.Fill(dataTable);

                sqlConn.Close();
            }
            return dataTable;
        }

        public DataTable FindAll(string pelicula)
        {
            DataTable dt = new DataTable();

            using (SqlConnection sqlConn = new SqlConnection(ConnectionDB.SQLServer()))
            {
                //Preparar SQL Select
                string query = "select * from VistaFunciones where TituloPelicula=@pelicula";

                SqlDataAdapter da = new SqlDataAdapter(query, sqlConn);
                da.SelectCommand.Parameters.AddWithValue("@pelicula", pelicula);

                //Ejecutar SQL Select y llenar DataTable
                da.Fill(dt);
            }

            return dt;
        }

    }
}
