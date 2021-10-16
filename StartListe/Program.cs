using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace StartListe
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\Kasper\source\repos\StartListe\StartListe\startliste.csv";
            var lines = File.ReadAllLines(path);
            var registrationsList = new List<Registration>();
            var clubList = new List<Club>();
            for (var index = 0; index < lines.Length; index++)
            {
                if(index == 0) continue;
                var line = lines[index];
                var splitLine = line.Split(",");
                if (splitLine[2].Length <= 2) continue;
                clubList.Add(new Club(splitLine[2]));
            }

            foreach (var line in lines)
            {
                registrationsList.Add(new Registration(line));
            }
            var duplicates = clubList
                .GroupBy(i => i.ClubName)
                .Where(g => g.Count() > 1)
                .Select(g => g.Key);
            foreach (var d in duplicates)
                Console.WriteLine(d);
        }
    }
}
