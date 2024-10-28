using InstitutoDesktop.Views;
using InstitutoDesktop.Views.Inscripciones;
using InstitutoDesktop.Views.Horarios;
using InstitutoDesktop.Views.MesasExamenes;

using InstitutoDesktop.Views.Commons.Alumnos;

using InstitutoDesktop.Views.Commons;
using InstitutoDesktop.Views.Commons.AnioCarreras;
using InstitutoDesktop.Views.Commons.Materias;
using InstitutoDesktop.Views.Commons.Aulas;
using InstitutoDesktop.Services;
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
        private readonly MemoryCacheServiceWinForms _cacheService;
        private readonly IServiceProvider _serviceProvider;


        public MenuPrincipalView(MemoryCacheServiceWinForms memoryCacheService, IServiceProvider serviceProvider)
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
                Task.Run(async () => _cacheService.GetAllCacheAsync<Alumno>("Alumnos")),
                Task.Run(async () => _cacheService.GetAllCacheAsync<AnioCarrera>("AniosCarreras")),
                Task.Run(async () =>_cacheService.GetAllCacheAsync<Aula>("Aulas")),
                Task.Run(async () =>_cacheService.GetAllCacheAsync<Carrera>("Carreras")),
                Task.Run(async () =>_cacheService.GetAllCacheAsync<CicloLectivo>("CiclosLectivos")),
                Task.Run(async () =>_cacheService.GetAllCacheAsync<Docente>("Docentes")),
                Task.Run(async () =>_cacheService.GetAllCacheAsync<Hora>("Horas")),
                Task.Run(async () =>_cacheService.GetAllCacheAsync<Horario>("Horarios")),
                Task.Run(async () =>_cacheService.GetAllCacheAsync<IntegranteHorario>("IntegrantesHorarios")),
                Task.Run(async () =>_cacheService.GetAllCacheAsync<JefaturaSeccion>("JefaturasSecciones")),
                Task.Run(async () =>_cacheService.GetAllCacheAsync<Materia>("Materias")),
                Task.Run(async () =>_cacheService.GetAllCacheAsync<TurnoExamen>("TurnosExamenes")),
                Task.Run(async () =>_cacheService.GetAllCacheAsync<Inscripcion>("Inscripciones")),
                Task.Run(async () =>_cacheService.GetAllCacheAsync<DetalleInscripcion>("DetallesInscripciones")),
                Task.Run(async () =>_cacheService.GetAllCacheAsync<MesaExamen>("MesasExamenes")),
                Task.Run(async () =>_cacheService.GetAllCacheAsync<DetalleMesaExamen>("DetallesMesasExamenes")),
                Task.Run(async () =>_cacheService.GetAllCacheAsync<InscripcionExamen>("InscripcionesExamenes")),
                Task.Run(async () =>_cacheService.GetAllCacheAsync<DetalleInscripcionExamen>("DetallesInscripcionesExamenes")),
                Task.Run(async () =>_cacheService.GetAllCacheAsync<PeriodoHorario>("PeriodosHorarios")),

            });


        }

        private void iconMenuItem5_Click(object sender, EventArgs e)
        {
            CarrerasView carrerasView = ActivatorUtilities.CreateInstance<CarrerasView>(_serviceProvider);

            carrerasView.ShowDialog();
        }

        private void iconMenuItem4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void iconMenuItem6_Click(object sender, EventArgs e)
        {
            CiclosLectivosView ciclosLectivosView = ActivatorUtilities.CreateInstance<CiclosLectivosView>(_serviceProvider);
            ciclosLectivosView.ShowDialog();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            AlumnosView alumnosView = ActivatorUtilities.CreateInstance<AlumnosView>(_serviceProvider);
            alumnosView.ShowDialog();
        }
        private void iconDocente_Click(object sender, EventArgs e)
        {
            DocentesView docentesView = ActivatorUtilities.CreateInstance<DocentesView>(_serviceProvider);
            docentesView.ShowDialog();

        }

        private void iconMenuItem7_Click(object sender, EventArgs e)
        {
            HorasView horariosView = ActivatorUtilities.CreateInstance<HorasView>(_serviceProvider);
            horariosView.ShowDialog();
        }


        private void turnoExamenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TurnoExamenesView turnoexamenesview = ActivatorUtilities.CreateInstance<TurnoExamenesView>(_serviceProvider);
            turnoexamenesview.ShowDialog();
        }



        private void iconMenuItem9_Click(object sender, EventArgs e)
        {
            MateriaView materiaView = ActivatorUtilities.CreateInstance<MateriaView>(_serviceProvider);
            materiaView.ShowDialog();
        }

        private void iconMenuItemAniosCarrera_Click(object sender, EventArgs e)
        {
            AnioCarrerasView aniosCarreraView = ActivatorUtilities.CreateInstance<AnioCarrerasView>(_serviceProvider);
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
            HorariosView horariosView = ActivatorUtilities.CreateInstance<HorariosView>(_serviceProvider);
            horariosView.ShowDialog();
        }

        private void iconMenuItem10_Click(object sender, EventArgs e)
        {
            AulasView aulasView = ActivatorUtilities.CreateInstance<AulasView>(_serviceProvider);
            aulasView.ShowDialog();
        }

        private void iconMenuPeriodoHorario_Click(object sender, EventArgs e)
        {
            PeriodoHorarioView periodoHorarioView = ActivatorUtilities.CreateInstance<PeriodoHorarioView>(_serviceProvider);
            periodoHorarioView.ShowDialog();
        }
    }
}
