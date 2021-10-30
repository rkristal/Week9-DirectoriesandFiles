using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Second_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"C:\Users\Admin\Desktop\Koolitöö\Progemine\ShoppingList";
            string fileName = @"\\myshoppinglist.txt";

            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> myshoppinglist = arrayFromFile.ToList<string>();


            Console.WriteLine("Sisesta ostunimekiri:");
            string useritems = Console.ReadLine();
            myshoppinglist.Add(useritems);

            File.WriteAllLines($"{fileLocation}{fileName}", myshoppinglist);


        }
    }
}
