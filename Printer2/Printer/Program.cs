using System;

namespace Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            Photo photo = new Photo { PhotoData = "photo string" };
            Printer printer = new Printer();
            ColourPrinter colourPrinter = new ColourPrinter();
            PhotoPrinter photoPrinter = new PhotoPrinter();
            

            printer.Print("Regular printer prints string.\n");
            colourPrinter.Print("Colour printer prints string.\n");
            photoPrinter.Print("Photo printer prints string.\n");
            colourPrinter.Print($"Colour printer prints string with selected {(ConsoleColor)12} colour.\n", 12);
            photoPrinter.Print(photo);

            Console.ReadKey();

        }
    }

    public class Printer

    {
        public virtual void Print(string n)
        {
            Console.WriteLine(n);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

    }

    public class ColourPrinter : Printer
    {
        public override void Print(string n)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            base.Print(n);
        }

        public void Print(string n, int color)
        {
            Console.ForegroundColor = (ConsoleColor)color;
            base.Print(n);
        }
        
    }

    public class PhotoPrinter : Printer
    {
        public override void Print(string n)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            base.Print(n);
        }

        public void Print(Photo photo)
        {
            Console.WriteLine($"Photo printer prints photo: '{photo.PhotoData}'.\n");
        }

    }

    public class Photo
    {
        public string PhotoData { get; set; }

    }
       
}
