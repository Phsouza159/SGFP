using prmToolkit.NotificationPattern;
using System;

namespace SGFP.Domain.Interfaces.Commom
{
    public abstract class RepositoryPropriedades : Notifiable
    {
        public Guid Id { get; set; }
        public bool Ativo { get; set; }
    }
}
