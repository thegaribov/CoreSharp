namespace Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 6, 12, 5, 23, 5, 3, 43, 213, };

            int start = 0;
            int end = 0;

            while (true)
            {
                start = int.Parse(Console.ReadLine());
                end = int.Parse(Console.ReadLine());

                if (start > 0 && start < end)
                {
                    if (end <= arr.Length)
                    {
                        break;
                    }

                    Console.WriteLine($"We have limits sorry, {arr.Length}");
                }

                Console.WriteLine("Pls enter valid input");
            }

            int startIdx = start - 1;
            int endIdx = end - 1;


            decimal total = 0;

            for (int i = startIdx; i <= endIdx; i++)
            {
                total += arr[i];
            }


            Console.WriteLine(total);







            //            0  1  2   3  4  5   6   7  8  9   (indexes)


            //            1  2  3   4  5   6  7   8  9  10   (Order)
            //  Input, 5 => 6
            /// 5 = 5
            /// 5, 5


            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("============================");
            //    if (arr[i] % 2 == 0)
            //    {
            //        Console.WriteLine("Cut ededler");
            //        Console.WriteLine("============================");

            //        continue;
            //    }

            //    Console.WriteLine("Hello world");
            //    Console.WriteLine("============================");
            //    Console.WriteLine();
            //}








        }
    }
}