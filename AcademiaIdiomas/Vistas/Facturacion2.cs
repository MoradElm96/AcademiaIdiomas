using AcademiaIdiomas.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaIdiomas.Vistas
{
    public partial class Facturacion2 : Form
    {
        public Facturacion2()
        {
            InitializeComponent();
        }
  
        List<Alumno> listaAlumnos = new Controladores.ControladorAlumnosbbdd().cargarDatos();
        private void Facturacion2_Load(object sender, EventArgs e)
        {
            cmbAlumnos.DataSource = listaAlumnos;

            cmbAlumnos.DisplayMember = "nombreAlumno";
            cmbAlumnos.ValueMember = "idAlumno";

            cmbAlumnos.SelectedIndexChanged += CmbAlumnos_SelectedIndexChanged;

        }

        private void CmbAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet dataSetInscripciones = new Controladores.ControladorCursosBbdd().cargarDatos(Convert.ToInt32(cmbAlumnos.SelectedValue));
            dataGridView1.DataSource = dataSetInscripciones.Tables[0];
            //cada vez que se seleciona uno aparece.
            //usar listas para cmb y para lo demas dataset


        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {

            //Alumno alumnoSeleccionado= listaAlumnos.Find(alumno => alumno.idAlumno == (int)(cmbAlumnos.SelectedValue));
            Alumno alumnoSeleccionado = (Alumno)cmbAlumnos.SelectedItem;// devuelve el objeto entero

          

           // string valor = row.Cells["<nombre de la columna en tu datagrid>"].value
            
            //para saber si se ha selecionado, y cojer dato de la inscripcion es 
            if(dataGridView1.SelectedRows.Count>0 && alumnoSeleccionado.saldo > 0 ){

               //poner ventana dialogo

              //  dataGridView1.SelectedRows[0].Cells[];



            }
            else { MessageBox.Show("seleciona una fila"); }
                    



        }



        //poner desplegable += funcion a ejecutar, si se quiere
        //dos posibilidades, si es la carga no hago nada, o añadir en ejecucion, objeto
    }
}
