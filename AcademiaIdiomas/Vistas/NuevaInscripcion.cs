using AcademiaIdiomas.Clases;
using AcademiaIdiomas.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaBaile.Vistas
{
    public partial class NuevaInscripcion : Form
    {
        public NuevaInscripcion()
        {
            InitializeComponent();
            cargarDatos();

        }
        List<Alumno> listaAlumnos = new List<Alumno>();
        List<Curso> listaCursos = new List<Curso>();
        private void NuevaInscripcion_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void cargarDatos()
        {
            listaAlumnos = ControladorAlumnosJson.recuperarAlumnos();

            //cargar nombre en combo box
            cmbAlumnos.DataSource = listaAlumnos;
            cmbAlumnos.DisplayMember = "nombreAlumno";
            cmbAlumnos.ValueMember = "idAlumno";
            //preguntar como cargar desde el formulario

            listaCursos = ControladorCursosJson.recuperarCursos();


            lstCursos.DataSource = listaCursos;
            lstCursos.DisplayMember = "nombreCurso";
            lstCursos.ValueMember = "idCurso";
            //rellenar array
            Inscripcion inscripcion = new Inscripcion();

            inscripcion.descuentoPorMinuto =  new int[] {0,10,15,20,25,30,50,60};

            cmbDescuento.DataSource = inscripcion.descuentoPorMinuto;
            cmbDescuento.DisplayMember = "descuentoPorMinuto";
                

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            listaAlumnos = ControladorAlumnosJson.recuperarAlumnos();
            listaCursos = ControladorCursosJson.recuperarCursos();

            double saldoSuficiente=0.0;

           
            /*
            foreach(var cursos in listaCursos.Where(x => listaAlumnos.Where(y => y.saldo >= (listaCursos.Where(z => z.costeMinuto)) )
            {
                Console.WriteLine(cursos.costeMinuto);
            }

            List<MiObj> ListaFinal = new List<MiObj>();


            foreach (var item in SoftwareDisponible.Where(x => SoftwareEquipo.Where(y => y.tipo == x.tipo && y.EsUnico != true).Select(y => y.tipo).Contains(x.tipo)))
                ListaFinal.Add(item);

            */

        }
    }
}
