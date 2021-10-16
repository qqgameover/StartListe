using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StartListe
{
    class Club
    {
        public string ClubName { get; private set; }
        public Registration PersRegistration { get; private set; }

        public Club(string clubName)
        {
            ClubName = clubName;
        }
    }
}
