using prmToolkit.NotificationPattern;
using SGFP.Domain.Arguments.Request;
using System;

namespace SGFP.Domain.Entidades
{
    public class Avaliacao : Notifiable
    {

        protected Avaliacao()
        {

        }

        public Avaliacao(AvaliacaoRequest avalicaoRequest)
        {
            Id = avalicaoRequest.Id;
            Nota = avalicaoRequest.Nota;
            Texto = avalicaoRequest.Texto;

            new AddNotifications<Avaliacao>(this)
                .IfEqualsZero(p => p.Nota)
                .IfNull(p => p.Texto);
        }

        public Guid Id { get; private set; }

        public int Nota { get; private set; }

        public string Texto { get; private set; }
    }
}
