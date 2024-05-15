namespace CoreSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputCounter = int.Parse(Console.ReadLine());

            while (inputCounter > 0)
            {
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

                decimal total = count * price;



                //Concantenation
                //Console.WriteLine("Size : " + shoesSize + ", Color : " + );

                Console.WriteLine($"Size : {size},  Color : {color}, Brand name : {brandName}, Category : {category}, Price : {price}, Count : {count}, Total : {total}");

                inputCounter = inputCounter - 1;
            }


            //Console.WriteLine("Result Total : " + (firstShoesTotal + secondShoesTotal));

        }
    }
}