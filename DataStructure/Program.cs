﻿namespace DataStructure
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

           

            int[] numbers = { 2, 3, 4, 5, 10, 23, 54, 67, 87, 98 };

            int arrIdx = 0;

            while (arrIdx < numbers.Length) //Alternative arrIdx <= numbers.Length - 1;
            {
                int number = numbers[arrIdx];

                Console.WriteLine(number);

                //arrIdx = arrIdx + 1;
                //arrIdx += 1;
                arrIdx++;
            }
        }
    }
}