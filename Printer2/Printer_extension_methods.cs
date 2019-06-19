using System;
using Printer1;

namespace Printer2
{
    public static class Printer_extension_methods
    {
        public static void Print(this Printer printer, string[] strings)
        {
            foreach (string n in strings)
            {
                printer.Print(n);
            }
        }

        public static void Print(this ColourPrinter colourPrinter, string[] strings, int[] colors)
        {
            if (strings.Length == colors.Length)
            {
                for (int i = 0; i < colors.Length; i++)
                    colourPrinter.Print(strings[i], colors[i]);
            }
            else Console.WriteLine("ERROR: Input arrays have different dimentions!");

        }

        public static void Print(this PhotoPrinter photoPrinter, Photo[] photos)
        {
            foreach (Photo n in photos)
            {
                photoPrinter.Print(n);
            }
        }

    }
}
