using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2
{
    internal class Elixir:Drank
    {
        public bool IsZeldzaam { get; set; }

        public Elixir(string naam, bool isZeldzaam)
            : base(naam)
        {
            IsZeldzaam = isZeldzaam;
        }

        public override int BerekenKracht()
        {
            int basisKracht = 50;

            if (IsZeldzaam)
            {
                return basisKracht + 20;
            }
            else
            {
                return basisKracht + 10;
            }
        }
    }
}
