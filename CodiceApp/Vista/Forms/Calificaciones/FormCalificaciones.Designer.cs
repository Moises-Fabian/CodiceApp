namespace CodiceApp.Vista.Forms.Calificaciones
{
    partial class FormCalificaciones
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
            txtRut = new TextBox();
            txtIdAsignatura = new TextBox();
            dtpFecha = new DateTimePicker();
            txtNota = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnGuardar = new Button();
            btnCalcularPromedio = new Button();
            dataGridViewCalificaciones = new DataGridView();
            lblPromedio = new Label();
            btnEditar = new Button();
            btnEliminar = new Button();
            txtIdCalificacion = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCalificaciones).BeginInit();
            SuspendLayout();
            // 
            // txtRut
            // 
            txtRut.Location = new Point(49, 49);
            txtRut.Name = "txtRut";
            txtRut.Size = new Size(125, 27);
            txtRut.TabIndex = 0;
            // 
            // txtIdAsignatura
            // 
            txtIdAsignatura.Location = new Point(196, 49);
            txtIdAsignatura.Name = "txtIdAsignatura";
            txtIdAsignatura.Size = new Size(125, 27);
            txtIdAsignatura.TabIndex = 1;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(486, 49);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(250, 27);
            dtpFecha.TabIndex = 2;
            // 
            // txtNota
            // 
            txtNota.Location = new Point(341, 49);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(125, 27);
            txtNota.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 21);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 4;
            label1.Text = "Rut Estudiante";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 21);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 5;
            label2.Text = "ID Asignatura";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(341, 21);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 6;
            label3.Text = "Nota";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(486, 21);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 7;
            label4.Text = "Fecha Ingreso";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(752, 47);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(129, 29);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Ingresar Nota";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCalcularPromedio
            // 
            btnCalcularPromedio.Location = new Point(51, 96);
            btnCalcularPromedio.Name = "btnCalcularPromedio";
            btnCalcularPromedio.Size = new Size(154, 29);
            btnCalcularPromedio.TabIndex = 9;
            btnCalcularPromedio.Text = "Calcular promedio";
            btnCalcularPromedio.UseVisualStyleBackColor = true;
            btnCalcularPromedio.Click += btnCalcularPromedio_Click;
            // 
            // dataGridViewCalificaciones
            // 
            dataGridViewCalificaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCalificaciones.Location = new Point(49, 224);
            dataGridViewCalificaciones.Name = "dataGridViewCalificaciones";
            dataGridViewCalificaciones.RowHeadersWidth = 51;
            dataGridViewCalificaciones.Size = new Size(992, 236);
            dataGridViewCalificaciones.TabIndex = 11;
            dataGridViewCalificaciones.CellClick += dataGridViewCalificaciones_CellClick;
            // 
            // lblPromedio
            // 
            lblPromedio.AutoSize = true;
            lblPromedio.Location = new Point(211, 100);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(0, 20);
            lblPromedio.TabIndex = 12;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(192, 156);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(129, 29);
            btnEditar.TabIndex = 13;
            btnEditar.Text = "Editar Nota";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(327, 156);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(129, 29);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar Nota";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtIdCalificacion
            // 
            txtIdCalificacion.Location = new Point(49, 156);
            txtIdCalificacion.Name = "txtIdCalificacion";
            txtIdCalificacion.Size = new Size(125, 27);
            txtIdCalificacion.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 128);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 16;
            label5.Text = "ID Nota";
            // 
            // FormCalificaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 598);
            Controls.Add(label5);
            Controls.Add(txtIdCalificacion);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(lblPromedio);
            Controls.Add(dataGridViewCalificaciones);
            Controls.Add(btnCalcularPromedio);
            Controls.Add(btnGuardar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNota);
            Controls.Add(dtpFecha);
            Controls.Add(txtIdAsignatura);
            Controls.Add(txtRut);
            Name = "FormCalificaciones";
            Text = "FormCalificaciones";
            Load += FormCalificaciones_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCalificaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRut;
        private TextBox txtIdAsignatura;
        private DateTimePicker dtpFecha;
        private TextBox txtNota;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnGuardar;
        private Button btnCalcularPromedio;
        private DataGridView dataGridViewCalificaciones;
        private Label lblPromedio;
        private Button btnEditar;
        private Button btnEliminar;
        private TextBox txtIdCalificacion;
        private Label label5;
    }
}