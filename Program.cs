using System;
using System.Linq;

namespace new1
{
    public class Class1
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int lyginiai = 0;
            int nelyginiai = 0;


            int[] pirmasMasyvas = new int[10];
            
            

            for (int i = 0; i <= 10; i++)

            {

                pirmasMasyvas[i] = random.Next(1, 101);
                Console.WriteLine(pirmasMasyvas[i]);

                if (pirmasMasyvas[i] % 2 == 0)
                {
                    lyginiai++;
                    //Console.WriteLine($"{lyginiai} lyginiu");
                }
                if (pirmasMasyvas[i] % 2 == 1)
                {
                    nelyginiai++;
                    //Console.WriteLine($"{nelyginiai} nelyginiu");
                }
                Console.WriteLine($"{nelyginiai} nelyginiu");
                Console.WriteLine($"{lyginiai} lyginiu");

                int max = pirmasMasyvas.Max();
                if (max > 50)
                {
                    Console.WriteLine("Didziausias skaicius yra didelis");
                }
                if (max < 50)
                {
                    Console.WriteLine("Didziausias skaicius yra mazas");
                }
            }
           

        }
    }
}

