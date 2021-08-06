using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MATFYCHEM
{
    class Menu
    {
        Kalkulacka kalkulacka = new Kalkulacka();

        private double vysledek;
        public void menu() {
            string pokracovat = "ano";
            while (pokracovat == "ano")
            {
                
                Console.Clear();
                Console.WriteLine("Vítejte v programu Matfychem");
                Console.WriteLine("1-Sčítaní");
                Console.WriteLine("2-Odčítání");
                Console.WriteLine("3-Násobení");
                Console.WriteLine("4-Dělení");
                Console.WriteLine("5-Mocniny");
                Console.WriteLine("6-Odmocniy");
                Console.WriteLine("7-Konec");
                int volba = int.Parse(Console.ReadLine());
                switch (volba)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Vítejte ve sčítacím programu");
                        Console.WriteLine("Zadejte první číslo: ");
                        double s1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Zadejte druhé číslo: ");
                        double s2 = double.Parse(Console.ReadLine());
                       vysledek =  kalkulacka.Scitej(s1, s2);
                        Console.WriteLine("Výsledek je: {0} ", vysledek);
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Vítejte v odčítacím programu");
                        Console.WriteLine("Zadejte první číslo: ");
                        double o1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Zadejte druhé číslo: ");
                        double o2 = double.Parse(Console.ReadLine());
                        vysledek = kalkulacka.Odcitej(o1, o2);
                        Console.WriteLine("Výsledek je: {0}", vysledek);
			Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Vítejte v násobícím programu");
                        Console.WriteLine("Zadejte první číslo: ");
                        double n1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Zadejte druhé číslo: ");
                        double n2 = double.Parse(Console.ReadLine());
                       vysledek = kalkulacka.Nasob(n1, n2);
                        Console.WriteLine("Výsledek je: {0}", vysledek);
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Vítejte v dělícím programu");
                        Console.WriteLine("Zadejte první číslo: ");
                        double d1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Zadejte druhé číslo: ");
                       double d2 = double.Parse(Console.ReadLine());
                        vysledek = kalkulacka.Del(d1, d2);
                        Console.WriteLine("Výsledek je: {0}", vysledek);
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Vítejte v Mocninátoru");
                        Console.WriteLine("Zadejte první číslo: ");
                        double m1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Zadejte druhé číslo: ");
                        double m2 = double.Parse(Console.ReadLine());
                       vysledek = kalkulacka.Mocni(m1, m2);
                        Console.WriteLine("Výsledek je: {0}", vysledek);
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Vítejte v programu na výpočet druhé odmocniny");
                        Console.WriteLine("Zadejte číslo které chcete odmocnit: ");
                        double od1 = double.Parse(Console.ReadLine());
                       vysledek = kalkulacka.Odmocni(od1);
                        Console.WriteLine("Výsledek je: {0}", vysledek);
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Clear();
                        Environment.Exit(0);
                        break;

                }
            }

        }

    }
}