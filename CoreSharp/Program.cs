namespace CoreSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal resultTotal = 0;

            while (true)
            {
                Console.WriteLine("=============================================================================================");
                Console.WriteLine("=============================================================================================");
                Console.Write("Size : ");
                int size = int.Parse(Console.ReadLine());

                Console.Write("Color : ");
                string color = Console.ReadLine();

                Console.Write("Brand name : ");
                string brandName = Console.ReadLine();

                Console.Write("Category : ");
                string category = Console.ReadLine(); //Short cut to replace all : Ctrl + RR

                Console.Write("Price : ");
                decimal price = decimal.Parse(Console.ReadLine()); //Short cut to replace all : Ctrl + RR

                Console.Write("Count : ");
                int count = int.Parse(Console.ReadLine()); //Short cut to replace all : Ctrl + RR

                decimal individualTotal = count * price;
                resultTotal = resultTotal + individualTotal;

                Console.WriteLine($"Size : {size},  Color : {color}, Brand name : {brandName}, Category : {category}, Price : {price}, Count : {count}, Total : {individualTotal}");
                Console.WriteLine("=============================================================================================");
                Console.WriteLine("=============================================================================================");

                Console.WriteLine("Yeni ayaqqabi elave olunsumu? (Yes, No) (Y, N) ");
                string loopTerminationResult = Console.ReadLine();

                if (loopTerminationResult == "No" || loopTerminationResult == "N")
                {
                    //break based loop control
                    break;
          
                }
            }


            Console.WriteLine("Result Total : " + resultTotal);

        }
    }
}