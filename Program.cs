using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to calculator!");

            Console.Write("What would you like to do?(+,-,*,/): ");
            string answer = Console.ReadLine();
            if (answer == "+")
            {
                Add();
                System.Environment.Exit(0);
            }
            
            else if (answer == "-")
            {
                Subtract();
                System.Environment.Exit(0);
            }

            else if (answer == "*")
            {
                Multiply();
                System.Environment.Exit(0);
            }

            else if (answer == "/")
            {
                Divide();
                System.Environment.Exit(0);
            }

            else 
            {
                Console.WriteLine("Wrong Input... Would you like to try again?(y/n): ");
                string ans2 = Console.ReadLine();
                if (ans2  == "y")
                {
                    while (answer != "+" && answer != "-" &&  answer != "*" && answer != "/") 
                    {
                        tryAgain();
                    }
                }

                else if (ans2 == "n")
                {
                    Console.WriteLine("GoodBye!");
                    Console.ReadKey();
                    System.Environment.Exit(0); 
                }
            }

            // Keep the window open
            Console.ReadKey();
        }

        static void tryAgain()
        {
            Console.Write("What would you like to do?(+,-,*,/): ");
            string answer = Console.ReadLine();
            if (answer == "+")
            {
                Add();
                System.Environment.Exit(0); 
            }
            
            else if (answer == "-")
            {
                Subtract();
                System.Environment.Exit(0);
            }

            else if (answer == "*")
            {
                Multiply();
                System.Environment.Exit(0);
            }

            else if (answer == "/")
            {
                Divide();
                System.Environment.Exit(0);
            }
        }

        static void Add()
        {
            Console.Write("Print the 1st number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Print the 2nd number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double addition = num1 + num2;
            Console.WriteLine(addition);
            Console.ReadKey();
        }

        static void Subtract()
        {
            Console.Write("Print the 1st number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Print the 2nd number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            
            double subtraction = num1 - num2;
            Console.WriteLine(subtraction);
            Console.ReadKey();
        }

        static void Multiply()
        {
            Console.Write("Print the 1st number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Print the 2nd number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            
            double multiplication = num1 * num2;
            Console.WriteLine(multiplication);
            Console.ReadKey();
        }

        static void Divide()
        {
            Console.Write("Print the 1st number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Print the 2nd number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            
            double division = num1 / num2;
            Console.WriteLine(division);
            Console.ReadKey();
        }
    }
}
