using SGFP.Domain.Arguments.Request;
using SGFP.Domain.Entidades.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGFP.Domain.Entidades
{
    public class Orcamento
    {
        public Orcamento(OrcamentoRequest orcamentoRequest)
        {
            Id          = orcamentoRequest.Id;
            Cliente     = orcamentoRequest.Cliente;
            Carro       = orcamentoRequest.Carro;
            Servico     = orcamentoRequest.Servico;
            ListaOrcamento = orcamentoRequest.ListaOrcamento;
            Documento   = orcamentoRequest.Documento;
            Entrada     = orcamentoRequest.Entrada;
            Entrega     = orcamentoRequest.Entrega;
            ValorOrcamento = orcamentoRequest.ValorOrcamento;
        }

        public Guid Id { get; private set; }

        public Pessoa Cliente { get; private set; }

        public Carro Carro { get; private set; }

        public Servico Servico { get; private set; }

        public string ListaOrcamento { get; private set; }

        public Documento Documento { get; private set; }

        public DateTime Entrada { get; private set; }

        public DateTime Entrega { get; private set; }

        public double ValorOrcamento { get; private set; }

        public int Status { get; private set; }

    }
}
