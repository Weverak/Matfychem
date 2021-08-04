using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MATFYCHEM
{
    class Odmocniny
    {


        public void odmocni()
        {
            Kalkulacka kalkulacka = new Kalkulacka();

            Menu menu = new Menu();
            Console.Clear();
            Console.WriteLine("Odmocniny");
            Console.WriteLine("Zadejte èíslo které chcete odmocnit?:");
            double cislo = double.Parse(Console.ReadLine());
           
            double vypocet = Math.Sqrt(cislo);
            Console.Write("Výsledek je: " + vypocet);

            Console.ReadKey();

            Console.WriteLine("Program automaticky pokraèuje do hlavního menu, pokud chcete program ukonèit zavøete okno s programem");
            Console.ReadKey();
            menu.menu();

        }
    }
}