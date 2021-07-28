using System;


namespace Algorithms_DZ_1
{
    class Scheme
    {
        public void SchemeSolution()
        {
            int number;
            Console.WriteLine("Input number: ");
            number = Int32.Parse(Console.ReadLine());

            int d = 0;
            int i = 2;

            while (i < number)
            {
                if (number % i == 0)
                {
                    d++;
                }

                i++;
            }

            if (d == 0)
            {
                Console.WriteLine("Prime number");
            }
            else
            {
                Console.WriteLine("Composite number");
            }
        }
    }
}
