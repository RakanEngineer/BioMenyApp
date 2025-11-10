

namespace BioMenyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                ShowMainMenu();
                string input = Console.ReadLine();

                switch (input)
                {
                    case "0":
                        Console.WriteLine("Avslutar programmet...");
                        return;
                    case "1":
                        CheckTicketPrice();
                        break;
                    case "2":
                        GroupSizeAndTotalPrice();
                        break;
                    case "3":
                        RepeatTextTenTimes();
                        break;
                    case "4":
                        ShowThirdWord();
                        break;
                    default:
                        Console.WriteLine("Ogiltigt val, försök igen!");
                        break;
                }
            }
            while (true);
        }

        private static void ShowThirdWord()
        {
            Console.Clear();
            Console.WriteLine("Hämtar tredje ordet:");
            Console.Write("Ange en mening med minst tre ord: ");
            string mening = Console.ReadLine();
            string[] words = mening.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (words.Length >= 3)
            {
                Console.WriteLine($"Det tredje ordet är: {words[2]}\n");
            }
            else
            {
                Console.WriteLine("Du skrev inte tillräckligt många ord!.\n");
            }
        }

        private static void RepeatTextTenTimes()
        {
            Console.Clear();
            Console.WriteLine("Upprepar text tio gånger:");
            Console.Write("Ange en valfri text: ");
            string userText = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Resultat:");

            for (int i = 1; i <= 10; i++)
            {
                if (i < 10)
                    Console.Write($"{i}.{userText}, ");
                else
                    Console.WriteLine($"{i}.{userText}.");

            }
            Console.WriteLine("\n");
        }

        private static void GroupSizeAndTotalPrice()
        {
            Console.Clear();
            Console.WriteLine("Hur många vi är som ska gå på bio:");
            string groupSizeInput = Console.ReadLine();
            if (int.TryParse(groupSizeInput, out int groupSize))
            {
                int totalPrice = 0;
                for (int i = 0; i < groupSize; i++)
                {
                    Console.WriteLine($"Ange ålder för person {i + 1}: ");
                    string personAgeInput = Console.ReadLine();
                    if (int.TryParse(personAgeInput, out int personAge))
                    {
                        if (personAge < 5 || personAge > 100)
                            totalPrice = 0;
                        else if (personAge < 20)
                        {
                            totalPrice += 80;
                        }
                        else if (personAge > 64)
                        {
                            totalPrice += 90;
                        }
                        else
                        {
                            totalPrice += 120;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ogiltig ålder, försök igen.");
                    }
                }
                Console.WriteLine($"\nAntal personer: {groupSize}");
                Console.WriteLine($"Totalkostnad: {totalPrice}kr\n");
            }
            else
            {
                Console.WriteLine("Ogiltigt antal, försök igen.");
            }
        }

        private static void CheckTicketPrice()
        {
            Console.Clear();
            Console.Write("Ange ålder: ");
            string ageInput = Console.ReadLine();

            if (int.TryParse(ageInput, out int age))
            {
                int price = 0;
                if (age < 5 || age > 100)
                {
                    Console.WriteLine("Gratis inträde!");
                    return;
                }
                else if (age < 20)
                {
                    price = 80;
                    Console.WriteLine($"Ungdomspris: {price} kr");
                }
                else if (age > 64)
                {
                    price = 90;
                    Console.WriteLine($"Pensionärspris: {price} kr");
                }
                else
                {
                    price = 120;
                    Console.WriteLine($"Standardpris: {price} kr");
                }
            }
            else
            {
                Console.WriteLine("Ogiltig ålder, försök igen.");
            }
        }

        private static void ShowMainMenu()
        {
            Console.WriteLine("---HUVUDMENY!---");
            Console.WriteLine("0. Avsluta programmet");
            Console.WriteLine("1. Ungdom eller pensionär");
            Console.WriteLine("2. Sällskapspris");
            Console.WriteLine("3. Upprepa text tio gånger");
            Console.WriteLine("4. Hämta tredje ordet");
            Console.WriteLine("----------------------");
            Console.Write("Välj ett alternativ: ");
        }
    }
}
