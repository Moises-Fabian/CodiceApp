namespace CodiceApp.Vista.Forms.Asignaturas
{
    partial class FormAsignaturas
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
            txtId = new TextBox();
            txtDescripcion = new TextBox();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            dataGridViewAsignaturas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAsignaturas).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(58, 53);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(509, 53);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(125, 27);
            txtDescripcion.TabIndex = 1;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(360, 53);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 27);
            txtCodigo.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(211, 53);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 29);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 4;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(211, 29);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 5;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(360, 30);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 6;
            label3.Text = "Código";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(509, 30);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 7;
            label4.Text = "Descripción";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(650, 53);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(750, 53);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(861, 51);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dataGridViewAsignaturas
            // 
            dataGridViewAsignaturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAsignaturas.Location = new Point(56, 112);
            dataGridViewAsignaturas.Name = "dataGridViewAsignaturas";
            dataGridViewAsignaturas.RowHeadersWidth = 51;
            dataGridViewAsignaturas.Size = new Size(899, 188);
            dataGridViewAsignaturas.TabIndex = 11;
            // 
            // FormAsignaturas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 450);
            Controls.Add(dataGridViewAsignaturas);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(txtDescripcion);
            Controls.Add(txtId);
            Name = "FormAsignaturas";
            Text = "FormAsignaturas";
            Load += FormAsignaturas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAsignaturas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtDescripcion;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private DataGridView dataGridViewAsignaturas;
    }
}