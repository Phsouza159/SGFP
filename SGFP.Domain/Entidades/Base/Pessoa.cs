using prmToolkit.NotificationPattern;
using SGFP.Domain.Arguments.Request;
using System;

namespace SGFP.Domain.Entidades.Base
{
    public abstract class Pessoa : Notifiable
    {
        public Pessoa()
        {

        }

        public Pessoa(PessoaRequest pessoaRequest)
        {
            Id           = pessoaRequest.Id;
            CPF          = pessoaRequest.CPF;
            RG           = pessoaRequest.RG;
            PrimeiroNome = pessoaRequest.PrimeiroNome;
            UltimoNome   = pessoaRequest.UltimoNome;
            Sexo         = pessoaRequest.Sexo;
            Email        = pessoaRequest.Email;
            Endereco     = pessoaRequest.Endereco;
            Telefone     = pessoaRequest.Telefone;

            new AddNotifications<Pessoa>(this)
                .IfNotCpf(p => p.CPF, "Informe um CPF válido")
                .IfNull(p => p.RG, "Informe o RG valido")
                .IfLengthLowerThan(p => p.RG, 7, "Informe o RG valido com 8 caracters");
            
        }

        public Guid Id { get; private set; }

        public string CPF { get; private set; }

        public string RG { get; private set; }

        public string PrimeiroNome{ get; private set; }

        public string UltimoNome { get; private set; }

        public int Sexo { get; private set; }

        public Email Email { get; private set; }

        public Endereco Endereco { get; private set; }

        public bool Ativo { get; private set; }

        public Telefone Telefone { get; private set; }

    }
}
