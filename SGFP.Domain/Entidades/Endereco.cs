using prmToolkit.NotificationPattern;
using SGFP.Domain.Arguments.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGFP.Domain.Entidades
{
    public class Endereco : Notifiable
    {
        public Endereco(EnderecoRequest enderecoRequest)
        {
            Id          = enderecoRequest.Id;
            CEP         = enderecoRequest.CEP;
            Andress     = enderecoRequest.Andress;
            Municipio   = enderecoRequest.Municipio;
            Complemento = enderecoRequest.Complemento;
            Cidade      = enderecoRequest.Cidade;

            new AddNotifications<Endereco>(this)
                .IfNull(p => p.CEP)
                .IfLengthLowerThan(p => p.CEP, 9)
                .IfNull(p => p.Andress)
                .IfNull(p => p.Municipio)
                .IfNull(p => p.Complemento)
                .IfNull(p => p.Cidade);

        }

        public Guid Id { get; private set; }

        public string CEP { get; private set; }

        public string Andress { get; private set; }

        public string Municipio { get; private set; }

        public string Complemento { get; private set; }

        public Cidade Cidade { get; private set; }
    }
}
