using System;

namespace SGFP.Domain.Entidades
{
    public class Pais
    {
        public Pais(Guid id, string sigla, string nome)
        {
            Id = id;
            Sigla = sigla;
            Nome = nome;
        }

        public Guid Id { get; private set; }

        public string Sigla { get; private set; }

        public string Nome { get; private set; }
    }
}