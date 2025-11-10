
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
                        Console.WriteLine("Ange ålder: ");
                        string ageInput= Console.ReadLine();

                        if (int.TryParse(ageInput, out int age))
                        {
                            if (age < 20)
                            {
                                Console.WriteLine("Ungdomspris: 80kr");
                            }
                            else if (age > 64)
                            {
                                Console.WriteLine("Pensionärspris: 90kr");
                            }
                            else
                            {
                                Console.WriteLine("Standardpris: 120kr");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ogiltig ålder, försök igen.");
                        }
                        break;
                    case "2":
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
                                    if (personAge < 20)
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
                        break;
                    default:
                        Console.WriteLine("Ogiltigt val, försök igen.");
                        break;
                }
            }
            while (true);
        }

        private static void ShowMainMenu()
        {
            Console.WriteLine("---HUVUDMENY!---");
            Console.WriteLine("0. Avsluta programmet");
            Console.WriteLine("1. Ungdom eller pensionär");
            Console.WriteLine("2. Sällskapspris");
            Console.WriteLine("----------------------");
            Console.Write("Välj ett alternativ: ");
        }
    }
}
