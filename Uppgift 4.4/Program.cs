using System;
namespace Uppgift_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool arIgong = true;

            while (arIgong)
            {
                Console.WriteLine("\nVälj ett av följande alternativ:");
                Console.WriteLine("1. Subtrahera ett tal med ett annat");
                Console.WriteLine("2. Dividera ett tal med ett annat");
                Console.WriteLine("3. Avsluta programmet");
                Console.Write("Ditt val: ");

                string val = Console.ReadLine();

                switch (val)
                {
                    case "1":
                        Console.Write("Skriv in det första talet: ");
                        double tal1Sub = double.Parse(Console.ReadLine());

                        Console.Write("Skriv in det andra talet: ");
                        double tal2Sub = double.Parse(Console.ReadLine());

                        double resultatSub = tal1Sub - tal2Sub;
                        Console.WriteLine($"Resultat: {tal1Sub} - {tal2Sub} = {resultatSub}");
                        break;

                    case "2":
                        Console.Write("Skriv in det första talet: ");
                        double tal1Div = double.Parse(Console.ReadLine());

                        Console.Write("Skriv in det andra talet: ");
                        double tal2Div = double.Parse(Console.ReadLine());

                        if (tal2Div == 0)
                        {
                            Console.WriteLine("Fel: Det går inte att dividera med 0.");
                        }
                        else
                        {
                            double resultatDiv = tal1Div / tal2Div;
                            Console.WriteLine($"Resultat: {tal1Div} / {tal2Div} = {resultatDiv}");
                        }
                        break;

                    case "3":
                        Console.WriteLine("Programmet avslutas...");
                        arIgong = false;
                        break;

                    default:
                        Console.WriteLine("Ogiltigt val, försök igen.");
                        break;
                }
            }
        }
    }
}