using System;
using System.Collections.Generic;
using System.Text;

namespace Multivlaai_3
{
    class Klant: Persoongegevens
    {

        public static int aantal = 0;

        private string _Bestelling;

        public string Bestelling
        {
            set
            {
                _Bestelling = value;
            }
            get
            {
                return _Bestelling;
            }
        }


        public Klant()
        {

            Klant.aantal++;


            Console.WriteLine($"{Naam   } U kunt uw betelling op geven!");
            Bestelling = Console.ReadLine();
            
        }

        public static void Klant1(List<Klant> A)
        {
            Console.WriteLine("naam:    \t |  achternaam:    \t |  strtaat:    \t |  huisnr:    \t |  postcode:    \t |  woonplaats:    \t |  telefoonnr:    \t |  Bestelling ");
            foreach (var klanten in A)
            {                
                Console.WriteLine(" {0}     \t |    {1}          \t |    {2}       \t |    {3}      \t |    {4}        \t |    {5}          \t |    {6}           \t |    {7}", klanten.Naam, klanten.AchterNaam, klanten.Straat, klanten.Huisnr, klanten.Postcode, klanten.Woonplaats, klanten.Telefoonnr, klanten.Bestelling);
            }
            Console.WriteLine("\n");
        }
    }
}
