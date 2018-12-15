using SGFP.Domain.Arguments.Request;
using SGFP.Domain.Entidades.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGFP.Domain.Entidades
{
    public class Funcionario : Pessoa
    {
        public Funcionario(FuncionarioRequest funcionarioRequest)
            : base(funcionarioRequest)
        {
            Categoria = funcionarioRequest.Categoria;
        }

        public int Categoria { get; private set; }
    }
}
