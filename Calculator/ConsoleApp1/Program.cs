static int Add(int a, int b)
{
    return a + b;
}
static int Subtract(int a, int b)
{
    return a - b;
}
static int Multiply(int a, int b)
{
    return a * b;
}
static double Divide(int a, int b)
{
    if (b == 0)
    {
        Console.WriteLine("Cannot divide by zero");
        return 0;
    }
    return (double)a / b;
}

void Main(string[] args)
{
    Console.WriteLine("Please choose an operator: +, -, x, /");
    string op = Console.ReadLine();
    
    Console.WriteLine("Enter first number: ");
    double nr1 = Convert.ToDouble(Console.ReadLine());
    
    Console.WriteLine("Enter second number: ");
    double nr2 = Convert.ToDouble(Console.ReadLine());
    double result = 0;

    switch (op)
    {
        case "+":
            result = Add(nr1 + nr2);
            break;
        case "-":
            result = Subtract(nr1 - nr2);
            break;
        case "x":
        case "*":
            result = Multiply(nr1 * nr2);
            break;
        case "/":
            if (nr2 != 0)
            {
                result = Divide(nr1 / nr2);
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
}
/*


if (op == "+")
{
    result = nr1 + nr2;
}
else if (op == "-")
{
    result = nr1 - nr2;
}
else if (op == "x" || op == "*")
{
    result = nr1 * nr2;
}
else if (op == "/" && nr2 != 0)
{
    result = nr1 / nr2;
}
else if (op == "/" && nr2 == 0)
{
    Console.WriteLine("Cannot divide by zero");
    return;
}
else
{
    Console.WriteLine("Invalid operator");
}
Console.WriteLine("Result: " + result);
