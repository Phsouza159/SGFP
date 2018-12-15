using SGFP.Domain.Arguments.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGFP.Domain.Entidades
{
    public class MaoDeObra
    {
        public MaoDeObra(MaoDeObraRequest maoDeObraRequest)
        {
            Id              = maoDeObraRequest.Id;
            TipoMaoObra     = maoDeObraRequest.TipoMaoObra;
            Nome            = maoDeObraRequest.Nome;
            Valor           = maoDeObraRequest.Valor;
            JornadaTrabalho = maoDeObraRequest.JornadaTrabalho;
            ValorHoraExtra  = maoDeObraRequest.ValorHoraExtra;
            LimiteHoraExtra = maoDeObraRequest.LimiteHoraExtra;
        }

        public Guid Id { get; private set; }

        public string TipoMaoObra { get; private set; }

        public string Nome { get; private set; }

        public double Valor { get; private set; }

        public double JornadaTrabalho { get; private set; }

        public double ValorHoraExtra { get; private set; }

        public double LimiteHoraExtra { get; private set; }

        public bool Ativo { get; set; }

    }
}
