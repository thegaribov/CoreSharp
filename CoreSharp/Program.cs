namespace CoreSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //value types
            int data = 2;
            bool isExist = false;
            char letter = 'M';

            //Value type => 

            //refence types
            //reference variable => instance

            //LOOP
            //iNDEX
            //lengh

            string name = "Mahmood";
            string[] names = { "Mahmood", "Eldar", "Vagif" };


            for (int i = 0; i < names.Length; i++)
            {
                for (int j = 0; j < names[i].Length; j++)
                {
                    Console.Write(names[i][j] + "-");
                }

                Console.WriteLine();
            }
            
            //int[,] myArr = {
            //    { 1, 2, 3 },
            //    { 5, 6, 9 },
            //    { 12, 45, 34 },
            //};

            //Console.WriteLine(myArr.GetLength(0)); 
            //Console.WriteLine(myArr.GetLength(1));

            int sum = 0;

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        sum += myArr[i, 1];
            //    }
            //}

            Console.WriteLine(sum);







            //for (int i = 0; i < name.Length; i++)
            //{
            //    char specialChr = name[i];

            //    Console.WriteLine(specialChr);
            //}


            //char[] letters = { 'M', 'a', 'h', 'm', 'o', 'o', 'd' };


            //// reference variable => instance
            //int[] numbers = { 2, 5, 8, 9 };
            //int number = 2;


            //int firstNumber = numbers[0];
            //Console.WriteLine(firstNumber);






        }
    }
}