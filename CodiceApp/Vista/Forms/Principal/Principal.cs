using CodiceApp.Presentador;
using CodiceApp.Servicio;
using CodiceApp.Servicio.Interface;
using CodiceApp.Vista.Forms.Alumnos;
using CodiceApp.Vista.Interface;

namespace CodiceApp
{
    public partial class Principal : Form
    {
        private readonly IEstudianteServicio _estudianteServicio;
        public Principal()
        {
            InitializeComponent();
            _estudianteServicio = new EstudianteServicio();
        }

        private void btn_alumnos_Click(object sender, EventArgs e)
        {
            IEstudianteVista vista = new FormEstudiantes();
            EstudiantePresentador presentador = new EstudiantePresentador(vista, _estudianteServicio);

            ((Form)vista).ShowDialog();
        }
    }
}
