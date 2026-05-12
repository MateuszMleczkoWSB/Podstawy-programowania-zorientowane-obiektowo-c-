using System;
using System.Diagnostics.Metrics;
/// Exercise 1: reminder of the basics of programming

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        //Calc();
        //TempConverter();
        GradesAverage();
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
                if (num2 == 0)
                {
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
    }

    static void TempConverter()
    {
        Console.WriteLine("Temperature converter (Celsius --> Fahrenheit)");

        Console.Write("Enter operation: ('c' - If you want to convert Celsius to Fahrenheit; 'f' - If you want to convert Fahrenheit to Celsius): ");
        string operation = Console.ReadLine();


        Console.WriteLine("Enter temperature to convert: ");
        double temp = double.Parse(Console.ReadLine());

        double result;

        switch (operation)
        {
            case "c":
                Console.WriteLine("Celsius --> Fahrenheit");
                result = (temp * 1.8) + 32;
                Console.WriteLine($"{temp}℃ = {result}℉");
                break;
            case "f":
                Console.WriteLine("Fahrenheit --> Celsius");
                result = (temp - 32) / 1.8;
                Console.WriteLine($"{temp}℉ = {result}℃");
                break;
            default:
                Console.WriteLine("Entered wrong operation (type 'c' or 'f'");
                TempConverter();
                break;
        }
    }

    static void GradesAverage()
    {
        Console.WriteLine("Student's grades average");

        Console.WriteLine("Enter number of grades");
        double numOfGrades = int.Parse(Console.ReadLine());
        double sum = 0;
        int grade;

        for (int i = 0; i < numOfGrades; i++)
        {
            while (true)
            {
                Console.WriteLine("Enter grade (1-6): ");
                grade = int.Parse(Console.ReadLine());

                if (grade < 1 || grade > 6)
                {
                    continue;
                }
                else
                {
                    sum += grade;
                    break;
                }
            }
        }

        double average = sum / numOfGrades;
        Console.WriteLine($"Grades average: {average}");

        if (average >= 3)
        {
            Console.WriteLine("Stundet passed");
        }
        else
        {
            Console.WriteLine("Stundet failed");
        }

    }
}