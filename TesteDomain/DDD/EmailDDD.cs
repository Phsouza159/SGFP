using SGFP.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace TesteDomain.DDD
{
    public class EmailDDD : BaseDDD<Email>
    {
        public EmailDDD()
        {
            Console.WriteLine("------------- Email -----------------");

            Email email = new Email(new Guid(), "Paulo@paulo.com", "123456");

            PrintVar(email);

            getNotifable(email);

            Console.WriteLine("-------------------------------------------");
        }
        public void PrintVar(Email email)
        {
            Console.WriteLine("Email endereco {0} \n", email.Endereco);

            Console.WriteLine("Email senha {0} \n", email.Senha);
        }
    }
}
