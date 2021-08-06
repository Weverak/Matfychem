using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MATFYCHEM
{
    class Kalkulacka
    {
        
        public void pocitej() {
           
            
            Console.Clear();
            Console.WriteLine("Vítejte v kalkulačce");

    Console.WriteLine("Zadejte první číslo:");
    float a = float.Parse(Console.ReadLine());
    Console.WriteLine("Zadejte druhé číslo:");
    float b = float.Parse(Console.ReadLine());
    Console.Clear();
    Console.WriteLine("Zvolte si operaci:");
    Console.WriteLine("1 - sčítání");
    Console.WriteLine("2 - odčítání");
    Console.WriteLine("3 - násobení");
    Console.WriteLine("4 - dělení");
    int volba = int.Parse(Console.ReadLine());
    float vysledek = 0;
    switch (volba)
    {
        case 1:
            vysledek = a + b;
            break;
        case 2:
            vysledek = a - b;
            break;
        case 3:
            vysledek = a * b;
            break;
        case 4:
            vysledek = a / b;
            break;
    }
    if ((volba > 0) && (volba < 5))
        Console.WriteLine("Výsledek: {0}", vysledek);
    else
        Console.WriteLine("Neplatná volba");
    Console.ReadKey();
    
            
            


            

            
        }
    }
}