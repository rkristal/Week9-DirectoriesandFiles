using System;
using System.IO;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\Admin\Desktop\Koolitöö\Progemine";
            Directory.CreateDirectory($"{rootDirectory}\\ShoppingList");
            File.Create($"{rootDirectory}\\ShoppingList\\ShoppingList.txt");
           
            

        }
    }
}
