using System;
using System.IO;

namespace DirectoriaesAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\Admin\Desktop\Koolitöö\Progemine";
            Console.WriteLine("Enter directory name:");
            string newDirectory = Console.ReadLine();
            Console.WriteLine("Enter file name:");
            string fileName = Console.ReadLine();


            
            //File.Create($"{rootDirectory}\\{newDirectory}\\{fileName}");

            if(Directory.Exists($"{rootDirectory}\\{newDirectory}")  && File.Exists($"{rootDirectory}\\{newDirectory}\\{fileName}"))

            {
                Console.WriteLine($"Directory and File exist");


            }

            else
            {
                Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}");
                File.Create($"{rootDirectory}\\{newDirectory}\\{fileName}");

            }

        }
    }
}
