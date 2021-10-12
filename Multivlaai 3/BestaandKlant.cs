using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Multivlaai_3
{


    class BestaandKlant :Persoongegevens
    {
    

        public class Klant1
        {
            public string Id { get; set; }
            public string naam { get; set; }
        }

        public class Achternaam
        {
            public string Id { get; set; }
            public string Klant1Id { get; set; }
            public string achternaam { get; set; }
        }

        public class Straat1
        {
            public string Id { get; set; }
            public string AchternaamId { get; set; }
            public string straat { get; set; }

        }

        public class Huisnum
        {
            public string Id { get; set; }
            public string Straat1Id { get; set; }
            public string huisnr { get; set; }

        }

        
        public class Postcd
        {
            public string Id { get; set; }
            public string HuisnumId { get; set; }
            public string postcode { get; set; }

        }

        public class Woonpl
        {
            public string Id { get; set; }
            public string PostcdId { get; set; }
            public string woonplaats { get; set; }

        }

        public class Telnr 
        {
            public string Id { get; set; }
            public string WoonplId { get; set; }
            public string telefoonnr { get; set; }

        }
        

        public BestaandKlant()
        {

            var klant1 = new List<Klant1>()
            {
                 new Klant1()
                 {
                    Id = Guid.NewGuid().ToString(),
                    naam = "Jan"
                 },
                 new Klant1()
                 {
                    Id = Guid.NewGuid().ToString(),
                    naam = "Piet"
                 },
                 new Klant1()
                 {
                    Id = Guid.NewGuid().ToString(),
                    naam = "Klaas"
                 },
                 new Klant1()
                 {
                    Id = Guid.NewGuid().ToString(),
                    naam = "Johan"
                 },
                 new Klant1()
                 {
                    Id = Guid.NewGuid().ToString(),
                    naam = "Theo"
                 },
                 new Klant1()
                 {
                    Id = Guid.NewGuid().ToString(),
                    naam = "THijs"
                 },
                 new Klant1()
                 {
                    Id = Guid.NewGuid().ToString(),
                    naam = "Harry"
                 },
                 new Klant1()
                 {
                    Id = Guid.NewGuid().ToString(),
                    naam = "Karel"
                 },
                 new Klant1()
                 {
                    Id = Guid.NewGuid().ToString(),
                    naam = "Kees"
                 },
                 new Klant1()
                 {
                    Id = Guid.NewGuid().ToString(),
                    naam = "Corne"
                 }
            };

            var achternaam = new List<Achternaam>()
            {
            new Achternaam()
                 {
                     Id = Guid.NewGuid().ToString(),
                     Klant1Id = klant1[0].Id,
                     achternaam = "de Groot"
                  },
            new Achternaam()
                 {
                     Id = Guid.NewGuid().ToString(),
                     Klant1Id = klant1[1].Id,
                     achternaam = "Jansen"
                  },
            new Achternaam()
                 {
                     Id = Guid.NewGuid().ToString(),
                     Klant1Id = klant1[2].Id,
                     achternaam = "Meerveld"
                  },
            new Achternaam()
                 {
                     Id = Guid.NewGuid().ToString(),
                     Klant1Id = klant1[3].Id,
                     achternaam = "Ti1mmers"
                  },
            new Achternaam()
                 {
                     Id = Guid.NewGuid().ToString(),
                     Klant1Id = klant1[4].Id,
                     achternaam = "Peters"
                  },
            new Achternaam()
                 {
                     Id = Guid.NewGuid().ToString(),
                     Klant1Id = klant1[5].Id,
                     achternaam = "Rietveld"
                  },
            new Achternaam()
                 {
                     Id = Guid.NewGuid().ToString(),
                     Klant1Id = klant1[6].Id,
                     achternaam = "Meesters"
                  },
            new Achternaam()
                 {
                     Id = Guid.NewGuid().ToString(),
                     Klant1Id = klant1[7].Id,
                     achternaam = "de Klein"
                  },
            new Achternaam()
                 {
                     Id = Guid.NewGuid().ToString(),
                     Klant1Id = klant1[8].Id,
                     achternaam = "Smit"
                  },
            new Achternaam()
                 {
                     Id = Guid.NewGuid().ToString(),
                     Klant1Id = klant1[9].Id,
                     achternaam = "van Dijk"
                  }
            };

            var straat = new List<Straat1>()
            {
            new Straat1()
                 {
                     Id = Guid.NewGuid().ToString(),
                     AchternaamId = achternaam[0].Id,
                     straat = "Kaanlweg"
                  },
            new Straat1()
                 {
                     Id = Guid.NewGuid().ToString(),
                     AchternaamId = achternaam[1].Id,
                     straat = "Sationsplain"
                  },
             new Straat1()
                 {
                     Id = Guid.NewGuid().ToString(),
                     AchternaamId = achternaam[2].Id,
                     straat = "Langestraat"
                  },
            new Straat1()
                 {
                     Id = Guid.NewGuid().ToString(),
                     AchternaamId = achternaam[3].Id,
                     straat = "Braamslaan"
                  },
            new Straat1()
                 {
                     Id = Guid.NewGuid().ToString(),
                     AchternaamId = achternaam[4].Id,
                     straat = "Haaglaan 2"
                  },
            new Straat1()
                 {
                     Id = Guid.NewGuid().ToString(),
                     AchternaamId = achternaam[5].Id,
                     straat = "Stationstraat"
                  },
            new Straat1()
                 {
                     Id = Guid.NewGuid().ToString(),
                     AchternaamId = achternaam[6].Id,
                     straat = "Klarenbeek"
                  },
            new Straat1()
                 {
                     Id = Guid.NewGuid().ToString(),
                     AchternaamId = achternaam[7].Id,
                     straat = "Prinsegracht"
                  },
            new Straat1()
                 {
                     Id = Guid.NewGuid().ToString(),
                     AchternaamId = achternaam[8].Id,
                     straat = "Teilstraat"
                  },
            new Straat1()
                 {
                     Id = Guid.NewGuid().ToString(),
                     AchternaamId = achternaam[9].Id,
                     straat = "Dwarsstraat"
                  }
            };

            var huisnr = new List<Huisnum>()
            {
            new Huisnum()
                 {
                     Id = Guid.NewGuid().ToString(),
                     Straat1Id = straat[0].Id,
                     huisnr = "4"
                  },
            new Huisnum()
                 {
                     Id = Guid.NewGuid().ToString(),
                     Straat1Id = straat[1].Id,
                     huisnr = "6"
                  },
            new Huisnum()
                 {
                     Id = Guid.NewGuid().ToString(),
                     Straat1Id = straat[2].Id,
                     huisnr = "10"
                  },
            new Huisnum()
                 {
                     Id = Guid.NewGuid().ToString(),
                     Straat1Id = straat[3].Id,
                     huisnr = "3"
                  },
            new Huisnum()
                 {
                     Id = Guid.NewGuid().ToString(),
                     Straat1Id = straat[4].Id,
                     huisnr = "1"
                  },
            new Huisnum()
                 {
                     Id = Guid.NewGuid().ToString(),
                     Straat1Id = straat[5].Id,
                     huisnr = "6"
                  },
            new Huisnum()
                 {
                     Id = Guid.NewGuid().ToString(),
                     Straat1Id = straat[6].Id,
                     huisnr = "12"
                  },
            new Huisnum()
                 {
                     Id = Guid.NewGuid().ToString(),
                     Straat1Id = straat[7].Id,
                     huisnr = "7"
                  },
            new Huisnum()
                 {
                     Id = Guid.NewGuid().ToString(),
                     Straat1Id = straat[8].Id,
                     huisnr = "4"
                  },
            new Huisnum()
                 {
                     Id = Guid.NewGuid().ToString(),
                     Straat1Id = straat[9].Id,
                     huisnr = "9"
                  }
            };

            var postcode = new List<Postcd>()
            {
            new Postcd()
                 {
                     Id = Guid.NewGuid().ToString(),
                     HuisnumId = huisnr[0].Id,
                     postcode = "8255 NM"
                  },
            new Postcd()
                 {
                     Id = Guid.NewGuid().ToString(),
                     HuisnumId = huisnr[1].Id,
                     postcode = "8025 AD"
                  },
            new Postcd()
                 {
                     Id = Guid.NewGuid().ToString(),
                     HuisnumId = huisnr[2].Id,
                     postcode = "5645 CB"
                  },
            new Postcd()
                 {
                     Id = Guid.NewGuid().ToString(),
                     HuisnumId = huisnr[3].Id,
                     postcode = "3035 KL"
                  },
            new Postcd()
                 {
                     Id = Guid.NewGuid().ToString(),
                     HuisnumId = huisnr[4].Id,
                     postcode = "4025 HF"
                  },
            new Postcd()
                 {
                     Id = Guid.NewGuid().ToString(),
                     HuisnumId = huisnr[5].Id,
                     postcode = "7823 ST"
                  },
            new Postcd()
                 {
                     Id = Guid.NewGuid().ToString(),
                     HuisnumId = huisnr[6].Id,
                     postcode = "4058 WE"
                  },
            new Postcd()
                 {
                     Id = Guid.NewGuid().ToString(),
                     HuisnumId = huisnr[7].Id,
                     postcode = "3112 NT"
                  },
            new Postcd()
                 {
                     Id = Guid.NewGuid().ToString(),
                     HuisnumId = huisnr[8].Id,
                     postcode = "2289 BB"
                  },
            new Postcd()
                 {
                     Id = Guid.NewGuid().ToString(),
                     HuisnumId = huisnr[9].Id,
                     postcode = "1012 CD"
                  }
            };

            var woonplaats = new List<Woonpl>()
            {
            new Woonpl()
                 {
                     Id = Guid.NewGuid().ToString(),
                     PostcdId = postcode[0].Id,
                     woonplaats = "den Haag"
                  },
            new Woonpl()
                 {
                     Id = Guid.NewGuid().ToString(),
                     PostcdId = postcode[1].Id,
                     woonplaats = "Haarlem"
                  },
            new Woonpl()
                 {
                     Id = Guid.NewGuid().ToString(),
                     PostcdId = postcode[2].Id,
                     woonplaats = "den Bilt"
                  },
            new Woonpl()
                 {
                     Id = Guid.NewGuid().ToString(),
                     PostcdId = postcode[3].Id,
                     woonplaats = "Zwolle"
                  },
            new Woonpl()
                 {
                     Id = Guid.NewGuid().ToString(),
                    PostcdId = postcode[4].Id,
                     woonplaats = "Meppel"
                  },
            new Woonpl()
                 {
                     Id = Guid.NewGuid().ToString(),
                     PostcdId = postcode[5].Id,
                     woonplaats = "Goes"
                  },
            new Woonpl()
                 {
                     Id = Guid.NewGuid().ToString(),
                     PostcdId = postcode[6].Id,
                     woonplaats = "Emmen"
                  },
            new Woonpl()
                 {
                     Id = Guid.NewGuid().ToString(),
                     PostcdId = postcode[7].Id,
                     woonplaats = "Breda"
                  },
            new Woonpl()
                 {
                     Id = Guid.NewGuid().ToString(),
                     PostcdId = postcode[8].Id,
                     woonplaats = "Epe"
                  },
            new Woonpl()
                 {
                     Id = Guid.NewGuid().ToString(),
                    PostcdId = postcode[9].Id,
                     woonplaats = "Arnhem"
                  }
            };

            var telefoonnr = new List<Telnr>()
            {
            new Telnr()
                 {
                     Id = Guid.NewGuid().ToString(),
                     WoonplId = woonplaats[0].Id,
                     telefoonnr = "0304785194"
                  },
            new Telnr()
                 {
                     Id = Guid.NewGuid().ToString(),
                     WoonplId = woonplaats[1].Id,
                     telefoonnr = "0451282561"
                  },
            new Telnr()
                 {
                     Id = Guid.NewGuid().ToString(),
                     WoonplId = woonplaats[2].Id,
                     telefoonnr = "0516891564"
                  },
            new Telnr()
                 {
                     Id = Guid.NewGuid().ToString(),
                     WoonplId = woonplaats[3].Id,
                     telefoonnr = "0587493125"
                  },
            new Telnr()
                 {
                     Id = Guid.NewGuid().ToString(),
                     WoonplId = woonplaats[4].Id,
                     telefoonnr = "0384592187"
                  },
            new Telnr()
                 {
                     Id = Guid.NewGuid().ToString(),
                     WoonplId = woonplaats[5].Id,
                     telefoonnr = "0407124580"
                  },
            new Telnr()
                 {
                     Id = Guid.NewGuid().ToString(),
                     WoonplId = woonplaats[6].Id,
                     telefoonnr = "0489654217"
                  },
            new Telnr()
                 {
                     Id = Guid.NewGuid().ToString(),
                     WoonplId = woonplaats[7].Id,
                     telefoonnr = "0561408934"
                  },
            new Telnr()
                 {
                     Id = Guid.NewGuid().ToString(),
                     WoonplId = woonplaats[8].Id,
                     telefoonnr = "0201478953"
                  },
            new Telnr()
                 {
                     Id = Guid.NewGuid().ToString(),
                     WoonplId = woonplaats[9].Id,
                     telefoonnr = "0102245698"
                  }
            };

            var Bestaan = from k in klant1
                          join a in achternaam on k.Id equals a.Klant1Id
                          join s in straat on a.Id equals s.AchternaamId
                          join h in huisnr on s.Id equals h.Straat1Id
                          join p in postcode on h.Id equals p.HuisnumId
                          join w in woonplaats on p.Id equals w.PostcdId
                          join t in telefoonnr on w.Id equals t.WoonplId
                          select new
                          {
                              k.naam,
                              a.achternaam,
                              s.straat,
                              h.huisnr,
                              p.postcode,
                              w.woonplaats,
                              t.telefoonnr
                          };

            
            foreach (var bestakl in Bestaan)     // ****** Deze bewerking werkt maar geeft in Program cs aan dat hij Bestaan niet kent ******
            {
                Console.WriteLine(" {0} {1} {2} {3} {4} {5} {7} ", bestakl.naam, bestakl.achternaam, bestakl.straat, bestakl.huisnr, bestakl.postcode, bestakl.woonplaats, bestakl.telefoonnr);

            }

        }

        /*
        public static void Bestaan(List<BestaandKlant> B)
        {
            foreach (var bestakl in B)
            {                                              //****** in de regel hier direct onder komt er een fout melding bij naam, achternaam  enz. In de regel daar onder krijgt de hele verwijzing een rode streep ****
                //Console.WriteLine(" {0} {1} {2} {3} {4} {5} {7} ", bestakl.naam, bestakl.achternaam, bestakl.straat, bestakl.huisnr, bestakl.postcode, bestakl.woonplaats, bestakl.telefoonnr);
                Console.WriteLine(" {0} {1} {2} {3} {4} {5} {7} ", bestakl.Klant1, bestakl.Achternaam, bestakl.Straat1, bestakl.Huisnum, bestakl.Postcd, bestakl.Woonpl, bestakl.Telnr);
            }
        }*/
    }
}
