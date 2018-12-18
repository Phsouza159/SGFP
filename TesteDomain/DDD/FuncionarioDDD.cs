using SGFP.Domain.Arguments.Request;
using SGFP.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace TesteDomain.DDD
{
    class FuncionarioDDD : BaseDDD<Funcionario>
    {
        public FuncionarioDDD()
        {
            Console.WriteLine("------------- FUNCIONARIO ----------------- \n");

            FuncionarioRequest funcionarioRequest = new FuncionarioRequest();

            funcionarioRequest.PrimeiroNome = "Caio";

            funcionarioRequest.UltimoNome = "Lucas";

            funcionarioRequest.CPF = "06411166161";

            funcionarioRequest.RG = "3481627";

            Funcionario funcionario = new Funcionario(funcionarioRequest);

            PrintVar(funcionario);

            getNotifable(funcionario);

            Console.WriteLine("------------------------------------------- \n");
        }

        private void PrintVar(Funcionario funcionario)
        {
            Console.WriteLine("nome Funcionario {0} \n", funcionario.PrimeiroNome);

            Console.WriteLine("sobrenome Funcionario {0} \n", funcionario.UltimoNome);

            Console.WriteLine("CPF Funcionario {0} \n", funcionario.CPF);

            Console.WriteLine("RG Funcionario {0} \n", funcionario.RG);

        }
    }
}
