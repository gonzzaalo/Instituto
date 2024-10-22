using InstitutoServices.Models.Commons;
using InstitutoServices.Models.Horarios;
using InstitutoServices.Models.Inscripciones;
using InstitutoServices.Models.MesasExamenes;

namespace InstitutoWeb.Services.Commons
{
    public interface IMemoryCacheService
    {
        List<Carrera>? Carreras { get; set; }
        List<AnioCarrera>? AniosCarreras { get; set; }
        List<Materia>? Materias { get; set; }
        List<CicloLectivo>? CiclosLectivos { get; set; }
        List<TurnoExamen>? TurnosExamenes { get; set; }
        List<Hora>? Horas { get; set; }
        List<Docente>? Docentes { get; set; }
        List<JefaturaSeccion>? JefaturasSecciones { get; set; }
        List<Inscripcion>? Inscripciones { get; set; }
        List<DetalleInscripcion>? DetallesInscripciones { get; set; }
        List<MesaExamen>? MesasExamenes { get; set; }
        List<DetalleMesaExamen>? DetallesMesasExamenes { get; set; }
        List<Aula>? Aulas { get; set; }
    }
}