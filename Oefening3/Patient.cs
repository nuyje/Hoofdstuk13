using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening3
{
    internal class Patient
    {
        public string Naam { get; set; }
        public int AantalUren { get; set; }

        public Patient(string naam, int aantalUren)
        {
            Naam = naam;
            AantalUren = aantalUren;
        }

        public virtual double BerekenKost()
        {
            return 50 + (20 * AantalUren);
        }

        public void ToonInfo()
        {
            Console.WriteLine($"Naam: {Naam}");
            Console.WriteLine($"Aantal uren in ziekenhuis: {AantalUren}");
            Console.WriteLine($"Totale kost: €{BerekenKost()}");
            Console.WriteLine("--------------------------");
        }
    }
}
