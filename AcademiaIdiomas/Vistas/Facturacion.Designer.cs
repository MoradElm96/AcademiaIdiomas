
namespace AcademiaBaile.Vistas
{
    partial class Facturacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFacturacion = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnSalsa = new System.Windows.Forms.Button();
            this.btnOrdenarPorProfesor = new System.Windows.Forms.Button();
            this.cmbAlumnos = new System.Windows.Forms.ComboBox();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFacturacion
            // 
            this.lblFacturacion.AutoSize = true;
            this.lblFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturacion.Location = new System.Drawing.Point(456, 70);
            this.lblFacturacion.Name = "lblFacturacion";
            this.lblFacturacion.Size = new System.Drawing.Size(319, 46);
            this.lblFacturacion.TabIndex = 2;
            this.lblFacturacion.Text = "FACTURACION";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(1012, 580);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(168, 73);
            this.btnFinalizar.TabIndex = 4;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // btnExportar
            // 
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Location = new System.Drawing.Point(785, 580);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(168, 73);
            this.btnExportar.TabIndex = 5;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // btnSalsa
            // 
            this.btnSalsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalsa.Location = new System.Drawing.Point(517, 580);
            this.btnSalsa.Name = "btnSalsa";
            this.btnSalsa.Size = new System.Drawing.Size(215, 73);
            this.btnSalsa.TabIndex = 6;
            this.btnSalsa.Text = "Mostrar Ingles";
            this.btnSalsa.UseVisualStyleBackColor = true;
            // 
            // btnOrdenarPorProfesor
            // 
            this.btnOrdenarPorProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenarPorProfesor.Location = new System.Drawing.Point(127, 580);
            this.btnOrdenarPorProfesor.Name = "btnOrdenarPorProfesor";
            this.btnOrdenarPorProfesor.Size = new System.Drawing.Size(330, 73);
            this.btnOrdenarPorProfesor.TabIndex = 7;
            this.btnOrdenarPorProfesor.Text = "Ordenar por Profesor";
            this.btnOrdenarPorProfesor.UseVisualStyleBackColor = true;
            // 
            // cmbAlumnos
            // 
            this.cmbAlumnos.FormattingEnabled = true;
            this.cmbAlumnos.Location = new System.Drawing.Point(584, 137);
            this.cmbAlumnos.Name = "cmbAlumnos";
            this.cmbAlumnos.Size = new System.Drawing.Size(283, 24);
            this.cmbAlumnos.TabIndex = 9;
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumno.Location = new System.Drawing.Point(336, 137);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(127, 32);
            this.lblAlumno.TabIndex = 8;
            this.lblAlumno.Text = "Alumno:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(181, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(946, 315);
            this.dataGridView1.TabIndex = 10;
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 719);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbAlumnos);
            this.Controls.Add(this.lblAlumno);
            this.Controls.Add(this.btnOrdenarPorProfesor);
            this.Controls.Add(this.btnSalsa);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.lblFacturacion);
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFacturacion;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnSalsa;
        private System.Windows.Forms.Button btnOrdenarPorProfesor;
        private System.Windows.Forms.ComboBox cmbAlumnos;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}