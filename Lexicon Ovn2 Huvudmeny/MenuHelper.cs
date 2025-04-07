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
                        Console.Clear();
                        Console.WriteLine("Köp biobiljetter");
                        Console.WriteLine("================");
                        Console.WriteLine("1. Till en person");
                        Console.WriteLine("2. Till ett sällskap");

                        string cinemaChoice = Console.ReadLine();
                        Console.Write(Environment.NewLine);
                        if (cinemaChoice == "1")
                        {                                       // 1.1 köp biljett till en person
                            Cinema.Tickets(1);
                        }
                        else if (cinemaChoice == "2")
                        {                                       // 1.2 köp biljetter till ett sällskap                                                                
                            Console.WriteLine("Ange antal personer i sällskapet");
                            uint numberOfPeople = Util.AskForUInt("antal");
                            Cinema.Tickets(numberOfPeople);
                        }
                        else
                            Console.WriteLine("Ogiltigt val.");
                        PressAnyKey();                          // tryck på valfri tangent för att återgå till huvudmenyn
                        return true;                            // return kan användas istf break i case-sats i en metod
                                                                //   om inget mer behöver göras efter case-satsen
                    }
                case "2":                                       // 2. Upprepa tio gånger
                    {
                        Console.Write(Environment.NewLine);
                        Console.WriteLine("Ange den text som skall upprepas.");
                        string input = Util.AskForString("text");
                        Console.Write(Environment.NewLine);
                        for (int i = 0; i < 10; i++)
                        {
                            Console.Write($"{i + 1}.{input}");
                            if (i < 9)                          // vill inte ha ett kommatecken efter den sista utskriften
                                Console.Write(", ");
                        }
                        Console.Write(Environment.NewLine);
                        PressAnyKey();                         
                        return true;
                    }
                case "3":                                       // 3. Det tredje ordet
                    {
                        Console.WriteLine("Ange en mening som innehåller minst tre ord.");
                        int antalOrd = 0;
                        string[] input;
                        do
                        {
                            input = Util.AskForString("mening").Split();
                            antalOrd = input.Length;
                            if (antalOrd < 3)
                                Console.WriteLine("Meningen innehåller färre än 3 ord. Försök igen.");
                        }
                        while (antalOrd < 3);

                        string thirdWord = input[2];
                        Console.WriteLine($"Det tredje ordet i meningen är: {thirdWord}");
                        PressAnyKey();
                        return true;
                    }
                case "0":                                       // 0. Avsluta
                    {
                        return false;
                    }

                default:
                    {                                           // om användaren matat in något annat än 1,2,3 eller 0
                        Console.WriteLine("Ogiltigt val");
                        PressAnyKey();
                        return true;
                    }
                    
            }
        }
        private static void PressAnyKey()
        {
            Console.Write(Environment.NewLine);
            Console.WriteLine("Tryck på valfri tangent för att återgå till huvudmenyn.");
            Console.ReadKey();
        }       
    }
}
