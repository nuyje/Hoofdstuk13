namespace Oefening3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Patient gewonePatient = new Patient("Jan Peeters", 5);
            VerzekerdePatient verzekerdePatient = new VerzekerdePatient("Marie Janssens", 5);

            gewonePatient.ToonInfo();
            verzekerdePatient.ToonInfo();
        }
    }
}
