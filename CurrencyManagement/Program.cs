namespace CurrencyManagement;

internal class Program
{
    static void Main(string[] args)
    {
        string[] currencies = { "USD", "RUB", "EUR" };
        decimal[] currencyRates = { 1.7M, 0.0187M, 1.8497M };

        while (true)
        {
            Console.Write("Pls enter available command : ");
            string command = Console.ReadLine();

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