using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening3
{
    internal class VerzekerdePatient:Patient
    {
        public VerzekerdePatient(string naam, int aantalUren)
        : base(naam, aantalUren)
        {
        }

        public override double BerekenKost()
        {
            double basisKost = base.BerekenKost();
            return basisKost * 0.9; // 10% reductie
        }
    }
}
