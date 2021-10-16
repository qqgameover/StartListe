using System;
using System.Collections.Generic;
using System.IO;

namespace StartListe
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\Kasper\source\repos\StartListe\StartListe\startliste.csv";
            var lines = File.ReadAllLines(path);
            var registrationsList = new List<Registration>();
            foreach (var line in lines)
            {
                registrationsList.Add(new Registration(line));
            }

            foreach (var registration in registrationsList)
            {
                Console.WriteLine(registration.wholeLine);
            }
        }
    }
}
