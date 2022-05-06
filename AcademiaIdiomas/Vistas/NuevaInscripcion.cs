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

        public int idAlumno = -1;

        private void NuevaInscripcion_Load(object sender, EventArgs e)
        {
            cargarDatos();
            if (idAlumno != -1)
            {
                cmbAlumnos.SelectedValue = idAlumno;
            }
                
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


            int[] descuentos = new int[] { 0, 10, 15, 20, 25, 30, 50, 60 };
            cmbDescuento.DataSource = descuentos;// si solo son numeros no poner nada
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //comprobar que todo okey, si todo okey
            //localizar lista alumnos el alumno con un find index
            //localizar curso igual que el alumno

            listaAlumnos = ControladorAlumnosJson.recuperarAlumnos();
            listaCursos = ControladorCursosJson.recuperarCursos();

            Alumno alumno = listaAlumnos.Find(a => a.idAlumno == Convert.ToInt32(cmbAlumnos.SelectedValue)); //devuelve el alumno

            Curso curso = listaCursos.Find(c => c.idCurso == Convert.ToInt32(lstCursos.SelectedValue));

            double minutos = Convert.ToDouble(nupMinutosCurso.Value);

            if (alumno.saldo >= curso.costeMinuto*minutos)
            {
                int alum = alumno.idAlumno;  
                int curs = curso.idCurso;
                int descuento = Convert.ToInt32(cmbDescuento.SelectedValue);
                DateTime fechaAlta = dateTimePicker1.Value;
                string estado = "Abierta";
                
                //añader objeto y en esta pantalla no hay nada
                Inscripcion inscripcion = new Inscripcion(curs, alum, fechaAlta, minutos, estado, descuento);
                             
                ControladorInscripciones.guardarInscripciones(inscripcion);
                
                MessageBox.Show("Realizado");
                


            }
            else
            {
                MessageBox.Show("No realizado, no tiene suficiente saldo");
            }

            //selected index devuelve un numero y value el objeto entero



            









            }






        }
    }

