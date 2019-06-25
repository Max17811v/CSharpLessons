using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new DoublyLinkedList<string>();
            linkedList.Add("Bob");
            linkedList.Add("Bill");
            linkedList.Add("Tom");
            linkedList.AddFirst("Kate");
            linkedList.Add("Max");
            linkedList.Add("Crab");
            Console.WriteLine("Initial linked list:");
            foreach (var item in linkedList)
            {
                Console.Write(item + " ");
            }
            linkedList.Remove("Max");
            Console.WriteLine("\n\nLinked list with removed 'Max':");
            foreach (var item in linkedList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n\nLinked list element count: " + linkedList.Count);
            Console.WriteLine("\nDoes the list contain Kate?: " + linkedList.Contains("Kate"));
            Console.WriteLine("\nLinked list transformed to array:");
            var arr = linkedList.ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i].Data + " ");
            }
            //foreach (var i in arr)
            //{
            //    Console.Write(i.Data + " ");
            //}
            Console.ReadLine();
        }
    }
}
