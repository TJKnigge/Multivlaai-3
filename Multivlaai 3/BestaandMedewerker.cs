using System;
using System.Collections.Generic;
using System.Text;

namespace Multivlaai_3
{
    class BestaandMedewerker : Persoongegevens
    {
        public string Nm;
        public string Achter;
        public string Functie;
        public string Str;
        public int NrHuis;
        public string Postcd;
        public string Woonpl;
        public int Telefoon;
        public string Geboort;


        public BestaandMedewerker()
        {


            string[] Nm = { "Jan", "Piet", "Margriet", "Linda", "Gert", "Christien" };
            string[] Achter = { "Groot", "Jansen", "Talens", "Hendriks", "Warnar", "van Gaal" };
            string[] Functie = { "Inkoper", "verkoper", "inkoper", "verkoper", "manager", "verkoper" };
            string[] Str = { "Tromplaan", "Tulp", "Bachplein", "Sationstraat", "De Meerloet", "Steenstraat" };
            string[] NrHuis = { "1", "10", "4", "8", "12", "7" };
            string[] Postcd = { "5010 KL", "2044 AC", "7557 DE", "6543 HJ", "2356 OP", "4758 TR" };
            string[] Woonpl = { "Stijn", "Emmen", "Tiel", "Hoorn", "Meppel", "Goes" };
            string[] Telefoon = { "0509658476", "0304569874", "0381254783", "0765412847", "0601472584", "0247856982" };
            string[] Geboort = { "10-02-70", "02-08-1997", "07-11-1975", "09-12-1980", "25-04-1987", "19-06-2000" };

            /*     
                 
                Console.WriteLine("naam:    \t |  achternaam:    \t |  functie:    \t |  strtaat:    \t |  huisnr:    \t |  postcode:    \t |  woonplaats:    \t |  telefoonnr:    \t |  geboortedatum: ");
                for (int i = 0; i < Nm.Length; i++)
                {
                    Console.WriteLine("  {0}  \t |    {1}  \t |    {2}  \t |    {3}  \t |    {4}  \t |    {5}  \t |    {6}  \t |    {7}  \t |    {8}  ", Nm[i], Achter[i], Functie[i], Str[i], NrHuis[i], Postcd[i], Woonpl[i], Telefoon[i], Geboort[i]);
                }*/

       
        }
        public static void Werker2(List<BestaandMedewerker> D)
        {
            Console.WriteLine("naam:    \t |  achternaam:    \t |  strtaat:    \t |  huisnr:    \t |  postcode:    \t |  woonplaats:    \t |  telefoonnr:    \t |  geboortedatum:    \t |  leeftijd: ");
            foreach (var werker2 in D)
            {
                Console.WriteLine("werker2: {0}     \t |    {1}          \t |    {2}  \t |    {3}      \t |    {4}        \t |    {5}  \t         |    {6}  \t         |    {7}             \t |    {8} ", werker2.Nm, werker2.Achter, werker2.Str, werker2.NrHuis, werker2.Postcd, werker2.Woonpl, werker2.Telefoonnr, werker2.Geboort);
            }
        }

    }
}
