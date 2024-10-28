using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoServices.Models.Inscripciones
{
    public class PeriodoInscripcion
    {
        public int Id{ get; set; }
        public string Nombre { get; set; } = string.Empty;
        public int? CicloLectivoId { get; set; }
        public CicloLectivo? CicloLectivo { get; set; }
        public bool InscripcionHabilitada { get; set; }
        public bool SoloMaterias2doCuatrimestre { get; set; }
        public bool Eliminado { get; set; } = false;

    }
}
