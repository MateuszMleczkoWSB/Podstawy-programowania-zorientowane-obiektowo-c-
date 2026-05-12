using System;
/// Exercise 1: reminder of the basics of programming

class Program
{
    static void Main(string[] args)
    {
        Calc();
    }
    /// Simple two-number calculator
    static void Calc()
    {
        Console.WriteLine("Simple two-number calculator");

        Console.Write("Enter first num: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Enter second num: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.Write("Enter operation number: ('+' - plus; '-' - minus; '*' - multiply; '/' - divide): ");
        string operation = Console.ReadLine();

        double result;

        switch (operation)
        {
            case "+":
                result = num1 + num2;
                Console.WriteLine($"Result: {result}\n");
                break;
            case "-":
                result = num1 - num2;
                Console.WriteLine($"Result: {result}\n");
                break;
            case "*":
                result = num1 * num2;
                Console.WriteLine($"Result: {result}\n");
                break;
            case "/":
                if (num2 == 0) {
                    Console.WriteLine("You can't divide by zero");
                    return;
                }

                result = num1 / num2;
                Console.WriteLine($"Result: {result}\n");
                break;
            default:
                Console.WriteLine("Wrong operation selected");
                Calc();
                break;
        }

        //if (operation == "+")
        //{
        //    Console.WriteLine($"Result: {num1 + num2}\n");
        //}
        //else if (operation == "-")
        //{
        //    Console.WriteLine($"Result: {num1 - num2}\n");
        //}
        //else if (operation == "*")
        //{
        //    Console.WriteLine($"Result: {num1 * num2}\n");
        //}
        //else if (operation == "/")
        //{
        //    if (num2 == 0)
        //    {
        //        Console.WriteLine("You can't divide by zero\n");
        //        return;
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Result: {num1 / num2}\n");
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("Wrong operation selected\n");
        //    Calc();
        //}
    }
}