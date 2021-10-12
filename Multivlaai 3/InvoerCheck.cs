using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;


namespace Multivlaai_3
{
    class InvoerCheck
    {
        public string Check()
        {
            var vraag = Console.ReadLine();       // singel point of definition
            if (vraag == "")
            {
                Console.WriteLine("geef nog een keer");
                vraag = Console.ReadLine();

            }
            return vraag;
        }

       /*
        public static void Main(string[] args)
        {

            bool geboorte = false;

            var nlCulture = new CultureInfo("nl-NL");
            Console.WriteLine("Geboorte datum: " + "dd-mm-yyyy", nlCulture.DateTimeFormat.ShortDatePattern);
            var Gebdatum = Console.ReadLine();
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
       
        }
         */
    }
}
