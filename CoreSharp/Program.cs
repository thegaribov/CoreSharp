namespace CoreSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //malware
            int firstNum = 1;



            //int firstNumb = 1;
            //int scondNum = 2;
            //firstNumb = scondNum;


            //int[] firstArr = { 1, 2, 3 };
            //int[] secondArr = { 5, 7, 12, 5, };

            //firstArr[0] = 4;

            //firstArr = secondArr;


            //for (int i = 0; i < firstArr.Length; i++)
            //{
            //    Console.Write(firstArr[i] + ", ");
            //}

            //Console.WriteLine();

            //for (int i = 0; i < secondArr.Length; i++)
            //{
            //    Console.Write(secondArr[i] + ", ");
            //}

            //if (firstArr[0] == secondArr[)
            //{
            //    Console.WriteLine("Identical");
            //}
            //else
            //{
            //    Console.WriteLine("Non-identical");
            //}


            //string
            // 1. immutable
            //string cache or string pool

            //int number = 123321;

            //string firstName = "123213";
            //string secondName = "Mahmood";

            //char letterA = 'A';

            //Console.WriteLine((int)letterA); //casting

            //char.IsDigit()

            //if (firstName == secondName) //Reference identical,  => string pool, string cache
            //{
            //    Console.WriteLine("Identical");
            //}
            //else
            //{
            //    Console.WriteLine("Non-identical");
            //}


            //Framework
            //C# + ".NET Framework" Framework
            // ".NET Framework 1.0" (Out of support)
            // ".NET Framework 2.0" (Out of support)
            // ".NET Framework 3.0" (Out of support)
            // ".NET Framework 4.0" (Out of support)
            // ".NET Framework 4.2" (Out of support)
            // ".NET Framework 4.5" (Out of support)
            // ".NET Framework 4.8" (Support)

            //2001 -> 2014, 15
            //".NET Core  1.0" Framework (Out of support)
            //".NET Core  2.0" Framework (Out of support)
            //".NET Core  3.0" Framework (Out of support)
            //".NET 5.0" Framework (Out of support)
            //".NET 6.0" Framework  (Support)
            //".NET 7.0" Framework  (Support)
            //".NET 8.0" Framework (Support)

            //memory leak (C/C++)

            //REFERENCE TYPES CLEANING
            //garbage collection
            //      => generations
            //      NULL 
            //readonly, immutable


            //Framework includes :
            // 1. Class library 
            // 2. CLR
            //       => Translation
            //       => Memory management
            //                  => GC
            //       => Thread management
            //       => 





            int[] numbers = { 1, 2, 3, 4 };
            int randomNum = 56;

            


            List<int> firstarr = new List<int> { 1, 3, 4 };
            List<int> secondArr = new List<int> { 5, 6, 7 };

            string name = "Mahmood";
            Console.WriteLine($"Before NULL : {name.Length}");

            name = null;
            //Console.WriteLine(name.Length);
            Console.WriteLine($"Afater NULL assignment : {name.Length}");
        }
    }
}