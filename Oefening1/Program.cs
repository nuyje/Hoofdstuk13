using System.Xml.Linq;

namespace Oefening1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> dieren = new List<Animal>
        {
            new Rabbit("Bunny", true),
            new Cow("Bella"),
        };


            foreach (Animal dier in dieren)
            {
                dier.ToonInfo();
                Console.WriteLine("---------------------");
            }

            Animal.ToonAantal(); 
        }
    }
}
