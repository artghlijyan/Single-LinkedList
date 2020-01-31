using System;

namespace SingleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int> { };

            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);

            list.Remove(20);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            int[] array = new int[5];
            array[0] = 1000;
            list.CopyToArray(array, 1);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
