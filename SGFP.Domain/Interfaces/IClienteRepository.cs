using SGFP.Domain.Arguments.Request;
using SGFP.Domain.Arguments.Response;
using SGFP.Domain.Entidades;
using SGFP.Domain.Interfaces.Commom;

namespace SGFP.Domain.Interfaces
{
    public interface IClienteRepository : IBaseRepository<Cliente>
    {
        ClienteResponse getByCPF(string CPF);
        bool VincularCarro(Carro carro , Cliente cliente);
        bool DesvincularCarro(Carro carro, Cliente cliente);
    }
}
