using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    class ExerciceWhile
    {
        public void Exo1()
        {
            int noteMax, noteMin, nbNotes = 0, noteCumul, noteSaisie;            

            Console.WriteLine("Saisir une note");
            noteSaisie = Convert.ToInt32(Console.ReadLine());

            nbNotes += 1;
            noteMax = noteSaisie;
            noteMin = noteSaisie;
            noteCumul = noteSaisie;

            Console.WriteLine("\nLa première note est : " + noteSaisie);

            while (nbNotes<5)
            {
                Console.WriteLine("\nSaisir une note");
                noteSaisie = Convert.ToInt32(Console.ReadLine());
                nbNotes += 1;
                noteCumul += noteSaisie;
                Console.WriteLine("\n");
                if (noteSaisie > noteMax)
                {
                    noteMax = noteSaisie;
                    Console.WriteLine("\nLa note Max est : " + noteMax);
                }
                else if (noteSaisie <= noteMin)
                {
                    noteMin = noteSaisie;
                    Console.WriteLine("\nLa note min est : " + noteMin);
                }
            }
            Console.WriteLine("\nLa moyen est de : " + (float)noteCumul / nbNotes + " Sur " + nbNotes + " notes." + "\n");

        }
    }
}
