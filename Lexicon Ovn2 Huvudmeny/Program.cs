


namespace Lexicon_Ovn2_Huvudmeny
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                PrintMenu();
                showMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1": //1. Boka biobesök
                    {
                        Console.WriteLine("Boka biobesök");
                        Console.WriteLine("=============");
                        Console.WriteLine("1. För en person");
                        Console.WriteLine("2. För ett sällskap");
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
                        return true;                       
                    }
                case "2": //2. Upprepa tio gånger
                    {
                        Console.WriteLine("2. Upprepa tio gånger");
                        Console.Write("Ange den text som skall upprepas: ");
                        string input = Console.ReadLine();
                        for (int i = 0; i < 10; i++)
                        {
                            Console.Write($"{i+1}.{input}");
                            if (i < 9) 
                                Console.Write(", ");
                        }
                        Console.Write(Environment.NewLine);
                        return true;
                    }
                case "3": //3. Det tredje ordet
                    {                      
                        Console.Write("Ange en mening som innehåller minst tre ord: ");
                        string[] input = Console.ReadLine().Split();
                        string thirdWord = input[2];
                        Console.WriteLine($"Det tredje ordet i meningen är: {thirdWord}");
                        return true;
                    }
                case "0":  //0. Avsluta
                    {              
                        return false;
                    }

                default:
                    Console.WriteLine("Ogiltigt val");
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
                for (int i = 1; i < numberOfPeople+1; i++)
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

        private static void PrintMenu()
        {
            Console.WriteLine("Huvudmeny");
            Console.WriteLine("=========");
            Console.WriteLine("1. Boka biobesök");
            Console.WriteLine("2. Upprepa tio gånger");
            Console.WriteLine("3. Det tredje ordet");
            Console.WriteLine("0. Avsluta");
        }
        //public enum TicketPriceLevel
        //{ 
        //    Ungdomspris,
        //    Standardpris,
        //    Pensionärspris
        //}
    }
}
