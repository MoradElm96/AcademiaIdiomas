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
   public  class ControladorCursosJson
    {
        public static List<Curso> recuperarCursos()
        {
            List<Curso> listaCursos = new List<Curso>();
            try
            {
                string archivoJson = File.ReadAllText(ConfigurationManager.AppSettings.Get("ficheroCursos"));
                //añadir ruta a mano en app setings
                listaCursos = JsonConvert.DeserializeObject<List<Curso>>(archivoJson);
            }
            catch (Exception) { }

            return listaCursos;
        }
        /*
        public static bool eliminarAlumnos(int idAlumno)
        {
            List<Alumno> lista = recuperarAlumnos();

            int posicion = lista.FindIndex(alumno => alumno.idAlumno == idAlumno);
            if (posicion != -1)
            {
                lista.RemoveAt(posicion);
                return guardarAlumnos(lista);
            }
            else
            {
                return false;
            }


        }*/

        



        public static bool guardarCursos(List<Curso> lista)
        {
            try
            {
                string archivoJson = JsonConvert.SerializeObject(lista);
                File.WriteAllText(ConfigurationManager.AppSettings.Get("ficheroCursos"), archivoJson);

            }
            catch (Exception e)
            {
                return false;
            }
            return true;

        }



    }
}
