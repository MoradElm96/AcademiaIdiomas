using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaIdiomas.Clases
{
    public class Alumno
    {
        public  int idAlumno { get; set; }
        public string nombreAlumno { get; set; }
        public string email { get; set; }

        public double saldo { get; set; }

        public Alumno(int idAlumno, string nombreAlumno, string email, double saldo)
        {
            this.idAlumno = idAlumno;
            this.nombreAlumno = nombreAlumno;
            this.email = email;
            this.saldo = saldo;
        }

        public Alumno()
        {

        }



    }
}
