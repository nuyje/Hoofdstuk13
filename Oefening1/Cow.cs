using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1
{
    internal class Cow:Mammal
    {
        public bool GeeftMelk { get; set; }

        public Cow(string naam): base(naam, "lopen", 4)
        {
            GeeftMelk = true;
        }

        public override void ToonInfo()
        {
            base.ToonInfo();
            Console.WriteLine($"Geeft melk: {GeeftMelk}");
        }
    }
}
