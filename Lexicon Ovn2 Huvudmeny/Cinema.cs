using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Ovn2_Huvudmeny
{
    internal class Cinema
    {
        public static void Tickets(uint numberOfPeople)
        {
            int adultAgeLimit = 20;                     // variabler för ålder och pris för att inte behöva ändra på flera ställen
            int seniorAgeLimit = 64;

            int juniorPrice = 80;
            int seniorPrice = 90;
            int standardPrice = 120;
                        
            if (numberOfPeople == 1)
            {
                string priceLevel;
                int ticketPrice;
                
                Console.Write("Ange personens ");
                uint age = Util.AskForUInt("ålder"); 
                if (age < adultAgeLimit)
                {
                    priceLevel = "Ungdomspris";
                    ticketPrice = juniorPrice;
                }
                else if (age > seniorAgeLimit)
                {
                    priceLevel = "Pensionärspris";
                    ticketPrice = seniorPrice;
                }

                else
                {
                    priceLevel = "Standardpris";
                    ticketPrice = standardPrice;
                }
                Console.WriteLine($"{priceLevel}: {ticketPrice} kr");
            }
            else
            {
                int sumTicketPrice = 0;
                for (int i = 1; i < numberOfPeople + 1; i++)
                {                  
                    Console.WriteLine($"Ange ålder hos person nr {i}");
                    uint age = Util.AskForUInt("ålder");
                    if (age < adultAgeLimit)
                        sumTicketPrice += juniorPrice;
                    else if (age > seniorAgeLimit)
                        sumTicketPrice += seniorPrice;
                    else
                        sumTicketPrice += standardPrice;
                }
                Console.WriteLine($"Antal personer: {numberOfPeople} Totalkostnad: {sumTicketPrice} kr");
            }
        }
    }
}
