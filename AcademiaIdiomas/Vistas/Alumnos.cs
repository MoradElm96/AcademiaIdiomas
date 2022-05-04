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
    public partial class Alumnos : Form
    {

        public List<Alumno> listaAlumnos;

        public Alumnos()
        {
            InitializeComponent();
            cargarDatos();
        }

        public void cargarDatos()
        {
            listaAlumnos = ControladorAlumnosJson.recuperarAlumnos();
            dataGridView1.Refresh();
            dataGridView1.DataSource = listaAlumnos;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int contadorBorrados = 0;
            foreach (DataGridViewRow fila in dataGridView1.SelectedRows)
            {
                if (ControladorAlumnosJson.eliminarAlumnos(Convert.ToInt32(fila.Cells[0].Value.ToString())))//convertir en int
                {
                    contadorBorrados++;
                }
            }
            MessageBox.Show("Se han eliminado " + contadorBorrados.ToString() + " alumnos");
            cargarDatos();

        }

        private void btnIncrementarSaldo_Click(object sender, EventArgs e)
        {
            int contadorSumados = 0;
            foreach (DataGridViewRow fila in dataGridView1.SelectedRows)
            {
              if(ControladorAlumnosJson.incrementarSueldo(Convert.ToInt32(fila.Cells[0].Value.ToString())))
                {
                    contadorSumados++;
                }
            }
            MessageBox.Show("Se han sumado " + contadorSumados.ToString() + " sueldos");
            cargarDatos();
        }

        private void btnSaldoMedio_Click(object sender, EventArgs e)
        {
            double sumaSalarios=0;

            foreach(var alumnos in listaAlumnos)
            {
                 sumaSalarios =  listaAlumnos.Sum(suma => suma.saldo)/ listaAlumnos.Count;
                
            }

            MessageBox.Show("la suma total es de " + sumaSalarios);
        }

        private void btnNuevaInscripcion_Click(object sender, EventArgs e)
        {
            
            if(dataGridView1.SelectedRows.Count >= 1) 
            {
                NuevaInscripcion nuevaInscripcion = new NuevaInscripcion();
                nuevaInscripcion.ShowDialog();

                


            }
            else
            {
                MessageBox.Show("selecione un alumno antes de abrir inscripcion");
            }
        }
    }
}
