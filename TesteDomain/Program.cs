using SGFP.Domain.Arguments.Request;
using SGFP.Domain.Entidades;
using System;
using System.Linq;
using TesteDomain.DDD;

namespace TesteDomain
{
    class Program
    {
        static void Main(string[] args)
        {
            new ClienteDDD();

            new FuncionarioDDD();

            new EmailDDD();

            new AvaliacaoDDD();

            new CarroDDD();

            new EnderecoDDD();

            new MaoDeObraDDD();

            Console.ReadKey();

        }
    }
}
