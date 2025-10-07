namespace CodiceApp.Vista.Forms.Asistencia
{
    partial class FormAsistencia
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
            txtRutEstudiante = new TextBox();
            txtIdAsignatura = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dtpFecha = new DateTimePicker();
            chkPresente = new CheckBox();
            dataGridViewAsistencia = new DataGridView();
            btnGuardarAsistencia = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAsistencia).BeginInit();
            SuspendLayout();
            // 
            // txtRutEstudiante
            // 
            txtRutEstudiante.Location = new Point(48, 46);
            txtRutEstudiante.Name = "txtRutEstudiante";
            txtRutEstudiante.Size = new Size(125, 27);
            txtRutEstudiante.TabIndex = 0;
            // 
            // txtIdAsignatura
            // 
            txtIdAsignatura.Location = new Point(198, 46);
            txtIdAsignatura.Name = "txtIdAsignatura";
            txtIdAsignatura.Size = new Size(125, 27);
            txtIdAsignatura.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 18);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 2;
            label1.Text = "Rut Estudiante";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 18);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 3;
            label2.Text = "Id Asignatura";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(356, 46);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(250, 27);
            dtpFecha.TabIndex = 4;
            // 
            // chkPresente
            // 
            chkPresente.AutoSize = true;
            chkPresente.Location = new Point(630, 47);
            chkPresente.Name = "chkPresente";
            chkPresente.Size = new Size(97, 24);
            chkPresente.TabIndex = 5;
            chkPresente.Text = "Asistencia";
            chkPresente.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAsistencia
            // 
            dataGridViewAsistencia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAsistencia.Location = new Point(48, 116);
            dataGridViewAsistencia.Name = "dataGridViewAsistencia";
            dataGridViewAsistencia.RowHeadersWidth = 51;
            dataGridViewAsistencia.Size = new Size(839, 188);
            dataGridViewAsistencia.TabIndex = 6;
            // 
            // btnGuardarAsistencia
            // 
            btnGuardarAsistencia.Location = new Point(736, 48);
            btnGuardarAsistencia.Name = "btnGuardarAsistencia";
            btnGuardarAsistencia.Size = new Size(151, 29);
            btnGuardarAsistencia.TabIndex = 7;
            btnGuardarAsistencia.Text = "Agregar Asistencia";
            btnGuardarAsistencia.UseVisualStyleBackColor = true;
            btnGuardarAsistencia.Click += btnGuardarAsistencia_Click_1;
            // 
            // FormAsistencia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 450);
            Controls.Add(btnGuardarAsistencia);
            Controls.Add(dataGridViewAsistencia);
            Controls.Add(chkPresente);
            Controls.Add(dtpFecha);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtIdAsignatura);
            Controls.Add(txtRutEstudiante);
            Name = "FormAsistencia";
            Text = "FormAsistencia";
            Load += FormAsistencia_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAsistencia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRutEstudiante;
        private TextBox txtIdAsignatura;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpFecha;
        private CheckBox chkPresente;
        private DataGridView dataGridViewAsistencia;
        private Button btnGuardarAsistencia;
    }
}