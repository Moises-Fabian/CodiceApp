using CodiceApp.Modelo.Entidades;
using CodiceApp.Vista.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodiceApp.Vista.Forms.Asignaturas
{
    public partial class FormAsignaturas : Form, IAsignaturaVista
    {
        public FormAsignaturas()
        {
            InitializeComponent();
        }

        public string Id { get => txtId.Text; set => txtId.Text = value; }
        public string Nombre { get => txtNombre.Text; set => txtNombre.Text = value; }
        public string Codigo { get => txtCodigo.Text; set => txtCodigo.Text = value; }
        public string Descripcion { get => txtDescripcion.Text; set => txtDescripcion.Text = value; }

        public event EventHandler CargarAsignaturas;
        public event EventHandler AgregarAsignatura;
        public event EventHandler EditarAsignatura;
        public event EventHandler EliminarAsignatura;

        public void MostrarAsignaturas(List<Asignatura> asignaturas)
        {
            dataGridViewAsignaturas.DataSource = null;
            dataGridViewAsignaturas.DataSource = asignaturas;
        }

        public void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        // --- Lanzadores de Eventos ---
        private void FormAsignaturas_Load(object sender, EventArgs e)
        {
            CargarAsignaturas?.Invoke(this, EventArgs.Empty);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarAsignatura?.Invoke(this, EventArgs.Empty);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarAsignatura?.Invoke(this, EventArgs.Empty);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarAsignatura?.Invoke(this, EventArgs.Empty);
        }
    }
}
