namespace Oefening2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Drank water = new Drank("Water");
            Elixir gewoonElixer = new Elixir("Elixer van Energie", false);
            Elixir zeldzaamElixer = new Elixir("Elixer der Onsterfelijkheid", true);

            List<Drank> dranken = new List<Drank>();
            dranken.Add(water);
            dranken.Add(gewoonElixer);
            dranken.Add(zeldzaamElixer);

            /* Alternatieve manier om dit (eenvoudiger) te programmeren: 
             List<Drank> dranken = new List<Drank>
                {
                    water,
                    gewoonElixer,
                    zeldzaamElixer
                };
             */

            foreach (Drank drank in dranken)
            {
                Console.WriteLine($"Drank: {drank.Naam}");
                Console.WriteLine($"Magische kracht: {drank.BerekenKracht()}");
                Console.WriteLine("-------------------------");
            }
        }
    }
}
