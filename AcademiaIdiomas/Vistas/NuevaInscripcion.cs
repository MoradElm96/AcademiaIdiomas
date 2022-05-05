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


            int[] descuentos = new int[] { 0, 10, 15, 20, 25, 30, 50, 60 };


            for (int i = 0; i < descuentos.Length; i++)

            {


            }




            cmbDescuento.DataSource = descuentos;
            cmbDescuento.DisplayMember = "descuentoPorMinuto";
            // cmbDescuento.ValueMember = "descuentoPorMinuto";




        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            listaAlumnos = ControladorAlumnosJson.recuperarAlumnos();
            listaCursos = ControladorCursosJson.recuperarCursos();

            double minutos = Convert.ToDouble(nupMinutosCurso.Value);
            double saldoSuficiente = 0;
            string estado = "Abierta";



            foreach (var alumnos in listaAlumnos)
            {           
                foreach (var curso in listaCursos)
                {              
                    saldoSuficiente = minutos * curso.costeMinuto;
                }

                if (alumnos.saldo >= saldoSuficiente)
                {
                    int alumno = cmbAlumnos.SelectedIndex;
                    int curso = lstCursos.SelectedIndex;
                    int descuento = cmbDescuento.SelectedIndex;
                    DateTime fechaAlta = dateTimePicker1.Value;


                    Inscripcion inscripcion = new Inscripcion(curso, alumno, fechaAlta, minutos, estado, descuento);
                    List<Inscripcion> lista = new List<Inscripcion>();
                    lista.Add(inscripcion);

                    if (ControladorInscripciones.guardarInscripciones(lista))
                    {
                        MessageBox.Show("Realizado");
                    }
                    else
                    {
                        MessageBox.Show("No realizado, no tiene suficiente saldo");
                    }
                    //preguntar porque salta dos veces y entra siempre en bucle

                    //convertir a int porque es un string, siempre coger el value
                    //selected item es todo entero el equipo entero, hay qye convertir a objeto equipo y luego coger el .idEquipo

                    //datasource, lista de textos, pero tambien puede ser una lista de objetos
                    //si tengo lista de objetos , displaymember  es lo que yo veo en la pantalla y value member el valor que quiero quedarme para trabajar.
                    //selected index, la posicion, si admite coger varios es items
                    //si se pone selected value hay que castear

                } else
                {
                    MessageBox.Show("no se ha podido realizar la inscripcion");
                }










            }






        }
    }
}
