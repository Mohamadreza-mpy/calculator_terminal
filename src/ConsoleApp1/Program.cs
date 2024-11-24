using System;

class Program
{
    static void Main()
    {
        string continueProgram = "no";

        do
        {
            
            Console.WriteLine("Enter number1 (decimal allowed):");
            double number1 = Convert.ToDouble(Console.ReadLine()); 

            Console.WriteLine("Enter operator (+, -, *, /):");
            string sym = Console.ReadLine();

            Console.WriteLine("Enter number2 (decimal allowed):");
            double number2 = Convert.ToDouble(Console.ReadLine());

           
            double result = 0;

            
            switch (sym)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    if (number2 != 0) 
                    {
                        result = number1 / number2;
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                        continue; 
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    continue; 
            }

           
            Console.WriteLine("Result: " + result);

            
            Console.WriteLine("Do you want to perform another calculation? (yes/no):");
            continueProgram = Console.ReadLine()?.ToLower();

        } while (continueProgram == "yes");

        Console.WriteLine("Thank you for using the calculator!");
    }
}
