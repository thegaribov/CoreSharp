namespace CurrencyManagement;

internal class Program
{
    static void Main(string[] args)
    {
        string[] currencies = { "USD", "RUB", "EUR" };
        decimal[] currencyRates = { 1.7M, 0.0187M, 1.8497M };

        //consistency
        //clean cde

        while (true)
        {
            Console.Write("Pls enter desired command : ");
            string command = Console.ReadLine();

            if (command == "/help")
            {
                ExecuteHelpCommand();
            }
            else if (command == "/exit")
            {
                ExecuteExitCommand(); //method call
                break;
            }
            else if (command == "/show-recent-currency-rates" || command == "/all")
            {
                ExecuteShowCurrencyRatesCommand(currencies, currencyRates); //argument
            }
            else if (command == "/find-currency-rate-by-code" || command == "/find")
            {
                ExecuteFindCurrencyRateByCode(currencies, currencyRates);
            }
            else if (command == "/calculate-amount-by-currency" || command == "/calc")
            {
                ExecuteCalculateAmountByCurrencyCode(currencies, currencyRates);
            }
            else
            {
                Console.WriteLine("I'm sorry we didn't find a command");
                Console.WriteLine("Pls write /help to see available commands");
            }

            Console.WriteLine();
        }
    }

    //method
    private static void ExecuteHelpCommand()
    {
        Console.WriteLine("1. /show-recent-currency-rates or /all");
        Console.WriteLine("2. /find-currency-rate-by-code or /find");
        Console.WriteLine("3. /calculate-amount-by-currency or /calc");
        Console.WriteLine("4. /exit");
    }
    private static void ExecuteExitCommand()
    {
        Console.WriteLine("Program is termated");
        
    }

    private static void ExecuteShowCurrencyRatesCommand(string[] argCurrencies, decimal[] argCurrencyRates)  //paramaterler
    {
        int currIdx = 0;

        while (currIdx < argCurrencies.Length)
        {
            string currency = argCurrencies[currIdx];
            decimal currencyRate = argCurrencyRates[currIdx];

            Console.WriteLine($"Aplha3 : {currency}, Rate : {currencyRate}");

            currIdx++;
        }
    }
    private static void ExecuteFindCurrencyRateByCode(string[] currencies, decimal[] currencyRates)
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
    private static void ExecuteCalculateAmountByCurrencyCode(string[] currencies, decimal[] currencyRates)
    {
        Console.Write("Pls enter desired currency code : ");
        string aplha3 = Console.ReadLine();
        decimal amount = 0;

        while (true)
        {
            Console.Write("Pls enter desired amount : ");
            amount = decimal.Parse(Console.ReadLine());

            if (amount <= 0)
            {
                Console.WriteLine("Amount should be greater than 0");
            }
            else
            {
                break;
            }
        }

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
}