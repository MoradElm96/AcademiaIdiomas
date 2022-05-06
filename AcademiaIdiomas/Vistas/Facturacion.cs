using AcademiaIdiomas.Clases;
using AcademiaIdiomas.Controladores;
using AcademiaIdiomas.Vistas;
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
    public partial class Facturacion : Form
    {
        private List<Inscripcion> listaInscripciones = new List<Inscripcion>();
        public Facturacion()
        {
            InitializeComponent();
            cargarDatos();
        }

        public void cargarDatos()
        {
            List<Alumno> listaAlumnoss = ControladorAlumnosJson.recuperarAlumnos();

            cmbAlumnos.DataSource = listaAlumnoss;
            cmbAlumnos.DisplayMember = "nombreAlumno";
            cmbAlumnos.ValueMember = "idAlumno";



                       
        }

        private void cmbAlumnos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            List<Inscripcion> listaInscripcionesTotal = ControladorInscripciones.recuperarInscripcones();
            //para filtrar lista
            listaInscripciones = listaInscripcionesTotal.FindAll((inscripcion) => inscripcion.estado == "Abierta" && inscripcion.idAlumno == Convert.ToInt32(cmbAlumnos.SelectedValue));
            
            dataGridView1.DataSource = listaInscripciones;
        }

        private void btnOrdenarPorProfesor_Click(object sender, EventArgs e)
        {

            List<Inscripcion> listaInscripcionesTotal = ControladorInscripciones.recuperarInscripcones();
            //  listaAtletas.Order(listaAtletas => listaAtletas.IdAtleta);

            listaInscripcionesTotal.Sort((a, b) => (Convert.ToInt32(a.idAlumno) - Convert.ToInt32(b.idAlumno))/*a.Nombre).CompareTo(b.Nombre)*/);
            dataGridView1.Refresh();

            listaInscripciones = listaInscripcionesTotal;
            dataGridView1.DataSource = listaInscripciones;


        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            List<Inscripcion> listaInscripcionesTotal = ControladorInscripciones.recuperarInscripcones();
            List<Curso> listaCurso = ControladorCursosJson.recuperarCursos();

            // listaInscripciones = listaInscripcionesTotal.FindAll((inscripcion) => inscripcion. == "Abierta");//filtrar

          
            
            
           List<Curso> listaCursosIngles= listaCurso.FindAll((curso) => curso.idioma.Contains("ngles"));
           
           listaInscripciones.Clear();
            listaInscripcionesTotal.ForEach(inscripcion => {
                if (listaCursosIngles.FindIndex(curso => curso.idCurso == inscripcion.idCurso)!=-1)
                {
                    listaInscripciones.Add(inscripcion);
                }
            });

           // listaInscripciones = listaInscripcionesTotal.FindAll((inscripcion) => listaCursosIngles.FindIndex(curso => curso.idCurso == inscripcion.idCurso) != -1); 
           if (listaInscripciones.Count>0) { 
                dataGridView1.Refresh();
                dataGridView1.DataSource = listaInscripciones;
            }
            else
            {
                MessageBox.Show("no existe idioma con ese curso");
            }


            

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            
                //var rutaAArchivo = string.Empty;
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.InitialDirectory = "c:\\";
                saveFileDialog1.Title = "Save json Files";
                saveFileDialog1.CheckPathExists = true;
                saveFileDialog1.DefaultExt = "json";
                saveFileDialog1.Filter = "Json files (*.json)|*.xml|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                string nombreArchivo = saveFileDialog1.FileName;
                ControladorInscripciones.exportarInscripciones(listaInscripciones, nombreArchivo);//guarda el nombre y la lista

                }


           



        }
    }
}
