using SGFP.Domain.Arguments.Request;
using SGFP.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TesteDomain.DDD
{
    public class AvaliacaoDDD : BaseDDD<Avaliacao>
    {
        public AvaliacaoDDD()
        {

            Console.WriteLine("------------- Avalicao ----------------- \n");

            AvaliacaoRequest avaliacaoRequest = new AvaliacaoRequest();

            Avaliacao avaliacao = new Avaliacao(avaliacaoRequest);

            PrintVar(avaliacao);

            getNotifable(avaliacao);

            Console.WriteLine("------------------------------------------- \n");

        }

        public void PrintVar(Avaliacao avaliacao)
        {
            Console.WriteLine("Nota avaliacao {0} \n", avaliacao.Nota);

            Console.WriteLine("Texto avaliacao {0} \n", avaliacao.Texto);
        }
    }
}
