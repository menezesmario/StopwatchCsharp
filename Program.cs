using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundos => Ex. 10s = 10 segundos");
            Console.WriteLine("M = Minutos => Ex. 2m = 2 minutos");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower(); //obtendo a entrada e convertendo o tipo (m ou s) para minúscula
            char type = char.Parse(data.Substring(data.Length-1, 1)); // identificando o tipo (minuto ou segundo) no último caracter da string
            int time = int.Parse(data.Substring(0, data.Length-1));
            
            Console.WriteLine(type);
            Console.WriteLine(time);
        }

  
        static void Start(int time)
        {
            int currentTime = 0;

            while(currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(2500);
              
        }
    }
} 
