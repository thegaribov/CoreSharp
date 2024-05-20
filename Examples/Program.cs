namespace Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 6, 12, 5 };


            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine("============================");
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine("Cut ededler");
                    Console.WriteLine("============================");

                    continue;
                }


                Console.WriteLine("Hello world");
                Console.WriteLine("============================");
                Console.WriteLine();
            }






        }
    }
}