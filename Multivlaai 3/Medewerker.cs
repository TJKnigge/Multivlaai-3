using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Multivlaai_3
{
    class Medewerker: Persoongegevens
    {

        public string wachtwoord;

        public static int aantal = 0;
        
        
        private string _Gebdatum;
        private int _Leeftijd;


        public string Gebdatum
        {
            set
            {
                _Gebdatum = value;
            }
            get
            {
                return _Gebdatum;
            }
        }

        public int Leeftijd
        {
            set
            {
                _Leeftijd = value;
            }
            get
            {
                return _Leeftijd;
            }
        }



        public Medewerker()
        {
            
            Console.WriteLine("geef aub je wachtwoord op (Login): ");
            wachtwoord = Console.ReadLine();
            var i = 0;

            while (wachtwoord != "Login" && i < 3)
            {
                Console.WriteLine("probeer op nieuw, probeer nog een keer: ");
                wachtwoord = Console.ReadLine();
                i++;
            }

            if (i < 3)
            { }
            

            bool geboorte = false;

            var nlCulture = new CultureInfo("nl-NL");
            Console.WriteLine("Geboorte datum: " + "dd-mm-yyyy", nlCulture.DateTimeFormat.ShortDatePattern);
            Gebdatum = Console.ReadLine();
            DateTime Date = DateTime.Today;

            try
            {
                DateTime Datum = Convert.ToDateTime(Gebdatum);
                geboorte = true;
            }
            catch (Exception)
            {
                Console.WriteLine("het format van de opgegeven geboordedatum is niet correct.");
            }
            DateTime userDate;
            while (geboorte == false)

            {
                Console.WriteLine("Geboorte datum: " + "dd-mm-yyyy", nlCulture.DateTimeFormat.ShortDatePattern);
                Gebdatum = Console.ReadLine();

                if (DateTime.TryParse(Gebdatum, nlCulture.DateTimeFormat, DateTimeStyles.None, out userDate))

                {
                    geboorte = true;
                }
                else
                {
                    Console.WriteLine("Geen getal, probeer het nog eens.");
                }
            }

            Console.WriteLine("Leeftijd: ");
            DateTime TimeDate = DateTime.Today;
            DateTime GeboorteDatum = Convert.ToDateTime(Gebdatum);
            Leeftijd = TimeDate.Year - GeboorteDatum.Year;
            if (TimeDate.Month < GeboorteDatum.Month || (TimeDate.Month == GeboorteDatum.Month && TimeDate.Day < GeboorteDatum.Day)) Leeftijd--;
            Console.WriteLine(Leeftijd);

            Medewerker.aantal++;
        }

        public static void Werker1(List<Medewerker> C)
        {
            Console.WriteLine("naam:    \t |  achternaam:    \t |  strtaat:    \t |  huisnr:    \t |  postcode:    \t |  woonplaats:    \t |  telefoonnr:    \t |  geboortedatum:    \t |  leeftijd: ");
            foreach (var werker1 in C)
            {              
                Console.WriteLine(" {0}     \t |    {1}          \t |    {2}  \t |    {3}      \t |    {4}        \t |    {5}  \t         |    {6}  \t         |    {7}             \t |    {8} ", werker1.Naam, werker1.AchterNaam, werker1.Straat, werker1.Huisnr, werker1.Postcode, werker1.Woonplaats, werker1.Telefoonnr, werker1.Gebdatum, werker1.Leeftijd);            
            }
        }
    }
}
