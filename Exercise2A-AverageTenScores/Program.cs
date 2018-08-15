using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2A_AverageTenScores
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


            Console.Write("Hello! Please enter your 1st test number: ");
            number1 = Convert.ToDouble(Console.ReadLine());
            while (number1 < 0 || number1 > 100)
            {
                Console.WriteLine("Please enter Number greater then 0");
                Console.WriteLine("Please enter Number Less then 100");
                Console.Write("Please enter 1st test number: ");
                number1 = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("Please enter 2nd test number: ");
            number2 = Convert.ToDouble(Console.ReadLine());
            while (number2 < 0 || number2 > 100)
            {
                Console.WriteLine("Please enter Number greater then 0");
                Console.WriteLine("Please enter Number Less then 100");
                Console.Write("Please enter 2nd test number: ");
                number2 = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("Please enter 3rd test number: ");
            number3 = Convert.ToDouble(Console.ReadLine());
            while (number3 < 0 || number3 > 100)
            {
                Console.WriteLine("Please enter Number greater then 0");
                Console.WriteLine("Please enter Number Less then 100");
                Console.Write("Please enter 3rd test number: ");
                number3 = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("Please enter 4th test number: ");
            number4 = Convert.ToDouble(Console.ReadLine());
            while (number4 < 0 || number4 > 100)
            {
                Console.WriteLine("Please enter Number greater then 0");
                Console.WriteLine("Please enter Number Less then 100");
                Console.Write("Please enter 4th test number: ");
                number4 = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("Please enter 5th test number: ");
            number5 = Convert.ToDouble(Console.ReadLine());
            while (number5 < 0 || number5 > 100)
            {
                Console.WriteLine("Please enter Number greater then 0");
                Console.WriteLine("Please enter Number Less then 100");
                Console.Write("Please enter 5th test number: ");
                number5 = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("Please enter 6th test number: ");
            number6 = Convert.ToDouble(Console.ReadLine());
            while (number6 < 0 || number6 > 100)
            {
                Console.WriteLine("Please enter Number greater then 0");
                Console.WriteLine("Please enter Number Less then 100");
                Console.Write("Please enter 6th test number: ");
                number6 = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("Please enter 7th test number: ");
            number7 = Convert.ToDouble(Console.ReadLine());
            while (number7 < 0 || number7 > 100)
            {
                Console.WriteLine("Please enter Number greater then 0");
                Console.WriteLine("Please enter Number Less then 100");
                Console.Write("Please enter 7th test number: ");
                number7 = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("Please enter 8th test number: ");
            number8 = Convert.ToDouble(Console.ReadLine());
            while (number8 < 0 || number8 > 100)
            {
                Console.WriteLine("Please enter Number greater then 0");
                Console.WriteLine("Please enter Number Less then 100");
                Console.Write("Please enter 8th test number: ");
                number8 = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("Please enter 9th test number: ");
            number9 = Convert.ToDouble(Console.ReadLine());
            while (number9 < 0 || number9 > 100)
            {
                Console.WriteLine("Please enter Number greater then 0");
                Console.WriteLine("Please enter Number Less then 100");
                Console.Write("Please enter 9th test number: ");
                number9 = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("Please enter 10th test number: ");
            number10 = Convert.ToDouble(Console.ReadLine());
            while (number10 < 0 || number10 > 100)
            {
                Console.WriteLine("Please enter Number greater then 0");
                Console.WriteLine("Please enter Number Less then 100");
                Console.Write("Please enter 10th test number: ");
                number10 = Convert.ToDouble(Console.ReadLine());
            }

            //Print a blank line
            Console.WriteLine();

            //Defines 2 more variables

            string letterGrade;
            double sum = (number1
                + number2
                + number3
                + number4
                + number5
                + number6
                + number7
                + number8
                + number9
                + number10) / 10;

            //Getting LetterGrade based on 'sum'

            if (sum > 90)
            {
                letterGrade = "A";
            }
            else if ((sum < 90) && (sum > 80))
            {
                letterGrade = "B";
            }
            else if ((sum < 80) && (sum > 70))
            {
                letterGrade = "C";
            }
            else if ((sum < 70) && (sum > 60))
            {
                letterGrade = "D";
            }
            else if ((sum < 60))
            {
                letterGrade = "F";
            }
            else
            {
                letterGrade = "None";
            }

            //Show the details that the user entered
            Console.WriteLine("Your Sum is: {0}%. Your letter grade is: {1}", sum, letterGrade);
        }
    }
}
