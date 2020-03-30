using System;
using System.Collections.Generic;

namespace Coffee
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            BlackCoffee blackCoffee = new BlackCoffee();
            Cortado cortado = new Cortado();
            Latte latte = new Latte();

            List<Coffee> CoffeeList = new List<Coffee>();

            CoffeeList.Add(blackCoffee);
            CoffeeList.Add(cortado);
            CoffeeList.Add(latte);

            foreach (var kaffe in CoffeeList)
            {
                System.Console.WriteLine(kaffe.ToString());
            }

            


            // System.Console.WriteLine(blackCoffee);
            // System.Console.WriteLine(cortado);
            // System.Console.WriteLine(latte);

        }
    }
}
