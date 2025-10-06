using CodiceApp.Presentador;
using CodiceApp.Servicio;
using CodiceApp.Servicio.Interface;
using CodiceApp.Vista.Forms.Alumnos;
using CodiceApp.Vista.Forms.Asignaturas;
using CodiceApp.Vista.Interface;

namespace CodiceApp
{
    public partial class Principal : Form
    {
        private readonly IEstudianteServicio _estudianteServicio;
        private readonly IAsignaturaServicio _asignaturaServicio;
        public Principal()
        {
            InitializeComponent();
            _estudianteServicio = new EstudianteServicio();
            _asignaturaServicio = new AsignaturaServicio();
        }

        private void btn_alumnos_Click(object sender, EventArgs e)
        {
            IEstudianteVista vista = new FormEstudiantes();
            EstudiantePresentador presentador = new EstudiantePresentador(vista, _estudianteServicio);

            ((Form)vista).ShowDialog();
        }

        private void btn_asignaturas_Click(object sender, EventArgs e)
        {
            IAsignaturaVista vista = new FormAsignaturas();
            AsignaturaPresentador presentador = new AsignaturaPresentador(vista, _asignaturaServicio);
            ((Form)vista).ShowDialog();
        }
    }
}
