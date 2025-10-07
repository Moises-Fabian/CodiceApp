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

namespace CodiceApp.Vista.Forms.Calificaciones
{
    public partial class FormCalificaciones : Form, ICalificacionVista
    {
        public FormCalificaciones()
        {
            InitializeComponent();
        }

        public string Id { get => txtIdCalificacion.Text; set => txtIdCalificacion.Text = value; }
        public string RutEstudiante { get => txtRut.Text; set => txtRut.Text = value; }
        public string IdAsignatura { get => txtIdAsignatura.Text; set => txtIdAsignatura.Text = value; }
        public string Nota { get => txtNota.Text; set => txtNota.Text = value; }
        public DateTime Fecha { get => dtpFecha.Value; set => dtpFecha.Value = value; }
        public string Promedio { set => lblPromedio.Text = value; }

        public event EventHandler CargarCalificaciones;
        public event EventHandler EditarCalificacion;
        public event EventHandler EliminarCalificacion;
        public event EventHandler GuardarCalificacion;
        public event EventHandler CalcularPromedio;

        public void MostrarCalificaciones(List<Calificacion> calificaciones)
        {
            dataGridViewCalificaciones.DataSource = null;
            dataGridViewCalificaciones.DataSource = calificaciones;
        }

        public void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        private void FormCalificaciones_Load(object sender, EventArgs e)
        {
            CargarCalificaciones?.Invoke(this, EventArgs.Empty);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarCalificacion?.Invoke(this, EventArgs.Empty);
        }

        private void btnCalcularPromedio_Click(object sender, EventArgs e)
        {
            CalcularPromedio?.Invoke(this, EventArgs.Empty);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarCalificacion?.Invoke(this, EventArgs.Empty);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarCalificacion?.Invoke(this, EventArgs.Empty);
        }

        private void dataGridViewCalificaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewCalificaciones.Rows[e.RowIndex];
                txtRut.Text = row.Cells["RutEstudiante"].Value.ToString();
                txtIdCalificacion.Text = row.Cells["Id"].Value.ToString();
                txtIdAsignatura.Text = row.Cells["IdAsignatura"].Value.ToString();
                txtNota.Text = row.Cells["Nota"].Value.ToString();
                dtpFecha.Value = (DateTime)row.Cells["Fecha"].Value;
            }
        }
        public void SetPromedioColor(Color color)
        {
            lblPromedio.ForeColor = color;
        }
    }
}
