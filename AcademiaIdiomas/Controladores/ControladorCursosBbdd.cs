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
    public class ControladorCursosBbdd
    {
        string cadenaConexion = ConfigurationManager.ConnectionStrings["2damConnectionString"].ConnectionString;

        public DataSet cargarDatos(int idAlumno)
        {
            DataSet dataSet = new DataSet();

            try
            {
                using (var cnn = new MySqlConnection(cadenaConexion))
                {
                    cnn.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand("Select * from inscripciones where idAlumno=@idAlumno",cnn);
                    mySqlCommand.Parameters.AddWithValue("@idAlumno", idAlumno);
                    mySqlCommand.Prepare();
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                    dataAdapter.SelectCommand = mySqlCommand;
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

        public double calcularCoste(double descuento, double minutos, double costeMinuto)
        {
            double CosteACobrar=0.0;

            /*Crea una función de nombre CalcularCoste que reciba un descuento, unos minutos y un coste por minuto y
devuelva el coste a cobrar. Ejemplos:
            CalcularCoste(0, 10, 10) es 100 porque 10 minutos * 10 euros por minuto y 0 el % de descuento
CalcularCoste(15, 10, 10) es 85 por 10 minutos * 10 euros por minuto y 15 es el % de descuento*/

            CosteACobrar = ((minutos * costeMinuto)*(100 -descuento))/100;


            return CosteACobrar;
        }


    }
}
