using InstitutoDesktop.Views;
using InstitutoDesktop.Views.Inscripciones;
using InstitutoDesktop.Views.Horarios;
using InstitutoDesktop.Views.MesasExamenes;

using InstitutoDesktop.Views.Commons.Alumnos;

using InstitutoDesktop.Views.Commons;
using InstitutoDesktop.Views.Commons.AnioCarreras;
using InstitutoDesktop.Views.Commons.Materias;
using InstitutoDesktop.Views.Commons.Aulas;
using InstitutoServices.Services.Commons;
using Microsoft.Extensions.Caching.Memory;
using InstitutoServices.Models.Commons;
using InstitutoServices.Models.Inscripciones;
using InstitutoServices.Models.Horarios;
using InstitutoServices.Models.MesasExamenes;
using Microsoft.Extensions.DependencyInjection;





namespace InstitutoDesktop
{
    public partial class MenuPrincipalView : Form
    {
        bool logueado = false;
        private readonly MemoryCacheService _cacheService;
        private readonly IServiceProvider _serviceProvider;


        public MenuPrincipalView(MemoryCacheService memoryCacheService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _cacheService = memoryCacheService;
            GetCacheData();
            _serviceProvider = serviceProvider;
        }

        private void GetCacheData()
        {
            Task.WhenAll(new List<Task>
            {
                Task.Run(async () => _cacheService.GetAllCache<Alumno>("Alumnos")),
                Task.Run(async () => _cacheService.GetAllCache<AnioCarrera>("AnioCarreras")),
                Task.Run(async () =>_cacheService.GetAllCache<Aula>("Aulas")),
                Task.Run(async () =>_cacheService.GetAllCache<Carrera>("Carreras")),
                Task.Run(async () =>_cacheService.GetAllCache<CicloLectivo>("CiclosLectivos")),
                Task.Run(async () =>_cacheService.GetAllCache<Docente>("Docentes")),
                Task.Run(async () =>_cacheService.GetAllCache<Hora>("Horas")),
                Task.Run(async () =>_cacheService.GetAllCache<Horario>("Horarios")),
                Task.Run(async () =>_cacheService.GetAllCache<IntegranteHorario>("IntegrantesHorarios")),
                Task.Run(async () =>_cacheService.GetAllCache<JefaturaSeccion>("JefaturasSecciones")),
                Task.Run(async () =>_cacheService.GetAllCache<Materia>("Materias")),
                Task.Run(async () =>_cacheService.GetAllCache<TurnoExamen>("TurnosExamenes")),
                Task.Run(async () =>_cacheService.GetAllCache<Inscripcion>("Inscripciones")),
                Task.Run(async () =>_cacheService.GetAllCache<DetalleInscripcion>("DetallesInscripciones")),
                Task.Run(async () =>_cacheService.GetAllCache<MesaExamen>("MesasExamenes")),
                Task.Run(async () =>_cacheService.GetAllCache<DetalleMesaExamen>("DetallesMesasExamenes")),
                Task.Run(async () =>_cacheService.GetAllCache<InscripcionExamen>("InscripcionesExamenes")),
                Task.Run(async () =>_cacheService.GetAllCache<DetalleInscripcionExamen>("DetallesInscripcionesExamenes")),

            });
            

        }

        private void iconMenuItem5_Click(object sender, EventArgs e)
        {
            CarrerasView carrerasView =  _serviceProvider.GetRequiredService<CarrerasView>();

            carrerasView.ShowDialog();
        }

        private void iconMenuItem4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void iconMenuItem6_Click(object sender, EventArgs e)
        {
            CiclosLectivosView ciclosLectivosView = new CiclosLectivosView();
            ciclosLectivosView.ShowDialog();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            AlumnosView alumnosView = new AlumnosView();
            alumnosView.ShowDialog();
        }
        private void iconDocente_Click(object sender, EventArgs e)
        {
            DocentesView docentesView = new DocentesView();
            docentesView.ShowDialog();

        }

        private void iconMenuItem7_Click(object sender, EventArgs e)
        {
            HorasView horariosView = new HorasView();
            horariosView.ShowDialog();
        }


        private void turnoExamenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TurnoExamenesView turnoexamenesview = new TurnoExamenesView();
            turnoexamenesview.ShowDialog();
        }



        private void iconMenuItem9_Click(object sender, EventArgs e)
        {
            MateriaView materiaView = new MateriaView();
            materiaView.ShowDialog();
        }

        private void iconMenuItemAniosCarrera_Click(object sender, EventArgs e)
        {
            AnioCarrerasView aniosCarreraView = new AnioCarrerasView();
            aniosCarreraView.ShowDialog();


        }

        private void MenuPrincipalView_Activated(object sender, EventArgs e)
        {
            if (!logueado)
            {
                IniciarSesionView iniciarSesionView = new IniciarSesionView();
                iniciarSesionView.ShowDialog();
                if (!iniciarSesionView.loginSuccessfull)
                {
                    Application.Exit();
                }
                else
                {
                    logueado = true;
                }
            }

        }

        private void iconMenuItem8_Click(object sender, EventArgs e)
        {
            HorariosView horariosView = new HorariosView();
            horariosView.ShowDialog();
        }

        private void iconMenuItem10_Click(object sender, EventArgs e)
        {
            AulasView aulasView = new AulasView();
            aulasView.ShowDialog();
        }
    }
}
