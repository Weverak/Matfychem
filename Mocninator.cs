using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MATFYCHEM
{
    class Mocninator
    {

       
        public void mocni() {
            
             Console.WriteLine("Mocninátor");
             Console.WriteLine("Nápověda k mocninám v příkladu 2 na 3 je 2 základ a 3 je exponent!");
            Console.WriteLine("Zadejte základ mocniny:");
            int zaklad = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte exponent mocniny:");
            int exponent = int.Parse(Console.ReadLine());
            Console.Write("Výsledek je:");
            Console.Write(Math.Pow(zaklad, exponent));
            Console.ReadKey();
             

        }
    }
}