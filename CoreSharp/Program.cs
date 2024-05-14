namespace CoreSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string personName = "Mahmood";
            //string personLastName = "Garibov";
            //string personFatherName = "Elchin";
            //bool isMarried = false;
            //bool hasChild = false;

            //Console.WriteLine(personName);
            //Console.WriteLine(personLastName);
            //Console.WriteLine(personFatherName);


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


            //string personName = "Mahmood";
            //string personLastName = "Garibov";
            //string personFatherName = "Elchin";
            //bool isMarried = true;
            //bool hasChild = false;
            //int age = 20;

            //Console.WriteLine(personName);
            //Console.WriteLine(personLastName);
            //Console.WriteLine(personFatherName);

            ////if condition, selection statement
            //if (isMarried) //codnition
            //{

            //    Console.WriteLine("Evlidir");
            //    if (hasChild)
            //    {
            //        Console.WriteLine("Ovladi var");
            //    }
            //    else 
            //    {
            //        Console.WriteLine("Ovladi yoxdur");
            //    }
            //}
            //else
            //{   
            //    Console.WriteLine("Subay");
            //}


            //============================================================

            //input
            string personName = "Mahmood";
            string personLastName = "Garibov";
            string personFatherName = "Elchin";
            bool isMarried = true;
            bool hasChild = false;
            int age = 20;

            Console.WriteLine(personName);
            Console.WriteLine(personLastName);
            Console.WriteLine(personFatherName);

            if (age <= 18)
            {
                Console.WriteLine("Yeniyetme");
            }
            else if (age >= 19 && age <= 30)
            {
                Console.WriteLine("Orya yasli");
            }
            else if (age > 30 && age <= 65)
            {
                Console.WriteLine("Qocaa");
            }
            else
            {
                Console.WriteLine("Yasli");
            }


          
        }
    }
}