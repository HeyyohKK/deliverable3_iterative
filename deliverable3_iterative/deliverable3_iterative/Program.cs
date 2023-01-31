/*
 * Kyle Kettles
 * 1/31/23
 * App to 
 * 1. Choose to write your program with only one of the three choices of Iterative Statements: While, For, or Do While (Choose at least 1).
2. Ask the user to enter an integer value between 1 and 100.
3. Ask the user to specify a series of integer numbers. There are two options: even numbers and odd numbers.
4. Then, have the program display the following message: "You have selected the *series name* series. The numbers between 0 and *user’s input* are:”
5. Finally, have the program display all the numbers from the series between 0 and the user’s input. 
*/

using System;
namespace deliverable3_iterative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            string series = "";

            while (true)
            {
                Console.Write("Enter an integer between 1 and 100: ");
                input = int.Parse(Console.ReadLine());
                
                if (input >= 1 && input <= 100)
                {
                    break;
                }
            }

            while (true)
            {
                Console.Write("Specify the series type: Even Or Odd ");
                series = Console.ReadLine();

                if (series == "Even" || series == "Odd")
                {
                    break;
                }
            }

            if (series == "Odd")
            {
                Console.WriteLine("You've selected " + series + " series. The numbers between 0 and " + input + " are:");

                for (int i = 1; i <= input; i = i + 2)
                {
                    Console.Write(i);
                }

            }
            if (series == "Even")
            {
                Console.WriteLine("You've selected " + series + " series. The numbers between 0 and " + input + " are:");

                for (int i = 0; i <= input; i = i + 2)
                {
                    Console.Write(i);
                }

            }
        }
    }
}