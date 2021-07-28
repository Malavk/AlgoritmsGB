using System;

namespace Algorithms_DZ_1
{
    class Fibonaci
    {
        public int FibonaciRecursion(int fNumber)
        {
            return (fNumber == 0 || fNumber == 1) ? 1 : FibonaciRecursion(fNumber - 1) + FibonaciRecursion(fNumber - 2);
        }

        public int FibonaciCycle(int fNumber)
        {
            int numberOne = 1;
            int numberTwo = 1;
            int result = 1;

            for (int i = 2; i <= fNumber; i++)
            {
                result = numberOne + numberTwo;
                numberTwo = numberOne;
                numberOne = result;
            }

            return result;
        }
    }
}
