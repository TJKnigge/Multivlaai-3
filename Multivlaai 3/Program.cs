using System;
using System.Collections.Generic;

namespace Multivlaai_3
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Welkom in de Multivlaai omgeving");
            Console.WriteLine("\n");
            Console.WriteLine(" Bent u een klant voer 1 in.\n Bent u een medewerker voer dan 2 in.\n Om vlaai's in te voeren 3.\n Wilt u de gegevens zien voer dan 4 in.\n Om te stop voer dan 5 in.");
            var Keuze = int.Parse(Console.ReadLine());
            var klanten = new List<Klant>();
            var medewerker = new List<Medewerker>();
            var bestaklnt = new List<BestaandKlant>();
            var bestwerk = new List<BestaandMedewerker>();
            var verkoop = new List<Vlaai>();

            bool doorgaan = false;

            if (Keuze == 5)
            {
               return;
            }

            if (Keuze == 1)
            {
                Console.WriteLine("Waar mee kan ik u helpen? ");

                doorgaan = true;
                Console.WriteLine("Voer uw klant gegevens in");

                while (doorgaan)
                {
                    var klant = new Klant();
                    klanten.Add(klant);

                    Console.Write("wilt u door gaan als volgende klant y/n?");
                    if (Console.ReadLine() == "n")
                    {
                        doorgaan = false;
                        Console.WriteLine("\n");
                        Console.WriteLine("Bent u een medewerker voer dan 2 in.\n Om vlaai's in te voeren 3.\n Wilt u de gegevens zien voer dan 4 in.\n Om te stop voer dan 5 in.");
                        Keuze = int.Parse(Console.ReadLine());
                    }
                }
            }
            if (Keuze == 2)
            {
                Console.WriteLine("U kunt inlogen");

                doorgaan = true;
                Console.WriteLine("invoeren medewerker gegevens");

                while (doorgaan)
                {
                    var werker = new Medewerker();
                    medewerker.Add(werker);

                    Console.Write("wilt u door gaan met volgende medewerker y/n?");
                    if (Console.ReadLine() == "n")
                    {
                        doorgaan = false;
                        Console.WriteLine("\n");
                        Console.WriteLine(" Om vlaai's in te voeren 3.\n Wilt u de gegevens zien voer dan 4 in.\n Om te stop voer dan 5 in.");
                        Keuze = int.Parse(Console.ReadLine());
                    }
                }
            }
            if (Keuze == 3)
            {
                Console.WriteLine("Soorten Vlaai");

                doorgaan = true;

                while (doorgaan)
                {
                    var verkocht = new Vlaai();
                    verkoop.Add(verkocht);

                    Console.Write("wilt u door gaan  y/n?");
                    if (Console.ReadLine() == "n")
                    {
                        doorgaan = false;
                        Console.WriteLine("\n");
                        Console.WriteLine("Wilt u de gegevens zien voer dan 4 in.\n Om te stop voer dan 5 in.");
                        Keuze = int.Parse(Console.ReadLine());
                    }
                }
            }
            if (Keuze == 4)
            {
                Console.WriteLine("Gegevens");
                doorgaan = true;

                while (doorgaan)
                {
                    var bestaan = new BestaandKlant();
                    bestaklnt.Add(bestaan);

                    var bestmedew = new BestaandMedewerker();
                    bestwerk.Add(bestmedew);                    
                    {
                        doorgaan = false;
                    }
                }
            }

            Console.WriteLine("Nieuwe klanten");
            Klant.Klant1(klanten);
            Console.WriteLine("Nieuwe medewerkers");
            Medewerker.Werker1(medewerker);
            Console.WriteLine("Assortiment");
            Vlaai.Toon(verkoop);
        }

    }      
}
