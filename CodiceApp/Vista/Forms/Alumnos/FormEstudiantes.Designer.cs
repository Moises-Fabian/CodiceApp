namespace CodiceApp.Vista.Forms.Alumnos
{
    partial class FormEstudiantes
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
            btn_agregar = new Button();
            btn_editar = new Button();
            btn_eliminar = new Button();
            dataGridViewEstudiantes = new DataGridView();
            txtRut = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEstudiantes).BeginInit();
            SuspendLayout();
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(611, 63);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(94, 29);
            btn_agregar.TabIndex = 0;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // btn_editar
            // 
            btn_editar.Location = new Point(711, 62);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(94, 29);
            btn_editar.TabIndex = 1;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = true;
            btn_editar.Click += btn_editar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(820, 62);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(94, 29);
            btn_eliminar.TabIndex = 2;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // dataGridViewEstudiantes
            // 
            dataGridViewEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEstudiantes.Location = new Point(52, 99);
            dataGridViewEstudiantes.Name = "dataGridViewEstudiantes";
            dataGridViewEstudiantes.RowHeadersWidth = 51;
            dataGridViewEstudiantes.Size = new Size(862, 272);
            dataGridViewEstudiantes.TabIndex = 3;
            // 
            // txtRut
            // 
            txtRut.Location = new Point(52, 65);
            txtRut.Name = "txtRut";
            txtRut.Size = new Size(125, 27);
            txtRut.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(196, 65);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(338, 65);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(125, 27);
            txtApellido.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(196, 36);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 8;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 36);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 10;
            label2.Text = "Rut";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(480, 65);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(338, 36);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 12;
            label3.Text = "Apellido";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(480, 36);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 13;
            label4.Text = "Email";
            // 
            // FormEstudiantes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 405);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtRut);
            Controls.Add(dataGridViewEstudiantes);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_editar);
            Controls.Add(btn_agregar);
            Name = "FormEstudiantes";
            Text = "Alumnos";
            Load += FormEstudiantes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEstudiantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_agregar;
        private Button btn_editar;
        private Button btn_eliminar;
        private DataGridView dataGridViewEstudiantes;
        private TextBox txtRut;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label label1;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private Label label4;
    }
}