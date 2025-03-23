Console.WriteLine("Enter first number: ");
double nr1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter operator: ");
string op = Console.ReadLine();
Console.WriteLine("Enter second number: ");

string input = Console.ReadLine();
if (input == null)
{
    Console.WriteLine("Invalid input");
    return;
}

double nr2 = Convert.ToDouble(input);
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
