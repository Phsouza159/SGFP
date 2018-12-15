using System;

namespace SGFP.Domain.Entidades
{
    public class Cidade
    {
        public Cidade(Guid id, string nome, Estado estado)
        {
            Id = id;
            Nome = nome;
            Estado = estado;
        }

        public Guid Id { get; private set; }

        public string Nome { get; private set; }

        public Estado Estado { get; private set; }
    }
}