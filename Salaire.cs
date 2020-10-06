using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    class Salaire
    {
        public void CalculSalaire()
        {
            int salaire = 1500, heure, supp, suppMaj;
            Console.WriteLine("nombre d'heure? ");
            heure = Convert.ToInt32(Console.ReadLine());

            if (heure > 43)
            {
                suppMaj = SuppMaj(heure);
                supp = Supp(heure);
                Console.WriteLine(salaire + supp + suppMaj);
            }
            else if (heure > 35)
            {
                supp = (heure - 35) * 16;
                Console.WriteLine(salaire + supp);
            }
            else
            {
                Console.WriteLine(salaire);
            }
        }
        private static int Supp(int heure)
        {
            return (heure - 35) * 16;
        }

        private static int SuppMaj(int heure)
        {
            return (heure - 43) * 24;
        }
    }
}
