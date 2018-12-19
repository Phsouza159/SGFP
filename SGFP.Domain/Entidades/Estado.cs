using System;

namespace SGFP.Domain.Entidades
{
    public class Estado
    {
        public Estado()
        {

        }

        public Estado(Guid id, string sigla, string nome, Pais pais)
        {
            Id = id;
            Sigla = sigla;
            Nome = nome;
            Pais = pais;
        }

        public Guid Id { get; private set; }

        public string Sigla { get; private set; }

        public string Nome { get; private set; }

        public Pais Pais { get; private set; }
    }
}