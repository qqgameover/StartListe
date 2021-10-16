using System;
using System.IO;

namespace StartListe
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\Kasper\source\repos\StartListe\StartListe\startliste.csv";
            var lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
