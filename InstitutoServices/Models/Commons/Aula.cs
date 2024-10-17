using InstitutoServices.Interfaces.MesasExamenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoServices.Models.Commons
{
    public class Aula : IEntityIdNombre
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
