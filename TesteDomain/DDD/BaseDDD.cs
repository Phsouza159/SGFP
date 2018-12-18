using prmToolkit.NotificationPattern;
using System;
using System.Linq;

namespace TesteDomain.DDD
{
    public class BaseDDD<T> : Notifiable where T : Notifiable 
    {
        public void getNotifable(T ob)
        {

            var valid = ob.IsValid() ? " -- Objeto Valido -- " : " -- Objeto Invalido -- \n";

            Console.WriteLine(valid);

            ob.Notifications.ToList().ForEach(p => {

                Console.WriteLine("propriedade invalida : {0} . Menssagm {1} \n", p.Property, p.Message);

            });
        }

    }
}