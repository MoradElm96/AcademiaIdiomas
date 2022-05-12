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

        public DataSet cargarDatos()
        {
            DataSet dataSet = new DataSet();

            try
            {
                using (var cnn = new MySqlConnection(cadenaConexion))
                {
                    cnn.Open();
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter("select * from Alumnos", cnn);
                    dataAdapter.Fill(dataSet);
                    dataAdapter.Dispose();
                    cnn.Close();

                }

            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
            return dataSet;

        }


    }
}
