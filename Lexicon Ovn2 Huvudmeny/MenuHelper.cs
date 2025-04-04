using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Ovn2_Huvudmeny
{
    internal class MenuHelper
    {
        public static void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("Huvudmeny");
            Console.WriteLine("=========");
            Console.WriteLine("1. Köp biobiljetter");
            Console.WriteLine("2. Upprepa tio gånger");
            Console.WriteLine("3. Det tredje ordet");
            Console.WriteLine("0. Avsluta");
            Console.Write(Environment.NewLine);
            Console.WriteLine("Skriv in siffran till vänster om varje menyval för att köra resp funktion");
            Console.Write(Environment.NewLine);
        }
        public static bool MainMenu()
        {
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1": //1. Köp biobiljetter
                    {
                        Console.Clear ();   
                        Console.WriteLine("Köp biobiljetter");
                        Console.WriteLine("================");
                        Console.WriteLine("1. Till en person");
                        Console.WriteLine("2. Till ett sällskap");
                        string cinemaChoice = Console.ReadLine();
                        if (cinemaChoice == "1")
                        {
                            CinemaTickets(1);
                        }
                        else
                        {
                            Console.WriteLine("Hur många personer i sällskapet? ");
                            int numberOfPeople = int.Parse(Console.ReadLine());
                            CinemaTickets(numberOfPeople);
                        }                      
                        PressAnyKey();
                        return true;
                    }
                case "2": //2. Upprepa tio gånger
                    {
                        Console.Write(Environment.NewLine);                        
                        Console.Write("Ange den text som skall upprepas: ");
                        string input = Console.ReadLine();
                        Console.Write(Environment.NewLine);
                        for (int i = 0; i < 10; i++)
                        {
                            Console.Write($"{i + 1}.{input}");
                            if (i < 9)
                                Console.Write(", ");
                        }
                        Console.Write(Environment.NewLine);                       
                        PressAnyKey();
                        return true;
                    }
                case "3": //3. Det tredje ordet
                    {
                        Console.Write("Ange en mening som innehåller minst tre ord: ");
                        string[] input = Console.ReadLine().Split();
                        string thirdWord = input[2];
                        Console.WriteLine($"Det tredje ordet i meningen är: {thirdWord}");                        
                        PressAnyKey();
                        return true;
                    }
                case "0":  //0. Avsluta
                    {
                        return false;
                    }

                default:
                    Console.WriteLine("Ogiltigt val");
                    PressAnyKey();           
                    return true;
            }
        }
        private static void CinemaTickets(int numberOfPeople)
        {
            int juniorPrice = 80;
            int seniorPrice = 90;
            int standardPrice = 120;
            if (numberOfPeople == 1)
            {
                string priceLevel;
                int ticketPrice;
                Console.WriteLine("Ange personens ålder: ");
                int age = int.Parse(Console.ReadLine());
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
                    int age = int.Parse(Console.ReadLine());
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
        private static void PressAnyKey()
        {
            Console.Write(Environment.NewLine);
            Console.WriteLine("Tryck på valfri tangent för att återgå till huvudmenyn.");
            Console.ReadLine();
        }
    }
}
