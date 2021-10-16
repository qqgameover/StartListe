using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartListe
{
    class Registration
    {
        public string WholeLine { get; private set; }
        public string StartNum { get; private set; }
        public string Name { get; private set; }
        public string Club { get; private set; }
        public string Nationality { get; private set; }
        public string Group { get; private set; }
        public string Classen { get; private set; }
        public Registration(string line)
        {
            WholeLine = line;
            var fields = WholeLine.Split(",");
            StartNum = fields[0];
            Name = fields[1];
            Club = fields[2];
            Nationality = fields[3];
            Group = fields[4];
            Classen = fields[5];
        }

        public string PrintInfo()
        {
            return ($"Start number: {StartNum}, name: {Name}, club: {Club}, nationality: {Nationality}, group: {Group}, class: {Classen}");
        }
    }
}
