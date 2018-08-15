using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2A_AverageASpecifiedNumberOfScores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initilizes user input of grade scores as long as the numbers are between 0 and 100
            double total = 0.0;
            double sum = 0.0;
            double tests = 0.0;
            string input = null;

            Console.WriteLine("Please enter how many test score you would like to input: ");
            total = Convert.ToDouble(Console.ReadLine());

            while (tests != total)
            {
                Console.Write("Enter test score: ");
                input = Console.ReadLine();
                double num = 0.0;
                if (double.TryParse(input, out num))
                {                
                    if ((num < 0) || (num > 100))
                    {
                        Console.WriteLine("Please enter numbers between 0 and 100");
                    }
                    else
                    {
                        sum = sum + num;
                        tests++;
                    }
                }
            }

            //Getting LetterGrade based on 'average'
            double average = sum / total;
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

            //Prints scores and grade to console
            Console.WriteLine("Your test score average is: {0}%, with a grade score of: {1}", average, letterGrade);
            Console.ReadLine();
        }        
    }
}
