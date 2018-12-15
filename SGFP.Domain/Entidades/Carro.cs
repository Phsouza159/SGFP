using SGFP.Domain.Arguments.Request;
using SGFP.Domain.Entidades.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGFP.Domain.Entidades
{
    public class Carro
    {
        public Carro(CarroRequest carroRequest)
        {
            Id          = carroRequest.Id;
            Dono        = carroRequest.Dono;
            Placa       = carroRequest.Placa;
            Chassi      = carroRequest.Chassi;
            Cor         = carroRequest.Cor;
            Marca       = carroRequest.Marca;
            Modelo      = carroRequest.Modelo;
            AnoFabricao = carroRequest.AnoFabricao;
        }

        public Guid Id { get; private set; }

        public Pessoa Dono { get; private set; }

        public string Placa { get; private set; }

        public string Chassi { get; private set; }

        public string Cor { get; private set; }

        public string Marca { get; private set; }

        public string Modelo { get; private set; }

        public DateTime AnoFabricao { get; private set; }
    }
}
