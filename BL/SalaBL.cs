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
    public class SalaBL
    {
        public void Insert(SalaBE salaBE)
        {
            using (SqlConnection sqlConn = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConn.Open();

                //Preparar SQL INSERT
                SqlCommand sqlCMD = sqlConn.CreateCommand();
                sqlCMD.CommandText = "insert into Salas(NombreSala,Capacidad) " +
                                     "values(@NombreSala,@Capacidad)";

                //Cargar parámetros
                sqlCMD.Parameters.AddWithValue("@NombreSala", salaBE.nomSala);
                sqlCMD.Parameters.AddWithValue("@Capacidad", salaBE.capacidad);

                //Ejecutar SQL Insert
                sqlCMD.ExecuteNonQuery();

                sqlConn.Close();
            }
        }

        public void Update(SalaBE salaBE)
        {
            using (SqlConnection sqlConn = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConn.Open();

                //Preparar SQL Update
                SqlCommand sqlCMD = sqlConn.CreateCommand();
                sqlCMD.CommandText = "update Salas set NombreSala=@NombreSala,Capacidad=@Capacidad " +
                                     "where salaID=@salaID";

                //Cargar parámetros
                sqlCMD.Parameters.AddWithValue("@NombreSala", salaBE.nomSala);
                sqlCMD.Parameters.AddWithValue("@Capacidad", salaBE.capacidad);
                sqlCMD.Parameters.AddWithValue("@salaID", salaBE.salaID);

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
                sqlCMD.CommandText = "delete from Salas where salaID=@ID";

                //Cargar parámetros
                sqlCMD.Parameters.AddWithValue("@ID", ID);

                //Ejecutar SQL Delete
                sqlCMD.ExecuteNonQuery();

                sqlConn.Close();
            }
        }

        public SalaBE FindById(int ID)
        {
            SalaBE salaBE = null;

            using (SqlConnection sqlConn = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConn.Open();

                //Preparar SQL Select
                SqlCommand sqlCMD = sqlConn.CreateCommand();
                sqlCMD.CommandText = "select * from Salas where salaID=@ID";

                //Cargar parámetros
                sqlCMD.Parameters.AddWithValue("@ID", ID);

                //Ejecutar SQL Delete
                SqlDataReader sqlDR = sqlCMD.ExecuteReader();

                //Verifica si hay filas encontradas
                if (sqlDR.Read())
                {
                    salaBE = new SalaBE();

                    salaBE.salaID = sqlDR.GetInt32(0);
                    salaBE.nomSala = sqlDR.GetString(1);
                    salaBE.capacidad = sqlDR.GetInt32(2);
                }
                sqlConn.Close();
            }
            return salaBE;
        }

        public DataTable FindAll()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection sqlConn = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConn.Open();

                string SQL = "select * from Salas";

                SqlDataAdapter sqlDA = new SqlDataAdapter(SQL, sqlConn);
                sqlDA.Fill(dataTable);

                sqlConn.Close();
            }
            return dataTable;
        }

    }
}
