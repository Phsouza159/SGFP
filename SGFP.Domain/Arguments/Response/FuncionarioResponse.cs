using System;
using System.Collections.Generic;
using System.Text;

namespace SGFP.Domain.Arguments.Response
{
    public class FuncionarioResponse
    {
        public FuncionarioResponse(Guid id, string nome, int permissao)
        {
            Id        = id;
            Nome      = nome;
            Permissao = permissao;
        }

        public Guid Id { get; private set; }

        public string Nome { get; private set; }

        public int Permissao { get; private set; }
    }
}
