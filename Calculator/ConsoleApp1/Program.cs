Console.WriteLine("Enter first number: ");
double nr1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter operator: ");
string op = Console.ReadLine();
Console.WriteLine("Enter second number: ");
double nr2 = Convert.ToDouble(Console.ReadLine());
double result = 0;

switch (op)
{
    case "+":
        result = nr1 + nr2;
        break;
    case "-":
        result = nr1 - nr2;
        break;
    case "x":
    case "*":
        result = nr1 * nr2;
        break;
    case "/":
        if (nr2 != 0)
        {
            result = nr1 / nr2;
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
