using InstitutoServices.Interfaces;
using InstitutoServices.Models.Inscripciones;

namespace InstitutoServices.Models.Commons
{
    public class Alumno : IEntityWithId
    {
        public int Id { get; set; }
        public string ApellidoNombre { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public bool Eliminado { get; set; } = false;

        public ICollection<InscriptoCarrera> InscripcionesACarreras { get; set; } = new List<InscriptoCarrera>();


        public override string ToString()
        {
            return ApellidoNombre;
        }

    }
}
