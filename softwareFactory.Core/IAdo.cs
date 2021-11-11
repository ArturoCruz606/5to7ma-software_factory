using System.Collections.Generic;
namespace softwareFactory.Core
{
    public interface IAdo
    {
        void AltaCliente(Cliente cliente);

        void AltaProyecto(Proyecto proyecto);

        List<Cliente> ObtenerClientes();

        List<Proyecto> ObtenerProyectos();
    }
}