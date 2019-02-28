using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAD___Attempt_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is attempt 2 because I absolutely failed attempt 1.
            Random random = new Random();
            int[] prey = new int[99];
            int[] successor = new int[101];
            int[] endTotal = new int[6];
            int proceed = 0;
            int generations = 0;
            Console.WriteLine("How many generations should pass?");
            int numberOfGenerations = int.Parse(Console.ReadLine());
            for (int i = 0; i < prey.Length; i++)
            {
                prey[i] += random.Next(1, 6);
            }
            for (int i = 0; i < 74; i++)
            {
                int tmp = random.Next(0, 99);
                while (prey[tmp] == 0)
                {
                    tmp = random.Next(0, 99);
                }
                prey[tmp] = 0;
            }
            for (int i = 0; i < 99; i++)
            {



                if (prey[i] != 0)
                {

                    for (int j = ((proceed + 1) * 4) - 4; j < (proceed + 1) * 4; j++)
                    {

                        successor[j] = prey[i];

                    }
                    proceed++;
                }

            }
            for (int i = 0; i < 100; i++)
            {
                endTotal[successor[i]]++;
            }
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"There were {endTotal[i]} prey of species {i} on generation {generations}.");
                
            }
            while (generations != numberOfGenerations)
                {
                proceed = 0;
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                for(int i = 0; i < endTotal.Length; i++)
                {
                    endTotal[i] = 0;
                }
                for(int i = 0; i < 99; i++)
                {
                    prey[i] = successor[i];
                }
                for(int i = 0; i < 100; i++)
                {
                    successor[i] = 0;
                }
            for (int i = 0; i < 74; i++)
            {
                int tmp = random.Next(0, 99);
                while (prey[tmp] == 0)
                {
                    tmp = random.Next(0, 99);
                }
                prey[tmp] = 0;
            }
            for (int i = 0; i < 99; i++)
            {



                if (prey[i] != 0)
                {

                    for (int j = ((proceed + 1) * 4) - 4; j < (proceed + 1) * 4; j++)
                    {

                        successor[j] = prey[i];

                    }
                    proceed++;
                }

            }
            for (int i = 0; i < 100; i++)
            {
                endTotal[successor[i]]++;
            }
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine($"There were {endTotal[i]} prey of species {i} on generation {generations + 1}.");
                
            }
                generations++;
            }
            Console.ReadKey();
        }
    }
}
