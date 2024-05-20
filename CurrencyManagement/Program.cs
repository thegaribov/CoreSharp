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
                Console.WriteLine("1. /show-recent-currency-rates or /all");
                Console.WriteLine("2. /find-currency-rate-by-code or /find");
                Console.WriteLine("3. /calculate-amount-by-currency or /calc");
                Console.WriteLine("4. /exit");
            }
            else if (command == "/exit")
            {
                Console.WriteLine("Program terminates....");
                break;
            }
            else if (command == "/show-recent-currency-rates" || command == "/all")
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
            else if (command == "/find-currency-rate-by-code" | command == "/find")
            {
                Console.Write("Pls enter desired currency code : ");
                string aplha3 = Console.ReadLine();
                bool isFound = false;

                for (int i = 0; i < currencies.Length; i++)
                {
                    string currency = currencies[i];
                    decimal currencyRate = currencyRates[i];

                    if (currency == aplha3)
                    {
                        Console.Write("We found desired currency, ");
                        Console.WriteLine($"Aplha3 : {currency}, Rate : {currencyRate}");
                        isFound = true;
                        break;
                    }
                }

                if (!isFound)
                {
                    Console.WriteLine("I'm sorry, we can't found desired currency");
                }
            }
            else if (command == "/calculate-amount-by-currency" | command == "/calc")
            {
                Console.Write("Pls enter desired currency code : ");
                string aplha3 = Console.ReadLine();

                Console.Write("Pls enter desired amount : ");
                decimal amount = decimal.Parse(Console.ReadLine());

                bool isFound = false;

                for (int i = 0; i < currencies.Length; i++)
                {
                    string currency = currencies[i];
                    decimal currencyRate = currencyRates[i];

                    if (currency == aplha3)
                    {
                        Console.Write("We found desired currency, ");
                        Console.WriteLine($"Aplha3 : {currency}, Rate : {currencyRate}, Amoubt in currency : {Math.Round(amount / currencyRate, 2)}, ");
                        isFound = true;
                        break;
                    }
                }

                if (!isFound)
                {
                    Console.WriteLine("I'm sorry, we can't found desired currency");
                }
            }


            Console.WriteLine();
        }
    }
}