using SGFP.Domain.Arguments.Request;
using SGFP.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace TesteDomain.DDD
{
    class CarroDDD : BaseDDD<Carro>
    {
        public CarroDDD()
        {
            Console.WriteLine("------------- Carro ----------------- \n");

            CarroRequest carroRequest = new CarroRequest();


            carroRequest.AnoFabricao = DateTime.Now;

            carroRequest.Marca = "Gol";

            carroRequest.Chassi = "12345678910111213141516";

            carroRequest.Dono = new Cliente();

            carroRequest.Cor = "Branco";

            carroRequest.Modelo = "Gol";

            carroRequest.Placa = "OVS-3344";

            Carro avaliacao = new Carro(carroRequest);


            PrintVar(avaliacao);

            getNotifable(avaliacao);


            Console.WriteLine("------------------------------------------- \n");
        }
        private void PrintVar(Carro carro)
        {
            Console.WriteLine("Marca  do carro {0} \n", carro.Marca);

            Console.WriteLine("Modelo  do carro {0} \n", carro.Modelo);

            Console.WriteLine("Cor  do carro {0} \n", carro.Cor);

            Console.WriteLine("Placa  do carro {0} \n", carro.Placa);

            Console.WriteLine("Ano de Fabricao  do carro {0} \n", carro.AnoFabricao);

            Console.WriteLine("Chassi  do carro {0} \n", carro.Chassi);

            Console.WriteLine("Dono  do carro {0} \n", carro.Dono);

        }
    }
}
