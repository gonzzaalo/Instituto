using System.ComponentModel.DataAnnotations.Schema;
using InstitutoServices.Enums;
using InstitutoServices.Models.Commons;

namespace InstitutoServices.Models.MesasExamenes
{
    public class DetalleMesaExamen
    {
        public int Id { get; set; }
        public int MesaExamenId { get; set; }
        public MesaExamen? MesaExamen { get; set; }
        public int DocenteId { get; set; }
        public Docente? Docente { get; set; }
        public TipoIntegranteEnum TipoIntegrante { get; set; }
        public bool Eliminado { get; set; } = false;


        public override string ToString()
        {
            return $"{Docente?.Nombre} {TipoIntegrante}" ?? string.Empty;
        }

    }
}
