using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApp8
{
    class GrandPetit
    {
        public void JeuGrandPetit()
        {
            Random rand = new Random();

            int randNber, tryNber, inputNber, tryNberLast;
            string tooBig = "Trop grand...", tooSMall = "Trop petit...", nice = "Bravo!!! Vous avez trouvé le bon numéro. ", loose = "Dommage, ré-essayez...";

            bool catchIt = false;

            Console.WriteLine("Choisissez un nombre d'essai : ");
            tryNber = Convert.ToInt32(Console.ReadLine());
            tryNberLast = tryNber;

            randNber = rand.Next(1, (tryNber*3) + 1);

            while (catchIt == false && tryNberLast != 0)
            {
                Console.WriteLine("Choisissez un nombre compris entre 0 et " + (tryNber*3));
                inputNber = Convert.ToInt32(Console.ReadLine());

                if(inputNber > randNber)
                {
                    Console.WriteLine(tooBig);
                    tryNberLast -= 1;
                    Console.WriteLine("Il vous reste " + tryNberLast + " essai(s)\n");
                }
                else if (inputNber < randNber)
                {
                    Console.WriteLine(tooSMall);
                    tryNberLast -= 1;
                    Console.WriteLine("Il vous reste " + tryNberLast + " essai(s)\n");
                }
                else
                {
                    catchIt = true;
                }
            }

            if (catchIt == true)
            {
                Console.WriteLine(nice + "\n\n");
            }

            if (tryNberLast == 0)
            {
                Console.WriteLine(loose);
                Console.WriteLine("Le nombre a trouvé était " + randNber + "\n\n");
            }
        }
    }
}
