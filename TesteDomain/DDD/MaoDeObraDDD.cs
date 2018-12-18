using SGFP.Domain.Arguments.Request;
using SGFP.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace TesteDomain.DDD
{
    class MaoDeObraDDD : BaseDDD<MaoDeObra>
    {
        public MaoDeObraDDD()
        {
            Console.WriteLine("------------- Mão de Obra -----------------");

            MaoDeObraRequest maoDeObraRequest = new MaoDeObraRequest();



            MaoDeObra maoDeObra = new MaoDeObra(maoDeObraRequest);

            PrintVar(maoDeObra);

            getNotifable(maoDeObra);

            Console.WriteLine("-------------------------------------------");
        }

        public void PrintVar(MaoDeObra maoDeObra)
        {
            Console.WriteLine("JornadaTrabalho {0} \n", maoDeObra.JornadaTrabalho);

            Console.WriteLine("LimiteHoraExtra {0} \n", maoDeObra.LimiteHoraExtra);

            Console.WriteLine("Nome {0} \n", maoDeObra.Nome);

            Console.WriteLine("TipoMaoObra {0} \n", maoDeObra.TipoMaoObra);

            Console.WriteLine("Valor {0} \n", maoDeObra.Valor);

            Console.WriteLine("ValorHoraExtra {0} \n", maoDeObra.ValorHoraExtra);

        }
    }
}
