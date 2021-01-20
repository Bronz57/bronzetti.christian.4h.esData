using System;
using bronzetti.christian._4h.EsData.Models;

namespace bronzetti.christian._4h.EsData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programma classe Data scritto da Christian Bronzetti, 4h");

            Data d = new Data(28, 08, 01);

            Console.WriteLine($"Data originale {d.Out(d)}");

            d.Mod(28, 03, 2015);

            Console.WriteLine($"Data modificata {d.Out(d)}");

            d.Mod(31, 02, 2019);

            Console.WriteLine($"Data da verificare {d.Out(d)}");

            if (d.Val(d))
                Console.WriteLine("La data è valida");
            else
                Console.WriteLine("La data è errata");

            Data data1 = new Data(31, 02, 1992);

            Console.WriteLine($"Data 2 da verificare {data1.Out(data1)}");

            if (data1.Val(data1))
                Console.WriteLine("La data è valida");
            else
                Console.WriteLine("La data è errata");


        }
    }
}
