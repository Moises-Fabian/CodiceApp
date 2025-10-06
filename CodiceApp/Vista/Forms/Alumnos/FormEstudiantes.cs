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

namespace CodiceApp.Vista.Forms.Alumnos
{
    public partial class FormEstudiantes : Form, IEstudianteVista
    {
        public FormEstudiantes()
        {
            InitializeComponent();
        }

        public string Rut { get => txtRut.Text; set => txtRut.Text = value; }
        public string Nombre { get => txtNombre.Text; set => txtNombre.Text = value; }
        public string Apellido { get => txtApellido.Text; set => txtApellido.Text = value; }
        public string Email { get => txtEmail.Text; set => txtEmail.Text = value; }

        public event EventHandler CargarEstudiantes;
        public event EventHandler AgregarEstudiante;
        public event EventHandler EditarEstudiante;
        public event EventHandler EliminarEstudiante;

        public void MostrarEstudiantes(List<Estudiante> estudiantes)
        {
            dataGridViewEstudiantes.DataSource = null;
            dataGridViewEstudiantes.DataSource = estudiantes;
        }

        public void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            AgregarEstudiante?.Invoke(this, EventArgs.Empty);
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            EditarEstudiante?.Invoke(this, EventArgs.Empty);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            EliminarEstudiante?.Invoke(this, EventArgs.Empty);
        }

        private void FormEstudiantes_Load(object sender, EventArgs e)
        {
            CargarEstudiantes?.Invoke(this, EventArgs.Empty);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
