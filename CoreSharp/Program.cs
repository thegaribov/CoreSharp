namespace CoreSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string personName = "Mahmood";
            string personLastName = "Garibov";
            string personFatherName = "Elchin";
            bool isMarried = false;

            Console.WriteLine(personName);
            Console.WriteLine(personLastName);
            Console.WriteLine(personFatherName);


            //== Comparison operator

            //if (isMarried == true) //codnition
            //{
            //    Console.WriteLine("Evli");
            //}

            //============================================================

            //if (isMarried) //codnition
            //{
            //    Console.WriteLine("Evli");
            //}

            //if (isMarried == false)
            //{
            //    Console.WriteLine("Subay");
            //}


            //============================================================

            if (isMarried) //codnition
            {
                Console.WriteLine("Evli");
            }
            else
            {
                Console.WriteLine("Subay");
            }
        }
    }
}