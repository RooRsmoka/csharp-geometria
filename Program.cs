using System;

namespace csharp_geometria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iValoreBase;
            int iValoreAltezza;

            Console.WriteLine("Inserisci un valore per la base del rettangolo");
            if (!int.TryParse(Console.ReadLine(), out iValoreBase))
            {
                Console.WriteLine("Non hai inserito nessun valore per la base");
                Environment.Exit(1);
            }

            Console.WriteLine("Inserisci un valore per l'altezza del rettangolo");
            if (!int.TryParse(Console.ReadLine(), out iValoreAltezza))
            {
                Console.WriteLine("Non hai inserito nessun valore per l'altezza");
                Environment.Exit(1);
            }

            Console.WriteLine("Inserisci un nome da dare al rettangolo");
            string sValoreNome = Console.ReadLine();

            Rettangolo retOne = new Rettangolo(iValoreBase, iValoreAltezza, sValoreNome);
            retOne.StampaRettangolo();
        }
    }
}