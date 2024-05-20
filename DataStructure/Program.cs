using System.Xml.Linq;

namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int firstNumber = 10;
            //int secondNumber = 20;
            //int thirdNumber = 30;

            //int[] numbers = new int[3];

            //numbers[0] = firstNumber; //1 - ci
            //numbers[1] = secondNumber; // 2- ci
            //numbers[2] = thirdNumber; // 3-cu

            //int[] numbers = new int[3] { firstNumber, secondNumber, thirdNumber };
            //int[] numbers = { firstNumber, secondNumber, thirdNumber };
            //int[] numbers = new int[] { firstNumber, secondNumber, thirdNumber };

            //numbers[0] = 55;

            //Console.WriteLine(numbers[77]);

            //int[] numbers = { 2, 3, 4, 5, 10, 23, 54, 67, 87, 98 };
            //int numbersArrLastIdx = numbers.Length - 1;


            ////version 1
            //int firstVersionArrIdx = 0;
            //while (true)
            //{
            //    Console.WriteLine(numbers[firstVersionArrIdx]);

            //    if (firstVersionArrIdx == numbersArrLastIdx)
            //    {
            //        break;
            //    }

            //    firstVersionArrIdx++;
            //}
            //Console.WriteLine("===================================");

            ////version 2
            //int secondVersionArrIdx = 0;
            //while (secondVersionArrIdx <= numbersArrLastIdx)
            //{
            //    Console.WriteLine(numbers[secondVersionArrIdx]);

            //    secondVersionArrIdx++;
            //}
            //Console.WriteLine("=================================== (In reverse order)");


            ////version 3 (In reverse order)
            //int thirdVersionArrIdx = numbersArrLastIdx;
            //while (thirdVersionArrIdx >= 0)
            //{
            //    Console.WriteLine(numbers[thirdVersionArrIdx]);

            //    thirdVersionArrIdx--;
            //}
            //Console.WriteLine("===================================");


            ////version 4 
            //int fourthVersionArrIdx = numbersArrLastIdx;
            //while (fourthVersionArrIdx >= 0)
            //{
            //    Console.WriteLine(numbers[numbersArrLastIdx - fourthVersionArrIdx]);

            //    fourthVersionArrIdx--;
            //}

            //string[] numbers = new string[5];
            //int idxGetCounter = 0;

            //while (idxGetCounter < numbers.Length)
            //{
            //    numbers[idxGetCounter] = Console.ReadLine();

            //    idxGetCounter++;
            //}


            //int idx = 0;

            //while (idx < numbers.Length)
            //{
            //    Console.WriteLine(numbers[idx]);

            //    idx++;
            //}

        }
    }
}