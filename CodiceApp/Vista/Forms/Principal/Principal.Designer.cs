namespace CodiceApp
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnGestionarEstudiantes = new Button();
            btn_asignaturas = new Button();
            btn_calificaciones = new Button();
            btn_informes = new Button();
            btnGestionarAsistencia = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 58);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 0;
            label1.Text = "Codice APP";
            // 
            // btnGestionarEstudiantes
            // 
            btnGestionarEstudiantes.Location = new Point(110, 130);
            btnGestionarEstudiantes.Name = "btnGestionarEstudiantes";
            btnGestionarEstudiantes.Size = new Size(163, 29);
            btnGestionarEstudiantes.TabIndex = 1;
            btnGestionarEstudiantes.Text = "Gestionar Estudiantes";
            btnGestionarEstudiantes.UseVisualStyleBackColor = true;
            btnGestionarEstudiantes.Click += btn_alumnos_Click;
            // 
            // btn_asignaturas
            // 
            btn_asignaturas.Location = new Point(110, 165);
            btn_asignaturas.Name = "btn_asignaturas";
            btn_asignaturas.Size = new Size(163, 29);
            btn_asignaturas.TabIndex = 2;
            btn_asignaturas.Text = "Gestión Asignaturas";
            btn_asignaturas.UseVisualStyleBackColor = true;
            btn_asignaturas.Click += btn_asignaturas_Click;
            // 
            // btn_calificaciones
            // 
            btn_calificaciones.Location = new Point(110, 245);
            btn_calificaciones.Name = "btn_calificaciones";
            btn_calificaciones.Size = new Size(163, 29);
            btn_calificaciones.TabIndex = 3;
            btn_calificaciones.Text = "Gestion Calificaciones";
            btn_calificaciones.UseVisualStyleBackColor = true;
            btn_calificaciones.Click += btn_calificaciones_Click;
            // 
            // btn_informes
            // 
            btn_informes.Location = new Point(110, 280);
            btn_informes.Name = "btn_informes";
            btn_informes.Size = new Size(163, 29);
            btn_informes.TabIndex = 4;
            btn_informes.Text = "Ver Informes";
            btn_informes.UseVisualStyleBackColor = true;
            // 
            // btnGestionarAsistencia
            // 
            btnGestionarAsistencia.Location = new Point(110, 200);
            btnGestionarAsistencia.Name = "btnGestionarAsistencia";
            btnGestionarAsistencia.Size = new Size(163, 29);
            btnGestionarAsistencia.TabIndex = 5;
            btnGestionarAsistencia.Text = "Gestion Asistencia";
            btnGestionarAsistencia.UseVisualStyleBackColor = true;
            btnGestionarAsistencia.Click += btnGestionarAsistencia_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 402);
            Controls.Add(btnGestionarAsistencia);
            Controls.Add(btn_informes);
            Controls.Add(btn_calificaciones);
            Controls.Add(btn_asignaturas);
            Controls.Add(btnGestionarEstudiantes);
            Controls.Add(label1);
            Name = "Principal";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnGestionarEstudiantes;
        private Button btn_asignaturas;
        private Button btn_calificaciones;
        private Button btn_informes;
        private Button btnGestionarAsistencia;
    }
}
