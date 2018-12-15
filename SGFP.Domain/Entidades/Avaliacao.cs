using SGFP.Domain.Arguments.Request;
using System;

namespace SGFP.Domain.Entidades
{
    public class Avaliacao
    {
        public Avaliacao(AvaliacaoRequest avalicaoRequest)
        {
            Id = avalicaoRequest.Id;
            Nota = avalicaoRequest.Nota;
            Texto = avalicaoRequest.Texto;
        }

        public Guid Id { get; private set; }

        public double Nota { get; private set; }

        public string Texto { get; private set; }
    }
}
