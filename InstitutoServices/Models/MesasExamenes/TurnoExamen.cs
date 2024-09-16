//using InstitutoServices.Interfaces.Commons;


//using InstitutoServices.Interfaces.Commons;

using InstitutoServices.Interfaces.MesasExamenes;

namespace InstitutoServices.Models.MesasExamenes
{
    public class TurnoExamen : IEntityIdNombre
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public bool Eliminado { get; set; } = false;


        public override string ToString()
        {
            return Nombre;
        }
    }
}
