using SGFP.Domain.Entidades;
using SGFP.Domain.Entidades.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGFP.Domain.Arguments.Request
{
    public class OrcamentoRequest
    {
        public OrcamentoRequest()
        {

        }

        public OrcamentoRequest(Guid id, Pessoa cliente, Carro carro, Servico servico, string listaOrcamento, Documento documento, DateTime entrada, DateTime entrega, double valorOrcamento, int status)
        {
            Id = id;
            Cliente = cliente;
            Carro = carro;
            Servico = servico;
            ListaOrcamento = listaOrcamento;
            Documento = documento;
            Entrada = entrada;
            Entrega = entrega;
            ValorOrcamento = valorOrcamento;
            Status = status;
        }

        public Guid Id { get;  set; }

        public Pessoa Cliente { get;  set; }

        public Carro Carro { get;  set; }

        public Servico Servico { get;  set; }

        public string ListaOrcamento { get;  set; }

        public Documento Documento { get;  set; }

        public DateTime Entrada { get;  set; }

        public DateTime Entrega { get;  set; }

        public double ValorOrcamento { get;  set; }

        public int Status { get; private set; }
    }
}
