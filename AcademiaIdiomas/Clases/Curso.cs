using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaIdiomas.Clases
{
   public  class Curso
    {
        public int idCurso { get; set; }
        public string nombreCurso { get; set; }
        public string nombreProfesor { get; set; }

        public string idioma { get; set; }
        public double costeMinuto { get; set; }

        public Curso(int idCurso, string nombreCurso, string nombreProfesor, string idioma, double costeMinuto)
        {
            this.idCurso = idCurso;
            this.nombreCurso = nombreCurso;
            this.nombreProfesor = nombreProfesor;
            this.idioma = idioma;
            this.costeMinuto = costeMinuto;
        }

        public Curso()
        {
        }
    }
}
