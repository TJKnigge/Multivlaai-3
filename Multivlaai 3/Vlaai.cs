using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Multivlaai_3
{
    public class Vlaai
    {

        public string FormattedAmount
        {
            get { return string.Format(new CultureInfo("nl-NL"), "{0:C2}", Verkoop, Inkoop, Winst); }
        }

        public static int aantal = 0;

        public int Id;
        public string SoortVlaai;
        public decimal Inkoop;
        public decimal Verkoop;
        public decimal Winst;
                       

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

            Console.WriteLine($"Winst: ");
            Winst = Verkoop - Inkoop;
            Console.WriteLine(Winst);
        }

        public static void Toon(List<Vlaai> k)
        {
            Console.WriteLine("Id     \t |    Soort Vlaai     \t |    Inkoop     \t |      Verkoop     \t |    Wnst");
            foreach (var verkoop in k)
            {
                Console.WriteLine("verkoop: {0}     \t |     {1}     \t |     {2}     \t |     {3}     \t |     {4}", verkoop.Id, verkoop.SoortVlaai, verkoop.Inkoop, verkoop.Verkoop, verkoop.Winst);
            }
            Console.WriteLine("\n");
        }

    }
}
