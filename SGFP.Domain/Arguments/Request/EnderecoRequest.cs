using SGFP.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGFP.Domain.Arguments.Request
{
    public class EnderecoRequest
    {
        public EnderecoRequest()
        {

        }

        public EnderecoRequest(Guid id, string cEP, string andress, string municipio, string complemento, Cidade cidade)
        {
            Id = id;
            CEP = cEP;
            Andress = andress;
            Municipio = municipio;
            Complemento = complemento;
            Cidade = cidade;
        }

        public Guid Id { get;  set; }

        public string CEP { get;  set; }

        public string Andress { get;  set; }

        public string Municipio { get;  set; }

        public string Complemento { get;  set; }

        public Cidade Cidade { get;  set; }
    }
}
