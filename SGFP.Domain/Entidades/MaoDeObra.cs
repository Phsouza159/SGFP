using prmToolkit.NotificationPattern;
using SGFP.Domain.Arguments.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGFP.Domain.Entidades
{
    public class MaoDeObra : Notifiable
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
            Ativo = true;

            new AddNotifications<MaoDeObra>(this)
                    .IfNull(p => p.TipoMaoObra)
                    .IfNull(p => p.Nome)
                    .IfNull(p => p.Valor);

            if (Valor == 0)
                AddNotification("Valor", "Propriedade Valor não pode ser igual a zero");

            if (JornadaTrabalho == 0)
                AddNotification("JornadaTrabalho", "Propriedade JornadaTrabalho não pode ser igual a zero");

            if (LimiteHoraExtra == 0)
                AddNotification("LimiteHoraExtra", "LimiteHoraExtra JornadaTrabalho não pode ser igual a zero");

        }

        public Guid Id { get; private set; }

        public string TipoMaoObra { get; private set; }

        public string Nome { get; private set; }

        public double? Valor { get; private set; }

        public double? JornadaTrabalho { get; private set; }

        public double? ValorHoraExtra { get; private set; }

        public double? LimiteHoraExtra { get; private set; }

        public bool Ativo { get; set; }

    }
}
