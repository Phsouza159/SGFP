using prmToolkit.NotificationPattern;
using System;

namespace SGFP.Domain.Entidades
{
    public class Documento : Notifiable 
    {
        protected Documento()
        {

        }

        public Guid Id { get; set; }
    }
}