using SGFP.Domain.Arguments.Request;
using SGFP.Domain.Entidades;
using System;

namespace TesteDomain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ClienteRequest ClienteRequest = new ClienteRequest();

            ClienteRequest.PrimeiroNome = "Paulo";
            ClienteRequest.UltimoNome = "Souza";

            Cliente cliente = new Cliente(ClienteRequest);

            Console.WriteLine("nome cliente {0}", cliente.PrimeiroNome);
            Console.WriteLine("sobrenome cliente {0}", cliente.UltimoNome);
            Console.WriteLine("-------------------------------------------");

                if (cliente.IsInvalid())
                    foreach (var c in cliente.Notifications)
                    {
                         Console.WriteLine("propriedade invalida : {0} . Menssagm {1}", c.Property , c.Message);
                    }

            Console.WriteLine("-------------------------------------------");

            FuncionarioRequest funcionarioRequest = new FuncionarioRequest();

            funcionarioRequest.PrimeiroNome = "Caio";
            funcionarioRequest.UltimoNome = "Lucas";
            funcionarioRequest.CPF = "06411166161";
            funcionarioRequest.RG = "3481627";
            Funcionario funcionario = new Funcionario(funcionarioRequest);

            Console.WriteLine("nome Funcionario {0}", funcionario.PrimeiroNome);
            Console.WriteLine("sobrenome Funcionario {0}", funcionario.UltimoNome);

            Console.WriteLine("-------------------------------------------");

            if (cliente.IsInvalid())
                foreach (var c in funcionario.Notifications)
                {
                    Console.WriteLine("propriedade invalida : {0} . Menssagm {1}", c.Property, c.Message);
                }

            Console.WriteLine("-------------------------------------------");

            Console.ReadKey();
        }
    }
}
