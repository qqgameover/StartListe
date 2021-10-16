using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartListe
{
    class Registration
    {
        public int StartNumber { get; private set; }
        public string Name { get; private set; }
        public string Club { get; private set; }
        public string Nationality { get; private set; }
        public string Group { get; private set; }
        public string Class { get; private set; }
        public string wholeLine { get; private set; }

        public Registration(string line)
        {
            wholeLine = line;
        }
    }
}
