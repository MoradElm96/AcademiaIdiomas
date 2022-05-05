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
        public Facturacion()
        {
            InitializeComponent();
            cargarDatos();
        }

        List<Alumno> listaAlumnoss = new List<Alumno>();
        List<Inscripcion> listaInscripciones = new List<Inscripcion>();

       

        public void cargarDatos()
        {
            listaAlumnoss = ControladorAlumnosJson.recuperarAlumnos();

            cmbAlumnos.DataSource = listaAlumnoss;
            cmbAlumnos.DisplayMember = "nombreAlumno";

           
        }

        private void cmbAlumnos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            listaInscripciones = ControladorInscripciones.recuperarInscripcones();
            //para filtrar lista
            List<Inscripcion> listaFiltrada = listaInscripciones.FindAll((inscripcion) => inscripcion.estado == "Abierta");


            dataGridView1.DataSource = listaFiltrada;

           



        }

        private void btnOrdenarPorProfesor_Click(object sender, EventArgs e)
        {

            listaInscripciones = ControladorInscripciones.recuperarInscripcones();
            //  listaAtletas.Order(listaAtletas => listaAtletas.IdAtleta);

            listaInscripciones.Sort((a, b) => (Convert.ToInt32(a.idAlumno) - Convert.ToInt32(b.idAlumno))/*a.Nombre).CompareTo(b.Nombre)*/);
            dataGridView1.Refresh();

            dataGridView1.DataSource = listaInscripciones;


        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            listaInscripciones = ControladorInscripciones.recuperarInscripcones();

            List<Inscripcion> listaFiltrada = listaInscripciones.FindAll((inscripcion) => inscripcion.estado == "Abierta");//filtrar


            dataGridView1.Refresh();

            dataGridView1.DataSource = listaInscripciones;

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {

            FrmDialogo frmDialogo = new FrmDialogo();
            frmDialogo.ShowDialog();

             /*
                        string ruta = textBox1.Text;

                        List<Equipo> listaEquipos = Controladores.ControladorEquipos.GetEquipos();

                        if (listaEquipos == null)
                        {
                            MessageBox.Show("No se ha selecionado ningun equipo");//duda
                        }
                        else
                        {
                            Controladores.ControladorEquipos.guardarXml(listaEquipos, ruta);

                            MessageBox.Show("La operacion se ha realizado existosamente");

                        }*/
            
        }
    }
}
