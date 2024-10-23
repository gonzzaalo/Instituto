using InstitutoServices.Interfaces;
using InstitutoServices.Models.Commons;
using InstitutoServices.Models.Horarios;
using InstitutoServices.Models.Inscripciones;
using InstitutoServices.Models.MesasExamenes;
using InstitutoServices.Services.Commons;
using InstitutoServices.Services.MesasExamenes;

namespace InstitutoWeb.Services.Commons
{
    public class MemoryCacheService: IMemoryCacheService
    {
        IGenericService<Carrera> CarreraService = new GenericService<Carrera>();
        IGenericService<AnioCarrera> AnioCarreraService = new GenericService<AnioCarrera>();
        IGenericService<Materia> MateriaService = new GenericService<Materia>();
        IGenericService<CicloLectivo> CicloLectivoService = new GenericService<CicloLectivo>();
        IGenericService<TurnoExamen> TurnoExamenService = new GenericService<TurnoExamen>();
        IGenericService<Hora> HoraService = new GenericService<Hora>();
        IGenericService<Docente> DocenteService = new GenericService<Docente>();
        IGenericService<JefaturaSeccion> JefaturaSeccionService = new GenericService<JefaturaSeccion>();
        IGenericService<Inscripcion> InscripcionService = new GenericService<Inscripcion>();
        IGenericService<DetalleInscripcion> DetalleInscripcionService = new     GenericService<DetalleInscripcion>();
        IGenericService<MesaExamen> MesaExamenService = new GenericService<MesaExamen>();
        IGenericService<DetalleMesaExamen> DetalleMesaExamenService = new GenericService<DetalleMesaExamen>();
        IGenericService<Aula> AulaService = new GenericService<Aula>();
        IGenericService<Horario> HorarioService = new GenericService<Horario>();
        IGenericService<DetalleHorario> DetalleHorarioService = new GenericService<DetalleHorario>();
        IGenericService<IntegranteHorario> IntegranteHorarioService = new GenericService<IntegranteHorario>();


        public List<Carrera>? Carreras { get; set; } = new List<Carrera>();
        public List<AnioCarrera>? AniosCarreras { get; set; } = new List<AnioCarrera>();
        public List<Materia>? Materias { get; set; } = new List<Materia>();
        public List<CicloLectivo>? CiclosLectivos { get; set; } = new List<CicloLectivo>();
        public List<TurnoExamen>? TurnosExamenes { get; set; } = new List<TurnoExamen>();
        public List<Hora>? Horas { get; set; } = new List<Hora>();
        public List<Docente>? Docentes { get; set; } = new List<Docente>();
        public List<JefaturaSeccion>? JefaturasSecciones { get; set; } = new List<JefaturaSeccion>();
        public List<Inscripcion>? Inscripciones { get; set; } = new List<Inscripcion>();
        public List<DetalleInscripcion>? DetallesInscripciones { get; set; } = new List<DetalleInscripcion>();
        public List<MesaExamen>? MesasExamenes { get; set; } = new List<MesaExamen>();
        public List<DetalleMesaExamen>? DetallesMesasExamenes { get; set; } = new List<DetalleMesaExamen>();
        public List<Aula>? Aulas { get; set; } = new List<Aula>();
        public List<Horario>? Horarios { get; set; } = new List<Horario>();
        public List<DetalleHorario>? DetallesHorarios { get; set; } = new List<DetalleHorario>();
        public List<IntegranteHorario>? IntegrantesHorarios { get; set; } = new List<IntegranteHorario>();

        public  MemoryCacheService()
        {
            GetCacheLists();



        }

        private async Task GetCacheLists()
        {
            //obtengo las carreras, anios, materias, ciclos lectivos, turnos examenes, horas, docentes, jefaturas secciones, en forma parelela
            var tareas = new List<Task>()
            {
                Task.Run(async () => Carreras = await CarreraService.GetAllAsync()),
                Task.Run(async () => AniosCarreras = await AnioCarreraService.GetAllAsync()),
                Task.Run(async () => Materias = await MateriaService.GetAllAsync()),
                Task.Run(async () => CiclosLectivos = await CicloLectivoService.GetAllAsync()),
                Task.Run(async () => TurnosExamenes = await TurnoExamenService.GetAllAsync()),
                Task.Run(async () => Horas = await HoraService.GetAllAsync()),
                Task.Run(async () => Docentes = await DocenteService.GetAllAsync()),
                Task.Run(async () => JefaturasSecciones = await JefaturaSeccionService.GetAllAsync()),
                Task.Run(async () => Aulas = await AulaService.GetAllAsync()),
                Task.Run(async () => MesasExamenes = await MesaExamenService.GetAllAsync()),
                Task.Run(async () => DetallesMesasExamenes = await DetalleMesaExamenService.GetAllAsync()),
                Task.Run(async () => Horarios = await HorarioService.GetAllAsync()),
                Task.Run(async () => DetallesHorarios = await DetalleHorarioService.GetAllAsync()),
                Task.Run(async () => IntegrantesHorarios = await IntegranteHorarioService.GetAllAsync())

            };
            await Task.WhenAll(tareas);
        }
    }
}
