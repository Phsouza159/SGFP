using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGFP.Domain.Entidades
{
    public class Email : Notifiable
    {
        public Email(Guid id, string endereco, string senha)
        {
            Id       = id;
            Endereco = endereco;
            Senha    = senha;

            new AddNotifications<Email>(this)
                .IfNotEmail(p => p.Endereco, "Informe um email válido ")
                .IfNullOrInvalidLength(p => p.Senha, 6, 32, "Infrome uma senha entre 6 e 32 caracters");
        }

        public Guid Id { get; private set; }

        public string Endereco { get; private set; }

        public string Senha { get; private set; }
    }
}
