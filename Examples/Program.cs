namespace Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1

            string[] names = { "Mahmood", "Eldar", "Asiman", "Eldar" };

            int idx = 0;

            while (idx < names.Length)
            {
                string name = names[idx];

                if (name == "Eldar")
                {
                    Console.WriteLine("Hello world");
                    break;
                }

                idx++;
            }


            #endregion

            #region Array daxilinde elementlerin ceminin tapilmasi

            decimal[] prices = { 9888.2M, 54, 123, 56, 23, 87 };

            int task2Idx = 0;
            decimal sum = 0;

            while (task2Idx < prices.Length)
            {
                sum += prices[task2Idx];

                task2Idx++;
            }

            Console.WriteLine(sum);


            #endregion
        }
    }
}