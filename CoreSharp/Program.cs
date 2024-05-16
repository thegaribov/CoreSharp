namespace CoreSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal resultTotal = 0;

            int numberOfShoes = 2;

            //database
            string[] operatorNames = new string[numberOfShoes];
            int[] sizes = new int[numberOfShoes];
            string[] colors = new string[numberOfShoes];
            string[] brandNames = new string[numberOfShoes];
            string[] categories = new string[numberOfShoes];
            decimal[] prices = new decimal[numberOfShoes];
            int[] counts = new int[numberOfShoes];


            int idx = 0;

            while (idx < numberOfShoes)
            {
                Console.WriteLine("=============================================================================================");
                Console.WriteLine("=============================================================================================");
                string operatorName;
                int size;
                string color;

                #region Operator name validaiton

                while (true)
                {
                    Console.Write("Operator's name : ");
                    operatorName = Console.ReadLine();

                    if (operatorName.Length >= 3 && operatorName.Length <= 15)
                    {
                        operatorNames[idx] = operatorName;
                        break;
                    }
                    else
                        Console.WriteLine("Size dugun daxil edilmeyib");
                }

                #endregion

                #region Size validation

                while (true)
                {
                    Console.Write("Size : ");
                    size = int.Parse(Console.ReadLine());

                    if (size >= 30 && size <= 50)
                    {
                        sizes[idx] = size;
                        break;
                    }
                    else
                        Console.WriteLine("Size dugun daxil edilmeyib");
                }

                #endregion

                #region Color validation

                while (true)
                {
                    Console.Write("Color : ");
                    color = Console.ReadLine();

                    if (color == "Red" || color == "Black" || color == "Blue")
                    {
                        colors[idx] = color;
                        break;
                    }
                    else
                        Console.WriteLine("Color dugun daxil edilmeyib");
                }

                #endregion

                Console.Write("Brand name : ");
                string brandName = Console.ReadLine();
                brandNames[idx] = brandName;

                Console.Write("Category : ");
                string category = Console.ReadLine(); //Short cut to replace all : Ctrl + RR
                categories[idx] = category;

                Console.Write("Price : ");
                decimal price = decimal.Parse(Console.ReadLine()); //Short cut to replace all : Ctrl + RR
                prices[idx] = price;

                Console.Write("Count : ");
                int count = int.Parse(Console.ReadLine()); //Short cut to replace all : Ctrl + RR
                counts[idx] = count;

                decimal individualTotal = count * price;
                resultTotal += individualTotal;

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

                idx++;
            }


            Console.WriteLine("Result Total : " + resultTotal);

        }
    }
}