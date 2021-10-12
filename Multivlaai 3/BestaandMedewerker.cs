using System;
using System.Collections.Generic;
using System.Text;

namespace Multivlaai_3
{
    class BestaandMedewerker
    {      

        public static int aantal = 0;    

        public BestaandMedewerker()
        {
            BestaandKlant.aantal++;
            
            string[] Nm = { "Jan", "Piet", "Margriet", "Linda", "Gert", "Christien" };
            string[] Achter = { "Groot", "Jansen", "Talens", "Hendriks", "Warnar", "van Gaal" };
            string[] Functie = { "Inkoper", "verkoper", "inkoper", "verkoper", "manager", "verkoper" };
            string[] Str = { "Tromplaan", "Tulp  ", "Bachplein", "Sationstraat", "De Meerkoet", "Steenstraat" };
            string[] NrHuis = { "1", "10", "4", "8", "12", "7" };
            string[] Postcd = { "5010 KL", "2044 AC", "7557 DE", "6543 HJ", "2356 OP", "4758 TR" };
            string[] Woonpl = { "Stijn", "Emmen", "Tiel", "Hoorn", "Meppel", "Goes" };
            string[] Telefoon = { "0509658476", "0304569874", "0381254783", "0765412847", "0601472584", "0247856982" };
            string[] Geboort = { "10-02-70", "02-08-1997", "07-11-1975", "09-12-1980", "25-04-1987", "19-06-2000" };
            int ID = Nm.Length;


            Console.WriteLine("Bestaande Medewerker");
            Console.WriteLine("naam:    \t |  achternaam:  \t |  functie: \t |  strtaat:           \t |  huisnr: \t |  postcode: \t |  woonplaats: \t |  telefoonnr: \t |  geboortedatum: ");
            for (int i = 0; i < ID; i++)
            {
                Console.WriteLine($"{ Nm[i]}     \t |  {Achter[i]}       \t |  {Functie[i]} \t |  {Str[i]}      \t   |  {NrHuis[i]}    \t |  {Postcd[i]}  \t |  {Woonpl[i]}        \t |  {Telefoon[i]}  \t |  {Geboort[i]}  ");
            }
            Console.WriteLine("\n");
            
        }        

    }
}
