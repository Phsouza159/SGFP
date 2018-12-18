using System;

namespace SGFP.Domain.Arguments.Request
{
    public class AvaliacaoRequest
    {
        public AvaliacaoRequest()
        {

        }

        public AvaliacaoRequest(Guid id, int nota, string texto)
        {
            Id = id;
            Nota = nota;
            Texto = texto;
        }

        public Guid Id { get;  set; }

        public int Nota { get;  set; }

        public string Texto { get;  set; }
    }
}
