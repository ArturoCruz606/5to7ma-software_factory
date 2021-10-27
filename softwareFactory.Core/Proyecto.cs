using System;
using System.Collections.Generic;
namespace softwareFactory.Core
{
    public class Proyecto
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public string Descripcion { get; set; }
        public decimal Presupuesto { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
        public List<Requerimiento> Requerimientos { get; set; }
    }
}