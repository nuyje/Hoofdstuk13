using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1
{
    internal class Animal
    {
        public string Naam { get; set; }
        public string BeweegVoort { get; set; }

        

        public Animal(string naam, string beweegVoort)
        {
            Naam = naam;
            BeweegVoort = beweegVoort;

           
        }

        public virtual void ToonInfo()
        {
            Console.WriteLine($"Naam: {Naam}");
            Console.WriteLine($"Beweegt voort door: {BeweegVoort}");
        }
    }
}
