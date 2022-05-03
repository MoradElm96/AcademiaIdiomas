
namespace AcademiaBaile.Vistas
{
    partial class Alumnos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblAlumnos = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnSaldoMedio = new System.Windows.Forms.Button();
            this.btnNuevaInscripcion = new System.Windows.Forms.Button();
            this.btnIncrementarSaldo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(72, 89);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(693, 193);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblAlumnos
            // 
            this.lblAlumnos.AutoSize = true;
            this.lblAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumnos.Location = new System.Drawing.Point(361, 33);
            this.lblAlumnos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlumnos.Name = "lblAlumnos";
            this.lblAlumnos.Size = new System.Drawing.Size(183, 37);
            this.lblAlumnos.TabIndex = 1;
            this.lblAlumnos.Text = "ALUMNOS";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(72, 327);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(126, 59);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnSaldoMedio
            // 
            this.btnSaldoMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaldoMedio.Location = new System.Drawing.Point(223, 327);
            this.btnSaldoMedio.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaldoMedio.Name = "btnSaldoMedio";
            this.btnSaldoMedio.Size = new System.Drawing.Size(170, 59);
            this.btnSaldoMedio.TabIndex = 3;
            this.btnSaldoMedio.Text = "Saldo medio";
            this.btnSaldoMedio.UseVisualStyleBackColor = true;
            this.btnSaldoMedio.Click += new System.EventHandler(this.btnSaldoMedio_Click);
            // 
            // btnNuevaInscripcion
            // 
            this.btnNuevaInscripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaInscripcion.Location = new System.Drawing.Point(607, 327);
            this.btnNuevaInscripcion.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevaInscripcion.Name = "btnNuevaInscripcion";
            this.btnNuevaInscripcion.Size = new System.Drawing.Size(158, 59);
            this.btnNuevaInscripcion.TabIndex = 4;
            this.btnNuevaInscripcion.Text = "Nueva Inscripción";
            this.btnNuevaInscripcion.UseVisualStyleBackColor = true;
            this.btnNuevaInscripcion.Click += new System.EventHandler(this.btnNuevaInscripcion_Click);
            // 
            // btnIncrementarSaldo
            // 
            this.btnIncrementarSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncrementarSaldo.Location = new System.Drawing.Point(411, 327);
            this.btnIncrementarSaldo.Margin = new System.Windows.Forms.Padding(2);
            this.btnIncrementarSaldo.Name = "btnIncrementarSaldo";
            this.btnIncrementarSaldo.Size = new System.Drawing.Size(170, 59);
            this.btnIncrementarSaldo.TabIndex = 5;
            this.btnIncrementarSaldo.Text = "Incrementar Saldo";
            this.btnIncrementarSaldo.UseVisualStyleBackColor = true;
            this.btnIncrementarSaldo.Click += new System.EventHandler(this.btnIncrementarSaldo_Click);
            // 
            // Alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 493);
            this.Controls.Add(this.btnIncrementarSaldo);
            this.Controls.Add(this.btnNuevaInscripcion);
            this.Controls.Add(this.btnSaldoMedio);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.lblAlumnos);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Alumnos";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblAlumnos;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnSaldoMedio;
        private System.Windows.Forms.Button btnNuevaInscripcion;
        private System.Windows.Forms.Button btnIncrementarSaldo;
    }
}