using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1
{
    internal class Mammal:Animal
    {
        public int AantalZogen { get; set; }

        public Mammal(string naam, string beweegVoort, int aantalZogen): base(naam, beweegVoort)
        {
            AantalZogen = aantalZogen;
        }

        public override void ToonInfo()
        {
            base.ToonInfo();
            Console.WriteLine($"Aantal zogen: {AantalZogen}");
        }
    }
}
