using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiologyAssignmentDiversity
{
    class Program
    {
        static void Main(string[] args)
        {
            //All code by Eliot Troop, Project for 9th Grade Honors Biology at Laurel Springs School.
            Console.WriteLine("Hello User, Please enter the generation of your previous set of data in the form of a number between 0 and 99.");
            int generation = int.Parse(Console.ReadLine());
            Console.WriteLine("For each species, write the number of existing ones as they are asked for. (Starting new sets requires putting 20 for each option.");
            int[] species = new int[5];

                for(int i = 0; i < species.Length; i++)
            {
                Console.WriteLine($"Species {i + 1}");
                species[i] = int.Parse(Console.ReadLine()) ;
            }
            int numberLeft = species.Length * 20;
            Random predators = new Random();
            Console.WriteLine($"Generation {generation}.");
            for (int i = 0; i < species.Length; i++)
            {
                if(numberLeft > 45 && species[i] >= 20)
                {
                    species[i] -= predators.Next(0, 20);
                    numberLeft -= 20 - species[i];
                }
                else if (numberLeft == 20)
                {
                    species[i] -= predators.Next(0, (numberLeft - 20));
                    numberLeft -= 20 - species[i];
                }
                else if(numberLeft < 20)
                {
                    int tmp = species[i];
                    species[i] += predators.Next(0, 5);
                    numberLeft += species[i] - tmp;

                }

            }
            while (numberLeft != 25)
            {
                int tmp0 = predators.Next(0, species.Length);
                    if (numberLeft > 25 && species[tmp0] > 5)
                    {
                        int tmp = species[tmp0];
                    species[tmp0] -= predators.Next(0, 5);
                        numberLeft -= tmp - species[tmp0];
                    }
                if (species[tmp0] <= 5)
                {
                    int tmp = 0;
                    tmp = species[tmp0];
                    species[tmp0] += predators.Next(0, 10);
                    numberLeft += tmp - species[tmp0];
                }

            }

            for (int i = 0; i < species.Length; i++)
            {
                species[i] *= 4;
                Console.WriteLine($"Species {i + 1} of generation {generation} contains {species[i]} prey.");
            }

            Console.ReadKey();
        }
    }
}
