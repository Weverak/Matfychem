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
            Console.WriteLine("Zadejte ��slo kter� chcete odmocnit?:");
            double cislo = double.Parse(Console.ReadLine());
           
            double vypocet = Math.Sqrt(cislo);
            Console.Write("V�sledek je: " + vypocet);

            Console.ReadKey();

            Console.WriteLine("Program automaticky pokra�uje do hlavn�ho menu, pokud chcete program ukon�it zav�ete okno s programem");
            Console.ReadKey();
            menu.menu();

        }
    }
}