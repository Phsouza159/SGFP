using System;

namespace SGFP.Domain.Arguments.Request
{
    public class AvaliacaoRequest
    {
        public AvaliacaoRequest()
        {

        }

        public AvaliacaoRequest(Guid id, double nota, string texto)
        {
            Id = id;
            Nota = nota;
            Texto = texto;
        }

        public Guid Id { get;  set; }

        public double Nota { get;  set; }

        public string Texto { get;  set; }
    }
}
