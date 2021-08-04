using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MATFYCHEM
{
    class Menu
    {
        public void menu() {
            Kalkulacka kalkulacka = new  Kalkulacka();
        Mocninator mocninator = new  Mocninator();
            Odmocniny odmocniny = new Odmocniny();
       
            Console.Clear();
            Console.WriteLine("Vítejte v alfa 0.1 verzi programu MATFYCHEM");
            Console.WriteLine("V této verzi je kalkulačka, mocniny a odmocniny");
            Console.WriteLine("1- kalkulačka");
            Console.WriteLine("2-Mocniny");
            Console.WriteLine("3-Odmocniny");
            int menu = int.Parse(Console.ReadLine());
            switch(menu) {
                case 1:
                    kalkulacka.pocitej();
                break;

                case 2:
                    mocninator.mocni();
                break;

                case 3: 
                    odmocniny.odmocni();
                break; 
            }
        }
    }
}