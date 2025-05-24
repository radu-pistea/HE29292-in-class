using System;
using System.Diagnostics;

public class NewCalc
{
    static double Add(double a, double b)
    {
        return a + b;
    }


    static double Subtract(double a, double b)
    {
        return a - b;
    }

    static double Multiply(double a, double b)
    {
        return a * b;
    }

    static double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        return a / b;
    }
    static void Main (string[] args)
    {
        Console.WriteLine("Enter operator (+, -, *, /): ");
        string op = Console.ReadLine();
        
        Console.WriteLine("Enter first number: ");
        double nr1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter second number: ");
        double nr2 = Convert.ToDouble(Console.ReadLine());

        

        double result = 0;

        switch (op)
        {
            case "+":
                result = Add(nr1, nr2);
                break;
            case "-":
                result = Subtract(nr1, nr2);
                break;
            case "x":
            case "*":
                result = Multiply(nr1, nr2);
                break;
            case "/":
                if (nr2 != 0)
                {
                    result = Divide(nr1, nr2);
                }
                else
                {
                    Console.WriteLine("Cannot divide by zero");
                    return;
                }
                break;
            default:
                Console.WriteLine("Invalid operator");
                break;
        }

        Console.WriteLine("Result: " + result);
    }
    
}