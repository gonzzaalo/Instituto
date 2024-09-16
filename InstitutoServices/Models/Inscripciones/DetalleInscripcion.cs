using InstitutoServices.Enums;
using InstitutoServices.Models.Commons;
using System.ComponentModel.DataAnnotations.Schema;

namespace InstitutoServices.Models.Inscripciones
{
    public class DetalleInscripcion
    {
        public int Id { get; set; }
        public ModalidadCursadoEnum ModalidadCursado { get; set; }
        public int InscripcionId { get; set; }
        public Inscripcion? Inscripcion { get; set; }
        public int MateriaId { get; set; }
        public Materia? Materia { get; set; }
        public bool Eliminado { get; set; } = false;


        public override string ToString()
        {
            return $"{Materia?.Nombre} {ModalidadCursado}" ?? string.Empty;
        }

    }
}
