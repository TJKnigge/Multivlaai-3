using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Multivlaai_3
{
    public abstract class Persoongegevens
    {
        public static int ID =0;

        private string _Naam;
        private string _AchterNaam;
        
        private string _Straat;
        private int _Huisnr;
        private string _Postcode;
        private string _Woonplaats;
        private int _Telefoonnr;

        public string Naam
        {
            set
            {
                _Naam = value;
            }
            get
            {
                return _Naam;
            }
        }

        public string AchterNaam
        {
            set
            {
                _AchterNaam = value;
            }
            get
            {
                return _AchterNaam;
            }
        }      

        public string Straat
        {
            set
            {
                _Straat = value;
            }
            get
            {
                return _Straat;
            }
        }

        public int Huisnr
        {
            set
            {
                _Huisnr = value;
            }
            get
            {
                return _Huisnr;
            }
        }

        public string Postcode
        {
            set
            {
                _Postcode = value;
            }
            get
            {
                return _Postcode;
            }
        }

        public string Woonplaats
        {
            set
            {
                _Woonplaats = value;
            }
            get
            {
                return _Woonplaats;
            }
        }

        public int Telefoonnr
        {
            set
            {
                _Telefoonnr = value;
            }
            get
            {
                return _Telefoonnr;
            }
        }

        


        public Persoongegevens()
        {
            Console.WriteLine("geef aub uw naam op:");
            Naam = Console.ReadLine();
            
            Console.WriteLine("geef aub uw achternaam op:");
            AchterNaam = Console.ReadLine();

            Console.WriteLine("geef aub uw straatnaam op:");
            Straat = Console.ReadLine();

            Console.WriteLine("geef aub uw huisnummer op:");
            Huisnr = int.Parse(Console.ReadLine());

            Console.WriteLine("geef aub uw postcode op:");
            Postcode = Console.ReadLine();
            
            Console.WriteLine("geef aub uw woonplaats op:");
            Woonplaats = Console.ReadLine();

            Console.WriteLine("geef aub telefoonnummer op:");
            Telefoonnr = int.Parse(Console.ReadLine());

        }

    }
}
