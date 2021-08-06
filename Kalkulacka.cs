using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MATFYCHEM
{
    class Kalkulacka
    {
        public double vysledek;
        
        
        public double Scitej(double s1, double s2)
        {
            vysledek =  s1+ s2;
            return vysledek;
        }
        public double Odcitej(double o1, double o2)
        {
           vysledek = o1 - o2;
            return vysledek;
        }
        public double Nasob(double n1, double n2)
        {
            vysledek = n1 * n2;
            return vysledek;
        }
        public double Del(double d1, double d2)
        {
             vysledek = d1 / d2;
            return vysledek;
        }
        public double Mocni(double m1, double m2)
        {
             vysledek = Math.Pow(m1, m2);
            return vysledek;
        }
        public double Odmocni(double od1)
        {
           vysledek = Math.Sqrt(od1);
            return vysledek;
        }
    }
}