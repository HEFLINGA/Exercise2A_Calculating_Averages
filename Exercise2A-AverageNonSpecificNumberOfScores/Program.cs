using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2A_AverageNonSpecificNumberOfScores
{
    class Program
    {
        static void Main(string[] args)
        {

            double n = 0;
            double sum = 0;
            string input = null;
            while (input != "end")
            {
                Console.Write("Please input a test score! (type \"end\" to finish and get scores and grades!): ");
                input = Console.ReadLine();
                double num = 0;
                if (double.TryParse(input, out num))
                {
                    if ((num < 0) || (num > 100))
                    {
                        Console.WriteLine("Please enter numbers between 0 and 100");
                    }
                    else
                    {
                        sum = sum + num;
                        n++;
                    }
                }
            }

            //Getting LetterGrade based on 'n'
            double average = sum / n;
            string letterGrade;

            if (average >= 90)
            {
                letterGrade = "A";
            }
            else if ((average <= 89.9) && (average >= 80.0))
            {
                letterGrade = "B";
            }
            else if ((average <= 79.9) && (average >= 70))
            {
                letterGrade = "C";
            }
            else if ((average <= 69.9) && (average >= 60))
            {
                letterGrade = "D";
            }
            else if ((average <= 59.9))
            {
                letterGrade = "F";
            }
            else
            {
                letterGrade = "None";
            }


            Console.WriteLine("Your test score average is: {0}%, with a grade score of: {1}", average, letterGrade);
            Console.ReadLine();
        }
    }
}
