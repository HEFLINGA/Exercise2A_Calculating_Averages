using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2A
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1;
            double number2;
            double number3;
            double number4;
            double number5;
            double number6;
            double number7;
            double number8;
            double number9;
            double number10;


            Console.Write("Please enter 1st number: ");
            number1 = Convert.ToDouble(Console.ReadLine());
            while (number1 < 0 || number1 > 100)
            {
                Console.WriteLine("Please enter Number greater then 0");
                Console.WriteLine("Please enter Number Less then 100");
                Console.Write("Please enter 1st number: ");
                number1 = Convert.ToDouble(Console.ReadLine());
            }  

            Console.Write("Please enter 2nd number: ");
            number2 = Convert.ToDouble(Console.ReadLine());
            while (number2 < 0 || number2 > 100)
            {
                Console.WriteLine("Please enter Number greater then 0");
                Console.WriteLine("Please enter Number Less then 100");
                Console.Write("Please enter 2nd number: ");
                number2 = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("Please enter 3rd number: ");
            number3 = Convert.ToDouble(Console.ReadLine());
            while (number3 < 0 || number3 > 100)
            {
                Console.WriteLine("Please enter Number greater then 0");
                Console.WriteLine("Please enter Number Less then 100");
                Console.Write("Please enter 3rd number: ");
                number3 = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("Please enter 4th number: ");
            number4 = Convert.ToDouble(Console.ReadLine());
            while (number4 < 0 || number4 > 100)
            {
                Console.WriteLine("Please enter Number greater then 0");
                Console.WriteLine("Please enter Number Less then 100");
                Console.Write("Please enter 4th number: ");
                number4 = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("Please enter 5th number: ");
            number5 = Convert.ToDouble(Console.ReadLine());
            while (number5 < 0 || number5 > 100)
            {
                Console.WriteLine("Please enter Number greater then 0");
                Console.WriteLine("Please enter Number Less then 100");
                Console.Write("Please enter 5th number: ");
                number5 = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("Please enter 6th number: ");
            number6 = Convert.ToDouble(Console.ReadLine());
            while (number6 < 0 || number6 > 100)
            {
                Console.WriteLine("Please enter Number greater then 0");
                Console.WriteLine("Please enter Number Less then 100");
                Console.Write("Please enter 6th number: ");
                number6 = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("Please enter 7th number: ");
            number7 = Convert.ToDouble(Console.ReadLine());
            while (number7 < 0 || number7 > 100)
            {
                Console.WriteLine("Please enter Number greater then 0");
                Console.WriteLine("Please enter Number Less then 100");
                Console.Write("Please enter 7th number: ");
                number7 = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("Please enter 8th number: ");
            number8 = Convert.ToDouble(Console.ReadLine());
            while (number8 < 0 || number8 > 100)
            {
                Console.WriteLine("Please enter Number greater then 0");
                Console.WriteLine("Please enter Number Less then 100");
                Console.Write("Please enter 8th number: ");
                number8 = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("Please enter 9th number: ");
            number9 = Convert.ToDouble(Console.ReadLine());
            while (number9 < 0 || number9 > 100)
            {
                Console.WriteLine("Please enter Number greater then 0");
                Console.WriteLine("Please enter Number Less then 100");
                Console.Write("Please enter 9th number: ");
                number9 = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("Please enter 10th number: ");
            number10 = Convert.ToDouble(Console.ReadLine());
            while (number10 < 0 || number10 > 100)
            {
                Console.WriteLine("Please enter Number greater then 0");
                Console.WriteLine("Please enter Number Less then 100");
                Console.Write("Please enter 10th number: ");
                number10 = Convert.ToDouble(Console.ReadLine());
            }

            //Print a blank line
            Console.WriteLine();

            //Show the details that the user entered
            Console.WriteLine("Your Sum is: {0}.", number1 
                + number2 
                + number3
                + number4 
                + number5 
                + number6 
                + number7 
                + number8 
                + number9 
                + number10);

            Console.ReadLine();
        }
    }
}
