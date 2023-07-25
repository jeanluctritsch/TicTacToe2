using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{
    class DemonstrationMethodes
    {
        private static void AfficherMessageToto(string message)
        {
            Console.WriteLine("Salut Toto !");
            Console.WriteLine(message);
        }

        static void Main(string[] args)
        {
            AfficherMessageToto("Comment ça va ?");

            AfficherMessageToto("T'as mangé quoi ce midi ?");
        }
    }
}
