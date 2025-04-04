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
            int juniorPrice = 80;
            int seniorPrice = 90;
            int standardPrice = 120;
            if (numberOfPeople == 1)
            {
                string priceLevel;
                int ticketPrice;
                Console.Write("Ange personens ");
                uint age = Util.AskForUInt("ålder"); //= int.Parse(Console.ReadLine());
                if (age < 20)
                {
                    priceLevel = "Ungdomspris";
                    ticketPrice = juniorPrice;
                }
                else if (age > 64)
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
                    uint age = Util.AskForUInt("ålder");//int age = int.Parse(Console.ReadLine());
                    if (age < 20)
                        sumTicketPrice += juniorPrice;
                    else if (age > 64)
                        sumTicketPrice += seniorPrice;
                    else
                        sumTicketPrice += standardPrice;
                }
                Console.WriteLine($"Antal personer: {numberOfPeople} Total kostnad: {sumTicketPrice} kr");
            }
        }
    }
}
