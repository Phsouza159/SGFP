using SGFP.Domain.Arguments.Request;
using SGFP.Domain.Entidades;
using System;

namespace TesteDomain.DDD
{
    public class ClienteDDD : BaseDDD<Cliente> 
    {
        public ClienteDDD()
        {
            Console.WriteLine("------------------- CLIENTE ------------------ \n");

            ClienteRequest ClienteRequest = new ClienteRequest();


            ClienteRequest.PrimeiroNome = "Paulo";

            ClienteRequest.UltimoNome = "Souza";

            Cliente cliente = new Cliente(ClienteRequest);

            PrintVar(cliente);

            getNotifable(cliente);

            Console.WriteLine("------------------------------------------- \n");
        }

        private void PrintVar(Cliente cliente)
        {
            Console.WriteLine("nome cliente {0} \n", cliente.PrimeiroNome);

            Console.WriteLine("sobrenome cliente {0} \n", cliente.UltimoNome);

            Console.WriteLine("CPF Funcionario {0} \n", cliente.CPF);

            Console.WriteLine("RG Funcionario {0} \n", cliente.RG);

        }

    }
}
