using prmToolkit.NotificationPattern;
using SGFP.Domain.Arguments.Request;
using SGFP.Domain.Entidades.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGFP.Domain.Entidades
{
    public class Carro : Notifiable
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


            new AddNotifications<Carro>(this)
                       .IfNull(p => p.Dono)
                       .IfNull(p => p.Placa)
                       .IfLengthLowerThan(p => p.Placa, 8 )
                       .IfNull(p => p.Chassi)
                       .IfLengthLowerThan(p => p.Chassi, 16 )
                       .IfNull(p => p.Cor)
                       .IfNull(p => p.Marca)
                       .IfNull(p => p.Modelo)
                       .IfNull(p => p.AnoFabricao);
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
