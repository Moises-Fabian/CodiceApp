namespace CodiceApp.Vista.Forms
{
    partial class FormTrabajos
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
            txtNombreTrabajo = new TextBox();
            txtIdAsignatura = new TextBox();
            dataGridViewTrabajos = new DataGridView();
            txtId = new TextBox();
            btnEliminar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dtpFechaEntrega = new DateTimePicker();
            dtpFechaLimite = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnAgregar = new Button();
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTrabajos).BeginInit();
            SuspendLayout();
            // 
            // txtRut
            // 
            txtRut.Location = new Point(36, 83);
            txtRut.Name = "txtRut";
            txtRut.Size = new Size(125, 27);
            txtRut.TabIndex = 0;
            // 
            // txtNombreTrabajo
            // 
            txtNombreTrabajo.Location = new Point(325, 83);
            txtNombreTrabajo.Name = "txtNombreTrabajo";
            txtNombreTrabajo.Size = new Size(125, 27);
            txtNombreTrabajo.TabIndex = 2;
            // 
            // txtIdAsignatura
            // 
            txtIdAsignatura.Location = new Point(182, 83);
            txtIdAsignatura.Name = "txtIdAsignatura";
            txtIdAsignatura.Size = new Size(125, 27);
            txtIdAsignatura.TabIndex = 3;
            // 
            // dataGridViewTrabajos
            // 
            dataGridViewTrabajos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTrabajos.Location = new Point(36, 176);
            dataGridViewTrabajos.Name = "dataGridViewTrabajos";
            dataGridViewTrabajos.RowHeadersWidth = 51;
            dataGridViewTrabajos.Size = new Size(1226, 188);
            dataGridViewTrabajos.TabIndex = 4;
            // 
            // txtId
            // 
            txtId.Location = new Point(36, 142);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 5;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(267, 142);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 51);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 9;
            label1.Text = "Rut Estudiante";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(182, 51);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 10;
            label2.Text = "ID Asignatura";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(325, 52);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 11;
            label3.Text = "Nombre Trabajo";
            // 
            // dtpFechaEntrega
            // 
            dtpFechaEntrega.Location = new Point(464, 86);
            dtpFechaEntrega.Name = "dtpFechaEntrega";
            dtpFechaEntrega.Size = new Size(163, 27);
            dtpFechaEntrega.TabIndex = 12;
            // 
            // dtpFechaLimite
            // 
            dtpFechaLimite.Location = new Point(643, 86);
            dtpFechaLimite.Name = "dtpFechaLimite";
            dtpFechaLimite.Size = new Size(163, 27);
            dtpFechaLimite.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(464, 51);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 14;
            label4.Text = "Fecha Entrega";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(643, 51);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 15;
            label5.Text = "Fecha Límite";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 119);
            label6.Name = "label6";
            label6.Size = new Size(24, 20);
            label6.TabIndex = 16;
            label6.Text = "ID";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(821, 86);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 17;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(167, 142);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 18;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // FormTrabajos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1274, 418);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dtpFechaLimite);
            Controls.Add(dtpFechaEntrega);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(txtId);
            Controls.Add(dataGridViewTrabajos);
            Controls.Add(txtIdAsignatura);
            Controls.Add(txtNombreTrabajo);
            Controls.Add(txtRut);
            Name = "FormTrabajos";
            Text = "FormTrabajos";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTrabajos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRut;
        private TextBox textBox2;
        private TextBox txtNombreTrabajo;
        private TextBox txtIdAsignatura;
        private DataGridView dataGridViewTrabajos;
        private TextBox txtId;
        private Button btnEditar;
        private Button button2;
        private Button btnEliminar;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpFechaEntrega;
        private DateTimePicker dtpFechaLimite;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnAgregar;
    }
}