using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Multivlaai_3
{
    public class Vlaai: Persoongegevens
    {

        public string FormattedAmount
        {
            get { return string.Format(new CultureInfo("nl-NL"), "{0:C2}", Verkoop, Inkoop, Winst); }
        }



        public int Id;
        public string SoortVlaai;
        public decimal Inkoop;
        public decimal Verkoop;
        public decimal Winst;


        public static int aantal = 0;

        public Vlaai()
        {
            Vlaai.aantal++;

            Console.WriteLine("Id van product:");
            Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Soortvlaai:");
            SoortVlaai = Console.ReadLine();

            Console.WriteLine("Inkoopprijs:" );
            Inkoop = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Verkoopprijs:");
            Verkoop = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Winst: {Verkoop - Inkoop}");
            Winst = Console.Read();
        }

        public static void Toon(List<Vlaai> k)
        {
            foreach (var verkoop in k)
            {
                Console.WriteLine("verkoop: {0} {1} {2} {3} {4}", verkoop.Id, verkoop.SoortVlaai, verkoop.Inkoop, verkoop.Verkoop, verkoop.Winst);
            }

        }

    }
}
