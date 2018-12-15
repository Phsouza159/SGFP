using System;
using System.Collections.Generic;
using System.Text;

namespace SGFP.Domain.Entidades
{
    public class Endereco
    {
        public Endereco(Guid id, string cEP, string andress, string municipio, string complemento, Cidade cidade)
        {
            Id = id;
            CEP = cEP;
            Andress = andress;
            Municipio = municipio;
            Complemento = complemento;
            Cidade = cidade;
        }

        public Guid Id { get; private set; }

        public string CEP { get; private set; }

        public string Andress { get; private set; }

        public string Municipio { get; private set; }

        public string Complemento { get; private set; }

        public Cidade Cidade { get; private set; }
    }
}
