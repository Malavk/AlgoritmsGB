using System;

namespace Algorithms_DZ_2
{
    namespace GeekBrainsTests
    {
        public class Node
        {
            public int Value { get; set; }
            public Node NextNode { get; set; }
            public Node PrevNode { get; set; }
        }

        //Начальную и конечную ноду нужно хранить в самой реализации интерфейса
        public interface ILinkedList
        {
            int GetCount(); // возвращает количество элементов в списке
            void AddNode(int value);  // добавляет новый элемент списка
            void AddNodeAfter(Node node, int value); // добавляет новый элемент списка после определённого элемента
            void RemoveNode(int index); // удаляет элемент по порядковому номеру
            void RemoveNode(Node node); // удаляет указанный элемент
            Node FindNode(int searchValue); // ищет элемент по его значению
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList l = new MyLinkedList(100);


            l.AddNode(3);
            l.AddNode(5);
            l.AddNode(81);
            l.AddNode(18);

            // l.Print();

            Console.WriteLine(l.FindNode(81).NextNode.Value);
            return;
            Console.WriteLine(l.GetCount());
            return;
            int[] arr = new int[] { -1, 2, 3, 1, 5, 6, 8, 3, 1, 3, 10 };
            Array.Sort(arr);


            Console.WriteLine(String.Join(' ', arr));

            Console.WriteLine(BinarySearch(arr, 8));
            Console.WriteLine(Array.BinarySearch(arr, 8));


            return;
            int min = int.MaxValue;
            int max = int.MinValue;

            int minIndex = -1;
            int maxIndex = -1;

            //int min = arr[0];
            //int max = arr[0];


            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min) { min = arr[i]; minIndex = i; }
                if (arr[i] > max) { max = arr[i]; maxIndex = i; }
            }

            Console.WriteLine(minIndex);
            Console.WriteLine(maxIndex);


            //List<int> list = new List<int>();


            //int[] arr = new int[5];

            //Console.WriteLine($"{arr.Length}");
            //Array.Resize(ref arr, 3);
            //Console.WriteLine($"{arr.Length}");

            //return;
            //int N = 6000;

            //int[,] arr = new int[N, N];

            //Console.WriteLine(" i j arr.GetLength");

            //int s = 0;
            //for (int k = 1; k < 6; k++)
            //{
            //    Stopwatch sw = new Stopwatch();
            //    sw.Start();

            //    for (int i = 0; i < arr.GetLength(0); i++)
            //    {
            //        for (int j= 0; j < arr.GetLength(1); j++)
            //        {
            //            arr[i, j] = 1_000_000_000;
            //        }
            //    }

            //    sw.Stop();
            //    Console.WriteLine($"{k} {sw.ElapsedMilliseconds}");
            //}

            //Console.WriteLine(" i j N");

            //s = 0;
            //for (int k = 1; k < 6; k++)
            //{
            //    Stopwatch sw = new Stopwatch();
            //    sw.Start();

            //    for (int i = 0; i < N; i++)
            //    {
            //        for (int j = 0; j < N; j++)
            //        {
            //             arr[i, j]= 1_000_000_000; ;
            //        }
            //    }

            //    sw.Stop();
            //    Console.WriteLine($"{k} {sw.ElapsedMilliseconds}");
            //}

            //Console.WriteLine(" j i N");

            //s = 0;
            //for (int k = 1; k < 6; k++)
            //{
            //    Stopwatch sw = new Stopwatch();
            //    sw.Start();

            //    for (int i = 0; i < N; i++)
            //    {
            //        for (int j = 0; j < N; j++)
            //        {
            //            arr[j, i] = 1_000_000_000; ;
            //        }
            //    }

            //    sw.Stop();
            //    Console.WriteLine($"{k} {sw.ElapsedMilliseconds}");
            //}


            //Console.WriteLine(" j i arr.GetLength");

            //s = 0;
            //for (int k = 1; k < 6; k++)
            //{
            //    Stopwatch sw = new Stopwatch();
            //    sw.Start();

            //    for (int i = 0; i < arr.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < arr.GetLength(1); j++)
            //        {
            //            arr[j, i] = 1_000_000_000; ;
            //        }
            //    }

            //    sw.Stop();
            //    Console.WriteLine($"{k} {sw.ElapsedMilliseconds}");
            //}

            //int N = 1_000_000_000;
            //int[] arr = new int[N];

            //int s = 0;
            //for (int k = 1; k < 6; k++)
            //{
            //    Stopwatch sw = new Stopwatch();
            //    sw.Start();

            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        s += arr[i];
            //    }

            //    sw.Stop();
            //    Console.WriteLine($"{k} {sw.ElapsedMilliseconds}");
            //}

            //Console.WriteLine();
            //Console.WriteLine();
            //for (int k = 1; k < 6; k++)
            //{
            //    Stopwatch sw = new Stopwatch();
            //    sw.Start();

            //    for (int i = 0; i < N; i++)
            //    {
            //        s += arr[i];
            //    }

            //    sw.Stop();
            //    Console.WriteLine($"{k} {sw.ElapsedMilliseconds}");
            //}


            //CheckSum1();
            //CheckSum2();
        }
    }
}
