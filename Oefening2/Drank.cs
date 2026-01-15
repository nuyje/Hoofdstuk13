using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2
{
    internal class Drank
    {
        public string Naam { get; set; }

        public Drank(string naam)
        {
            Naam = naam;
        }

        public virtual int BerekenKracht()
        {
            return 50;
        }
    }
}
