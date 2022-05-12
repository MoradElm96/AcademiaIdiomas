using AcademiaBaile.Vistas;
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

namespace AcademiaBaile
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            //para que no se permita abrir varias veces

            Alumnos frmAlumnos;

            if (!ControladorFormularios.EstaFormularioAbierto(typeof(Alumnos)))
            {
                frmAlumnos = new Alumnos();
                frmAlumnos.Show();
            }
            else
            {
                frmAlumnos = (Alumnos)ControladorFormularios.RecuperarFormulario(typeof(Alumnos));
                if (frmAlumnos.WindowState == FormWindowState.Minimized)
                {
                    frmAlumnos.WindowState = FormWindowState.Normal;
                }
                frmAlumnos.Show();
                frmAlumnos.Focus();
            }
        }

        private void inscripcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaInscripcion nuevaInscripcion = new NuevaInscripcion();
            nuevaInscripcion.ShowDialog();
        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturacion facturacion = new Facturacion();
            facturacion.Show();

        }

        private void facturación2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturacion2 facturacion2 = new Facturacion2();
            facturacion2.ShowDialog();
        }
    }
}
