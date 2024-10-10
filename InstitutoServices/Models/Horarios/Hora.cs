﻿using InstitutoServices.Interfaces.MesasExamenes;
using System.ComponentModel.DataAnnotations.Schema;

namespace InstitutoServices.Models.Horarios
{
    public class Hora : IEntityIdNombre
    {
        public int Id { get; set; }
        [NotMapped]

        private string nombre;

        public string Nombre
        {
            get { return EsRecreo ? "Recreo" : "" + $"{Desde.Hour} : {Desde.Minute} - {Hasta.Hour} : {Hasta.Minute}"; }
            set { nombre = value; }

        }

        public DateTime Desde { get; set; } = DateTime.MinValue;
        public DateTime Hasta { get; set; } = DateTime.MinValue;    
        public bool EsRecreo { get; set; } = false;
        public bool Eliminado { get; set; } = false;


        public override string ToString()
        {
            return Nombre;
        }
    }
}
