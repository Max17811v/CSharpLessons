using System;

namespace HW_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = { 9, 11, 3, 7, 2, 7, 19, 5, 22 };

            ArrWrap Arr2 = new ArrWrap(9, 11, 3, 7, 2, 7, 19, 5, 22);

            Console.WriteLine("Initial array: ");
            PrintArr(Arr);

            Sort(Arr);

            Console.WriteLine("\n\nSorted array: ");
            PrintArr(Arr);

            Console.WriteLine($"\n\nIs initial array contains '22': {Arr2.Contains(22)}");
            Console.WriteLine($"\nItem geted by index '0': {Arr2.GetByIndex(0)}");
            Console.WriteLine("\nSorted array added to inital one:");
            PrintArr(Arr2.Add(Arr));
            Console.ReadKey();
        }

        public static void Sort(params int[] Arr)
        {
            for (int i = 0; i < Arr.Length - 1; i++)
            {
                for (int j = i + 1; j < Arr.Length; j++)
                {
                    if (Arr[i] > Arr[j])
                    {
                        var temp = Arr[i];
                        Arr[i] = Arr[j];
                        Arr[j] = temp;
                    }
                }
            }
        }

        public static void PrintArr(params int[] Arr)
        {
            foreach (var n in Arr)
            {
                Console.Write($"{n} \t");
            }
        }

        public class ArrWrap
        {
            public int[] Array { get; set; }

            public ArrWrap(params int[] n)
            {
                Array = n;
            }

            public bool Contains(int n)
            {
                foreach (int c in this.Array)
                {
                    if (n == c)
                        return true;
                }
                return false;

            }

            public int[] Add(params int[] n)
            {
                int thisLenght = this.Array.Length;
                int addLenght = n.Length;
                int[] rezult = new int[thisLenght + addLenght];
                for (int i = 0; i < thisLenght; i++)
                {
                    rezult[i] = this.Array[i];
                }
                for (int i = thisLenght; i < thisLenght + addLenght; i++)
                {
                    rezult[i] = n[i - thisLenght];
                }

                return rezult;
            }

            public int GetByIndex(int n)
            {
                return this.Array[n];
            }

        }

    }
}