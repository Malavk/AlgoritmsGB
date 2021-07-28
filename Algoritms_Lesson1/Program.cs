using System;
using System.Globalization;

namespace Algorithms_DZ_1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion Задание первое: Расшифровка блок-схемы
            Scheme one = new Scheme();
            one.SchemeSolution();
            #endregion

            #region MyRegion Задание второе: Вычисление асимтотичекой сложности
            // O(1+N*N*N+1) = O(2N^3)
            // Общая производительность алгоритма составит: O(2N^3)
            #endregion

            #region MyRegion Задание третье: Реализуйте функцию вычисления числа Фибоначчи
            Console.WriteLine("Введите количество первых чисел Фибоначчи: ");
            int f = Int32.Parse(Console.ReadLine());

            Fibonaci three = new Fibonaci();

            Console.WriteLine("Рекурсивный метод: ");
            three.FibonaciRecursion(f); 
            for (int i = 0; i < f; i++)
            {
                var s = i + 1 == f ? string.Empty : ", ";
                Console.WriteLine($"{three.FibonaciRecursion(i)}{s}");
            }

            Console.WriteLine("Циклический метод: ");
            three.FibonaciCycle(f); //
            for (int i = 0; i < f; i++)
            {
                var s = i + 1 == f ? string.Empty : ", ";
                Console.WriteLine($"{three.FibonaciCycle(i)}{s}");
            }
            #endregion


        }
    }
}
