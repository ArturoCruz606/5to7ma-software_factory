using System.Collections.Generic;
namespace softwareFactory.Core
{
    public interface IAdo
    {
        void AltaCliente(Cliente cliente);

        List<Cliente> ObtenerClientes();        
    }
}