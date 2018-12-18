using SGFP.Domain.Entidades.Base;
using System;

namespace SGFP.Domain.Arguments.Request
{
    public class CarroRequest
    {
        public CarroRequest()
        {

        }

        public CarroRequest(Guid id, Pessoa dono, string placa, string chassi, string cor, string marca, string modelo, DateTime anoFabricao)
        {
            Id = id;
            Dono = dono;
            Placa = placa;
            Chassi = chassi;
            Cor = cor;
            Marca = marca;
            Modelo = modelo;
            AnoFabricao = anoFabricao;
        }

        public Guid Id { get; set; }

        public Pessoa Dono { get; set; }

        public string Placa { get; set; }

        public string Chassi { get; set; }

        public string Cor { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public DateTime AnoFabricao { get; set; }
    }
}
