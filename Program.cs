using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Conometro
{
     class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {

            Console.WriteLine("Conometro \nS = Segundo => 10s = 10 segundos \n" + "M = Minuto => 1m = 1 minuto \n" + "0 = Sair \n" + "Quanto tempo deseja contar?" + "");
            string tempo = Console.ReadLine().ToLower();
            
            
            if (tempo == "0" ) {
                Environment.Exit(0);
            }

            else
            {
                string type = tempo.Substring(tempo.Length - 1, 1);
                string valor = tempo.Substring(0, tempo.Length - 1);
                int numeroInteiro = Convert.ToInt32(valor);

                switch (type)
                {
                    case "s": Segundos(numeroInteiro); break;
                    case "m": Minutos(numeroInteiro); break;
                    default: Console.Clear(); Menu(); break;
                }
            }
        }

        public static void Segundos(int temp)
        {
            int ValorInicial = 0;
            while (temp != ValorInicial) {
                Console.Clear();
                ValorInicial++;
                Console.WriteLine(ValorInicial);
                Thread.Sleep(1000);

            }
        }

        public static void Minutos (int temp) 
        {
           int minutes = temp * 60;
            int ValorInicial = 0;   
            while (minutes != ValorInicial)
            {
                Console.Clear();
                ValorInicial++;
                Console.WriteLine(ValorInicial);
                Thread.Sleep(1000);
            }


        }
    }

    
}
