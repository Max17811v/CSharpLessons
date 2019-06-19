using System;
using Printer1;

namespace Printer2
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            ColourPrinter colourPrinter = new ColourPrinter();
            PhotoPrinter photoPrinter = new PhotoPrinter();

            string[] strings = { "string1", "string2", "string3", "string4", "string5" };
            int[] colours = { 1, 2, 3, 4, 5 };
            Photo[] photos = {
                new Photo { PhotoData = "photo string1" },
                new Photo { PhotoData = "photo string2" },
                new Photo { PhotoData = "photo string3" },
                new Photo { PhotoData = "photo string4" },
                new Photo { PhotoData = "photo string5" } };


            Console.WriteLine("Print string array:");
            printer.Print(strings);
            Console.WriteLine("\nPrint colored string array:");
            colourPrinter.Print(strings, colours);
            Console.WriteLine("\nPrint photo array:");
            photoPrinter.Print(photos);

            Console.ReadKey();

        }
    }
}
