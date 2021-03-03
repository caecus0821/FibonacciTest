using System;

    class Program
    {
        static void Main()
        {

            int num1 = 1;
            int num2 = 0;
            int num3 = 0;
            string fib = "";
            string fin = "0";
            int counter = 1;
            int range = 0;

            Console.WriteLine("Enter Your fibonnaci Range: ");
            range = Convert.ToInt32(Console.ReadLine());

            while(counter < range)
            {
                fin += ", ";
                num3 = num1 + num2;
                fib = Convert.ToString(num3);
                fin += fib;
                counter++;
                num1 = num2;
                num2 = num3;
            }
            Console.WriteLine("Fibonacci numbers are: " + fin);

        }

    
    }

