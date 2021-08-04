using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ConsoleApp18
{

    public interface ILinkedList
    {
        int GetCount(); // возвращает количество элементов в списке
        void AddNode(int value);  // добавляет новый элемент списка
        void AddNodeAfter(Node node, int value); // добавляет новый элемент списка после определённого элемента
        void RemoveNode(int index); // удаляет элемент по порядковому номеру
        void RemoveNode(Node node); // удаляет указанный элемент
        Node FindNode(int searchValue); // ищет элемент по его значению
    }


    public class Node
    {
        public int Value { get; set; }
        public Node NextNode { get; set; }
        public Node PrevNode { get; set; }
    }


    class MyLinkedList : ILinkedList
    {
        private Node head;

        public MyLinkedList(int rootValue)
        {
            head = new Node { Value = rootValue };
        }

        public void AddNode(int value)
        {
            Node r = head;

            while (r.NextNode != null)
            {
                r = r.NextNode;
            }
            r.NextNode = new Node() { Value = value };

        }

        public void AddNodeAfter(Node node, int value)
        {
            throw new NotImplementedException();
        }

        public Node FindNode(int searchValue)
        {
            Node r = head;

            while (r != null)
            {
                if (r.Value == searchValue) return r;
                r = r.NextNode;
            }
            return null;
        }

        public int GetCount()
        {
            Node r = head;
            int c = 0;
            while (r != null)
            {
                c++;
                r = r.NextNode;
            }
            return c;
        }

        public void RemoveNode(int index)
        {
            throw new NotImplementedException();
        }

        public void RemoveNode(Node node)
        {
            throw new NotImplementedException();
        }


        public void Print()
        {
            Node r = head;

            while (r != null)
            {
                Console.WriteLine(r.Value);
                r = r.NextNode;
            }

        }


    }

    class Program
    {
        static int Sum(int a, int b) => (byte)a + (byte)b;

        static void CheckSum1()
        {
            int x = 12;
            int y = 22;
            int res = x + y;
            int s = Sum(x, y);
            Console.WriteLine($"{s == res} >> Sum({x},{y}) = {res} => {s} ");
        }
        static void CheckSum2()
        {
            int x = -122;
            int y = 222;
            int res = x + y;
            int s = Sum(x, y);
            Console.WriteLine($"{s == res} >> Sum({x},{y}) = {res} => {s} ");
        }

        public static int BinarySearch(int[] inputArray, int searchValue)
        {






            int left = 0;
            int right = inputArray.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (searchValue == inputArray[mid])
                {
                    return mid;
                }
                else if (searchValue < inputArray[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return -1;
        }
    }
}