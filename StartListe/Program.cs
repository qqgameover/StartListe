using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

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
                if (index == 0) continue;
                var line = lines[index];
                var registration = new Registration(line);
                registrationsList.Add(registration);
                var club = clubList.SingleOrDefault(c => c.ClubName == registration.Club.Trim());
                if (club == null)
                {
                    club = new Club(registration.Club);
                    clubList.Add(club);
                }

                club.AddRegistration(registration);
            }

            foreach (var p in registrationsList)
            {
                Console.WriteLine(p.Name + p.Club);
            }

            foreach (var club in clubList)
            {
                var stringBuilder = new StringBuilder();
                foreach (var registration in club.PersRegistration)
                {
                    stringBuilder.AppendLine(registration.PrintInfo());
                }

                var clubName = new string(club.ClubName.Where(char.IsLetterOrDigit).ToArray());
                var fileName = "Club " + clubName + ".txt";
                int i = 2;
                while (File.Exists(fileName))
                {
                    fileName = "Club " + clubName + i + ".txt";
                    i++;
                }

                File.WriteAllText(@"C:\Users\Kasper\source\repos\StartListe\StartListe\" + fileName, stringBuilder.ToString());
            }
        }
    }
}
