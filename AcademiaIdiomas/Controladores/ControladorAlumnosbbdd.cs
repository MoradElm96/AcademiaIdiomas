using AcademiaIdiomas.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaIdiomas.Controladores
{
    public class ControladorAlumnosbbdd
    {
        string cadenaConexion = ConfigurationManager.ConnectionStrings["2damConnectionString"].ConnectionString;

        public List<Alumno> cargarDatos()
        {
            List<Alumno> listaAlumnos = new List<Alumno>();
            try
            {
                    MySqlConnection cnn = new MySqlConnection(cadenaConexion);
                    cnn.Open();
                    MySqlCommand comando = cnn.CreateCommand();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "SELECT * FROM Alumnos";
                    MySqlDataReader dataReader = comando.ExecuteReader();
                    while (dataReader.Read())
                    {
                    int idAlumno = dataReader.GetInt32("idAlumno");
                    string nombreAlumno = dataReader.GetString("nombreAlumno");
                    string email = ""; 
                    double saldo = dataReader.GetDouble("saldo");

                        listaAlumnos.Add(new Alumno (idAlumno, nombreAlumno, email, saldo));
                    }
                    dataReader.Close();
                    comando.Dispose();
                    cnn.Close();

                    cnn.Close();

               

            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
            return listaAlumnos;

        }


    }
}
