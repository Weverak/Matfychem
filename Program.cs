using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATFYCHEM
{
	class Program
	{
 		static void Main(string[] args) {

            Kalkulacka kalkulacka = new  Kalkulacka();
            Mocninator mocninator = new  Mocninator();
            Menu menu = new  Menu();
            Odmocniny odmocniny = new Odmocniny();
            menu.menu(); 
            
            
		}
	}
}
