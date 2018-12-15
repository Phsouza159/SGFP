using System;
using System.Collections.Generic;
using System.Text;

namespace SGFP.Domain.Entidades
{
    public class Telefone
    {
        public Telefone(Guid id, string dDD, string numero, int tipoTelefone)
        {
            Id = id;
            DDD = dDD;
            Numero = numero;
            TipoTelefone = tipoTelefone;
        }

        public Guid Id { get; private set; }

        public string DDD { get; private set; }

        public string Numero { get; private set; }

        public int TipoTelefone { get; private set; }

    }
}
