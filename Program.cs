
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
                        Console.WriteLine("Du valde Ungdom eller pensionär.");
                        break;
                    case "2":
                        Console.WriteLine("Du valde Sällskapspris.");
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
