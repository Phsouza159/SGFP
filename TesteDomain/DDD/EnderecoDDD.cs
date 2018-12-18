using SGFP.Domain.Arguments.Request;
using SGFP.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace TesteDomain.DDD
{
    public class EnderecoDDD : BaseDDD<Endereco>
    {
        public EnderecoDDD()
        {

            Console.WriteLine("------------- Endereco ----------------- \n");

            EnderecoRequest enderecoRequest = new EnderecoRequest();


            enderecoRequest.Cidade = new Cidade();

            enderecoRequest.CEP = "722202-411";

            enderecoRequest.Andress = "Ceilandia";

            enderecoRequest.Complemento = "Sul";

            enderecoRequest.Municipio = "Brasilia";


            Endereco endereco = new Endereco(enderecoRequest);


            PrintVar(endereco);

            getNotifable(endereco);


            Console.WriteLine("------------------------------------------- \n");
        }
        private void PrintVar(Endereco endereco)
        {
            Console.WriteLine("CEP  {0} \n", endereco.CEP);

            Console.WriteLine("Endereço  {0} \n", endereco.Andress);

            Console.WriteLine("Complemento  {0} \n", endereco.Complemento);

            Console.WriteLine("Municipio  {0} \n", endereco.Municipio);

            Console.WriteLine("Cidade  {0} \n", endereco.Cidade);
        }
    }
}
