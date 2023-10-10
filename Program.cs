using System;

namespace TextAdventure
{
    class Programm
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Herzlich Willkommen zu diesem Spiel.");
            Console.WriteLine("Drücke eine beliebige Taste zum Fortfahren");
            Console.ReadKey();
            Console.WriteLine("Wähle aus zwischen:");
            Console.WriteLine("1) Spiel starten");
            Console.WriteLine("2) Spiel beenden");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine(start);
            if (start == 1)
            {
                spielGestartet();
            }
            if (start == 1)
            Console.ReadKey();
        }

        public static void spielGestartet()
        {
            Console.WriteLine("Spielstart");
        }

        public static void spielBeendet()
        {
           
        }
    }
}