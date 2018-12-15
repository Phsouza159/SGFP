using SGFP.Domain.Arguments.Request;
using System;

namespace SGFP.Domain.Entidades
{
    public class Servico
    {
        public Servico(ServicoRequest servicoRequest)
        {
            Id      = servicoRequest.Id;
            NomeServico = servicoRequest.NomeServico;
            Valor   = servicoRequest.Valor;
        }

        public Guid Id { get; private set; }

        public string NomeServico { get; private set; }

        public double Valor { get; private set; }
    }
}