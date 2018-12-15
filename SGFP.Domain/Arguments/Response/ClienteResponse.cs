using SGFP.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGFP.Domain.Arguments.Response
{
    public class ClienteResponse
    {
        public ClienteResponse(Cliente cliente)
        {
            Cliente = cliente;
        }

        public Cliente Cliente { get; private set; }
    }
}
