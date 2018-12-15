using SGFP.Domain.Arguments.Response;
using SGFP.Domain.Entidades;
using SGFP.Domain.Interfaces.Commom;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGFP.Domain.Interfaces
{
    public interface IFuncionarioRepository : IBaseRepository<Funcionario>
    {
        FuncionarioResponse AutenticarFuncionario(string user, string senha);
    }
}
