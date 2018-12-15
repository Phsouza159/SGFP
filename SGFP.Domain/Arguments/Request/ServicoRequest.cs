using System;
using System.Collections.Generic;
using System.Text;

namespace SGFP.Domain.Arguments.Request
{
    public class ServicoRequest
    {
        public ServicoRequest(Guid id, string nomeServico, double valor)
        {
            Id      = id;
            NomeServico = nomeServico;
            Valor   = valor;
        }

        public Guid Id { get;  set; }

        public string NomeServico { get;  set; }

        public double Valor { get;  set; }
    }
}
