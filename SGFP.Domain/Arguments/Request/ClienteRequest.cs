using SGFP.Domain.Entidades;

namespace SGFP.Domain.Arguments.Request
{
    public class ClienteRequest : PessoaRequest
    {
        public Carro Carro { get; set; }

        public Avaliacao Avaliacao { get; set; }
    }
}
