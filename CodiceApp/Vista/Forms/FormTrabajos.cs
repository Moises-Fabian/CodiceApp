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

namespace CodiceApp.Vista.Forms
{
    public partial class FormTrabajos : Form, ITrabajoVista
    {
        public FormTrabajos()
        {
            InitializeComponent();
        }

        public string Id { get => txtId.Text; set => txtId.Text = value; }
        public string RutEstudiante { get => txtRut.Text; set => txtRut.Text = value; }
        public string IdAsignatura { get => txtIdAsignatura.Text; set => txtIdAsignatura.Text = value; }
        public string NombreTrabajo { get => txtNombreTrabajo.Text; set => txtNombreTrabajo.Text = value; }
        public DateTime FechaEntrega { get => dtpFechaEntrega.Value; set => dtpFechaEntrega.Value = value; }
        public DateTime FechaLimite { get => dtpFechaLimite.Value; set => dtpFechaLimite.Value = value; }

        public event EventHandler CargarTrabajos;
        public event EventHandler AgregarTrabajo;
        public event EventHandler EditarTrabajo;
        public event EventHandler EliminarTrabajo;

        public void MostrarTrabajos(List<Trabajo> trabajos)
        {
            dataGridViewTrabajos.DataSource = null;
            dataGridViewTrabajos.DataSource = trabajos;
        }

        public void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        private void FormTrabajos_Load(object sender, EventArgs e)
        {
            CargarTrabajos?.Invoke(this, EventArgs.Empty);
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarTrabajo?.Invoke(this, EventArgs.Empty);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarTrabajo?.Invoke(this, EventArgs.Empty);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarTrabajo?.Invoke(this, EventArgs.Empty);
        }
    }
}
