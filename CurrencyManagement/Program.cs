namespace CurrencyManagement;

internal class Program
{
    static void Main(string[] args)
    {
        string[] currencies = { "USD", "RUB", "EUR" };
        decimal[] currencyRates = { 1.7M, 0.0187M, 1.8497M };

        while (true)
        {
            Console.WriteLine("Pls write /help to see available commands");
            Console.Write("Pls enter desired command : ");
            string command = Console.ReadLine();

            if (command == "/help")
            {
                Console.WriteLine("1. /show-recent-currency-rates");
                Console.WriteLine("2. /find-currency-rate-by-code");
                Console.WriteLine("3. /calculate-amount-by-currecy");
                Console.WriteLine("4. /exit");
            }
            if (command == "/show-recent-currency-rates")
            {
                int currIdx = 0;

                while (currIdx < currencies.Length)
                {
                    string currency = currencies[currIdx];
                    decimal currencyRate = currencyRates[currIdx];

                    Console.WriteLine($"Aplha3 : {currency}, Rate : {currencyRate}");

                    currIdx++;
                }
            }

            Console.WriteLine();
        }
    }
}