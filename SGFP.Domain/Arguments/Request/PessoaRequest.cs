using SGFP.Domain.Entidades;
using System;

namespace SGFP.Domain.Arguments.Request
{
    public class PessoaRequest
    {
        public Guid Id { get; set; }

        public string CPF { get; set; }

        public string RG { get; set; }

        public string PrimeiroNome { get; set; }

        public string UltimoNome { get; set; }

        public int Sexo { get; set; }

        public Email Email { get; set; }

        public Endereco Endereco { get; set; }

        public Telefone Telefone { get; set; }
    }
}
