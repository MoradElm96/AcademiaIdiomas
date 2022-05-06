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
    public class ControladorInscripciones
    {
        public static bool guardarInscripciones(Inscripcion inscripcion)
        {
            try
            {
                List<Inscripcion> listaInscripciones = ControladorInscripciones.recuperarInscripcones();
                listaInscripciones.Add(inscripcion);

                string archivoJson = JsonConvert.SerializeObject(listaInscripciones);
                File.WriteAllText(ConfigurationManager.AppSettings.Get("ficheroInscripciones"), archivoJson);

            }
            catch (Exception e)
            {
                return false;
            }
            return true;

        }


        public static List<Inscripcion> recuperarInscripcones()
        {
            List<Inscripcion> listaInscripciones = new List<Inscripcion>();

            try
            {
                string archivoJson = File.ReadAllText(ConfigurationManager.AppSettings.Get("ficheroInscripciones"));
                //añadir ruta a mano en app setings
                listaInscripciones = JsonConvert.DeserializeObject<List<Inscripcion>>(archivoJson);
            }
            catch (Exception) { }

            return listaInscripciones;
        }

    }
}
