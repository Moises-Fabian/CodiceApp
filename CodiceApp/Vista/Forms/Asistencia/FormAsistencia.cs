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

namespace CodiceApp.Vista.Forms.Asistencia
{
    public partial class FormAsistencia : Form, IAsistenciaVista
    {
        public FormAsistencia()
        {
            InitializeComponent();
        }

        public string RutEstudiante { get => txtRutEstudiante.Text; set => txtRutEstudiante.Text = value; }
        public string IdAsignatura { get => txtIdAsignatura.Text; set => txtIdAsignatura.Text = value; }
        public DateTime Fecha { get => dtpFecha.Value; set => dtpFecha.Value = value; }
        public bool Presente { get => chkPresente.Checked; set => chkPresente.Checked = value; }

        public event EventHandler CargarDatosIniciales;
        public event EventHandler RegistrarAsistencia;
        public event EventHandler CargarAsistencias;

        public void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        private void FormAsistencia_Load(object sender, EventArgs e)
        {
            CargarAsistencias?.Invoke(this, EventArgs.Empty);
        }

        public void MostrarAsistencias(List<Modelo.Entidades.Asistencia> asistencias)
        {
            dataGridViewAsistencia.DataSource = null;
            dataGridViewAsistencia.DataSource = asistencias;
        }

        private void btnGuardarAsistencia_Click_1(object sender, EventArgs e)
        {
            RegistrarAsistencia?.Invoke(this, EventArgs.Empty);
        }
    }
}
