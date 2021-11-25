using System;
using softwareFactory.Core;
using et12.edu.ar.AGBD.Ado;
using System.Collections.Generic;

namespace softwareFactory.AdoMySQL
{
    public class AdoSoftware: IAdo
    {
        public AdoAGBD Ado { get; set; }
        public MapCliente MapCliente { get; set; }
        public AdoSoftware(AdoAGBD ado)
        {
            Ado = ado;
            MapCliente = new MapCliente(Ado);
        }
        public void AltaCliente(Cliente cliente) => MapCliente.AltaCliente(cliente);
        public List<Cliente> ObtenerClientes() => MapCliente.ObtenerClientes();
    }
}
