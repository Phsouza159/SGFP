using System;

namespace SGFP.Domain.Arguments.Request
{
    public class MaoDeObraRequest
    {
        public MaoDeObraRequest()
        {

        }

        public MaoDeObraRequest(Guid id, string tipoMaoObra, string nome, double valor, double jornadaTrabalho, double valorHoraExtra, double limiteHoraExtra)
        {
            Id          = id;
            TipoMaoObra = tipoMaoObra;
            Nome        = nome;
            Valor       = valor;
            JornadaTrabalho = jornadaTrabalho;
            ValorHoraExtra  = valorHoraExtra;
            LimiteHoraExtra = limiteHoraExtra;
        }

        public Guid Id { get;  set; }

        public string TipoMaoObra { get;  set; }

        public string Nome { get;  set; }

        public double Valor { get;  set; }

        public double JornadaTrabalho { get;  set; }

        public double ValorHoraExtra { get;  set; }

        public double LimiteHoraExtra { get;  set; }

    }
}
