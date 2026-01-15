using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1
{
    internal class Rabbit:Mammal
    {
        public bool HeeftLangeOren { get; set; }

        public Rabbit(string naam, bool heeftLangeOren): base(naam, "springen", 8)
        {
            HeeftLangeOren = heeftLangeOren;
        }

        public override void ToonInfo()
        {
            base.ToonInfo();
            Console.WriteLine($"Lange oren: {HeeftLangeOren}");
        }
    }
}
