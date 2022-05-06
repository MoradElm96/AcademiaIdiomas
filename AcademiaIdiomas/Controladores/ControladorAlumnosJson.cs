using AcademiaIdiomas.Clases;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaIdiomas.Controladores
{
    public class ControladorAlumnosJson
    {

        //leer json

        public static List<Alumno> recuperarAlumnos()
        {
            List<Alumno> listaAlumnos = new List<Alumno>();
            try
            {
                string archivoJson = File.ReadAllText(ConfigurationManager.AppSettings.Get("ficheroAlumnos"));
                //añadir ruta a mano en app setings
                listaAlumnos = JsonConvert.DeserializeObject<List<Alumno>>(archivoJson);
            }
            catch (Exception) { }

            return listaAlumnos;
        }

        public static bool eliminarAlumnos(int idAlumno)
        {
            List<Alumno> lista = recuperarAlumnos();

            int posicion = lista.FindIndex(alumno => alumno.idAlumno  == idAlumno);
            if(posicion != -1)
            {
                lista.RemoveAt(posicion);
                return guardarAlumnos(lista);
            } else
            {
                return false;
            }


        }

        public static bool incrementarSueldo(int idAlumno)
        {
            //duda porque me aumenta en todo
            List<Alumno> listaAModificar = recuperarAlumnos();
           

            double cantidadSumar = 50;
            
            //alternativa lista.foreach (alumno=> alumno.saldo ==50);
            //ver listas for each

            //para cada posicion selecionada en el data grid
            int posicion = listaAModificar.FindIndex(alumno => alumno.idAlumno == idAlumno);
            if(posicion!= -1)
            {
                    listaAModificar[posicion].saldo = listaAModificar[posicion].saldo + cantidadSumar;       
                    return guardarAlumnos(listaAModificar);
            }
            else
            {
                return false;
            }


            //listaAModificar.ForEach(alumno => alumno.saldo += cantidadSumar);

        }


        public static bool guardarAlumnos(List<Alumno> lista)
        {
            try
            {
                string archivoJson = JsonConvert.SerializeObject(lista);
                File.WriteAllText(ConfigurationManager.AppSettings.Get("ficheroAlumnos"), archivoJson);

            }
            catch ( Exception e)
            {
                return false;
            }
            return true;
            
        }



    }
}
