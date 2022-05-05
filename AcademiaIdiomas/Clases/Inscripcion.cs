using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaIdiomas.Clases
{
    public class Inscripcion
    { 
        public int idCurso { get; set; }
        public  int idAlumno { get; set; }
       
        public DateTime fechaAlta { get; set; }
        public double minutosCurso { get; set; }
        public string estado { get; set; }
        public int  descuentoPorMinuto { get; set; }

        

        public Inscripcion(int idCurso, int idAlumno, DateTime fechaAlta, double minutosCurso, string estado, int descuentoPorMinuto)
        {
            this.idCurso = idCurso;
            this.idAlumno = idAlumno;
            this.fechaAlta = fechaAlta;
            this.minutosCurso = minutosCurso;
            this.estado = estado;
            this.descuentoPorMinuto = descuentoPorMinuto;
        }

        public Inscripcion()
        {
        }
    }
}
