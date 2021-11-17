using System;
using System.Collections.Generic;
namespace softwareFactory.Core
{
    public class Empleado
    {
        public int Cuil { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Contratacion { get; set; }
        public List<Experiencia> Experiencias { get; set; }
        public Empleado()
        {
            Experiencias = new List<Experiencia>();
        }
    }
}