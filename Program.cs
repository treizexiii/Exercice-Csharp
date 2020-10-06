using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;

            do
            {
                try
                {
                    Console.WriteLine("Bonjour, choisissez votre activité :");
                    Console.WriteLine("4 - Calcul de salaire en fonction d'heures supplémentaire.");
                    Console.WriteLine("2 - Exercie 'while' avec des notes.");
                    Console.WriteLine("3 - Jeu du plus grand ou plus petit.");
                    Console.WriteLine("4 - Quitter");
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Merci de choisir une activité proposée...\n \n");
                }
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("\n\n");
                            Salaire calcul = new Salaire();
                            calcul.CalculSalaire();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("\n\n");
                            ExerciceWhile exercice1 = new ExerciceWhile();
                            exercice1.Exo1();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("\n\n");
                            GrandPetit grandPetit = new GrandPetit();
                            grandPetit.JeuGrandPetit();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("\n\n");
                            Console.WriteLine("Au revoir...");
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }while(choice != 4);
        }
    }
}
