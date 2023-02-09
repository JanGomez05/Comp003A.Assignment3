/*
 * Author: Jan Gomez
 * Course: Comp 003A L01
 * Purpose: using if else statements and switch 
 * 
 */

namespace Comp003A.Assignment3;
class Program
{
    static void Main(string[] args)
    { 
        // creating a grading scale using if-else statements
        Console.WriteLine("Please choose a grade 0-100!");
        string numericGrade = Console.ReadLine();
        double score = Convert.ToDouble(numericGrade);
        // the above coding lines is stringinga nd turing into a double
        // allowing decimals for precision accuracy

        if (score >= 0 && score <= 100)
        {
            if (score >= 90)
            {
                // any input from 90 and above is an A
                Console.WriteLine("Letter Grade: A.");
            }
            else if (score >= 80)
            {
                // any input from 80-89 is a B
                Console.WriteLine("Letter Grade: B.");
            }
            else if (score >= 70)
            {
                // any input from 70-79 is a C
                Console.WriteLine("Letter Grade: C.");
            }
            else if (score >= 60)
            {
                // any input from 60-69 is a D
                Console.WriteLine("Letter Grade: D.");
            }
            else
            {
                // any input fom 59-0 is an F
                Console.WriteLine("Letter Grade: F.");
            }
        }
        else
        {
            Console.WriteLine("invalid number!");
        }
        // if must end with an else statement
        Console.WriteLine("**********************");
        // creating a string to format a numeric orderly week
        Console.WriteLine("Please now pick a number 1-7.");
        string numericDay = Console.ReadLine();
        int input = Convert.ToInt32(numericDay);
        // not needing a double, only needing precise answers
        // int only allows whole numbers
        switch (input)
        {
            case 1:
               // first case is the first day of the week
            Console.WriteLine("\tString Day: Monday.");
                break;

            case 2:
               // second case is the second day of the week
             Console.WriteLine("\tString Day: Tuesday.");
                break;

            case 3:
               // third case is the third day of the week
            Console.WriteLine("\tString Day: Wednesday.");
                break;

            case 4:
               // fourth case is the fourth day of the week
            Console.WriteLine("\tString Day: Thursday.");
                break;

            case 5:
               // fifth case is for the fifth day of the week
            Console.WriteLine("\tString Day: Friday.");
                break;

            case 6:
              // sixth case is the sixth day of the week
            Console.WriteLine("\tString Day: Saturday.");
                break;

            case 7:
              // seventh case of seventh day of the week
            Console.WriteLine("\tString Day: Sunday.");
                break;

            default:
                // any other integer is invalid including decimals.
            Console.WriteLine("\tString Day is not a day.");
                break;
                // condtions for switch statements mus] include a break and
                // default in order to stop the codings running program
        }
        Console.WriteLine("Hello, World!");
    }
}

