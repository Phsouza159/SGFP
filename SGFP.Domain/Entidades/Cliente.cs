using SGFP.Domain.Arguments.Request;
using SGFP.Domain.Entidades.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGFP.Domain.Entidades
{
    public class Cliente : Pessoa
    {
        public Cliente()
            :base()
        {

        }

        public Cliente(ClienteRequest clienteRequest)
                : base(clienteRequest)
        {
            Carro = clienteRequest.Carro;
        }

        public Carro Carro { get; private set; }

        public Avaliacao Avaliacao { get; private set; }
    }
}
