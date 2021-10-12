using System;
using System.Collections.Generic;

namespace Multivlaai_3
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Welkom in de Multivlaai omgeving");
            Console.WriteLine("Bent u een klant voer 1 in, bent u een medewerker voer dan 2 in, om vlaai's in te voeren 3, alles tonen voer dan 4 in");
            var Keuze = int.Parse(Console.ReadLine());

            var klanten = new List<Klant>();
            var medewerker = new List<Medewerker>();
            var bestaklnt = new List<BestaandKlant>();
            var bestwerk = new List<BestaandMedewerker>();
            var verkoop = new List<Vlaai>();


            if (Keuze == 1)
            {
                Console.WriteLine("Waar mee kan ik u helpen? ");

                var doorgaan = true;
                Console.WriteLine("invoeren klant gegevens");

                while (doorgaan)
                {
                    var klant = new Klant();

                    klanten.Add(klant);

                    Console.Write("wilt u door gaan als volgende klant y/n?");
                    if (Console.ReadLine() == "n")
                    {
                        doorgaan = false;
                    }
                }
            }
            else if (Keuze == 2)
            {
                Console.WriteLine("U kunt inlogen");

                var doorgaan = true;
                Console.WriteLine("invoeren medewerker gegevens");

                while (doorgaan)
                {
                    var werker = new Medewerker();
                    medewerker.Add(werker);

                    Console.Write("wilt u door gaan met volgende medewerker y/n?");
                    if (Console.ReadLine() == "n")
                    {
                        doorgaan = false;
                    }
                }
            }
            else if (Keuze == 3)
            {
                Console.WriteLine("Soorten Vlaai");

                var doorgaan = true;


                while (doorgaan)
                {
                    var verkocht = new Vlaai();
                    verkoop.Add(verkocht);


                    Console.Write("wilt u door gaan  y/n?");
                    if (Console.ReadLine() == "n")
                    {
                        doorgaan = false;
                    }
                }
            }
            else 
            {
                Console.WriteLine("Gegevens");

                var doorgaan = true;


                while (doorgaan)
                {
                    
                    var bestaan = new BestaandKlant();
                    bestaklnt.Add(bestaan);

                    var bestmedew = new BestaandMedewerker();
                    bestwerk.Add(bestmedew);

                    Console.Write("wilt u door gaan  y/n?");
                    if (Console.ReadLine() == "n")
                    {
                        doorgaan = false;
                    }
                }
            }


            Klant.Klant1(klanten);
            BestaandKlant.Bestaan(bestaklnt);

            Medewerker.Werker1(medewerker);
            BestaandMedewerker.Werker2(bestwerk);
            Vlaai.Toon(verkoop);
        }

    }      
}
