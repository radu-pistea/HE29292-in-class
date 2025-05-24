using System;

class Methods
{
    static void Product(string name, int quantity)
    {
        Console.WriteLine($"You have orderd {quantity} {name}s!");
    }

    static void Country (string country = "UK")
    {
        Console.WriteLine($"You are from {country}!");
    }

    static int Square(int number)
    {
        return number * number;
    }

    static void Main(string[] args)
    {
        Product("apple", 5);
        Product("banana", 3);
        Product("orange", 2);
        Console.WriteLine("\n");
        Country("Romania");
        Country();
        Console.WriteLine("\n");
        
        Console.WriteLine("The square of 5 is: " + Square(5));
        Console.WriteLine("\n");
        }
}    