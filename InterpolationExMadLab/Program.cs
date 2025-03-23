using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program will get input from the user and interpolate it in a story
      Author: Radu
      */


      // Let the user know that the program is starting:
      Console.WriteLine("Mad Libs is starting!");
      Console.WriteLine("Please state your name: ");
      string user = Console.ReadLine();
      Console.WriteLine($"Welcome {user}! Let the Mad Libs begin!");


      // Give the Mad Lib a title:
      string title = "\nMAD LIBS";

      Console.WriteLine(title);
      // Define user input and variables:
      string name;
      do {
      Console.Write("Enter a name: ");
      name = Console.ReadLine();
      } while (string.IsNullOrWhiteSpace(name));
      
      string GetUserInput(string prompt) {
      Console.Write(prompt);
      return Console.ReadLine();
      }

      string adjective1 = GetUserInput("Enter a adjective: ");
      Console.Write("Please enter a second adjective: ");
      string adjective2 = Console.ReadLine();
      Console.Write("Please enter a third adjective: ");
      string adjective3 = Console.ReadLine();
      
      Console.Write("Please enter a verb: ");
      string verb = Console.ReadLine();

      Console.Write("Please enter a noun: ");
      string noun1 = Console.ReadLine();
      Console.Write("Please enter a second noun: ");
      string noun2 = Console.ReadLine();

      Console.Write("Please enter the name of an animal: ");
      string animal = Console.ReadLine();
      Console.Write("Please enter the name of a type of food: ");
      string food = Console.ReadLine();
      Console.Write("Please enter the name of a fruit: ");
      string fruit = Console.ReadLine();
      Console.Write("Please enter the name of a superhero: ");
      string superhero = Console.ReadLine();
      Console.Write("Please enter the name of a country: ");
      string country = Console.ReadLine();
      Console.Write("Please enter the name of a dessert: ");
      string dessert = Console.ReadLine();
      Console.Write("Please enter a year: ");
      string year = Console.ReadLine();

      // The template for the story:

      string story = $"This morning {name} woke up feeling {adjective1}. 'It is going to be a {adjective2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adjective3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


      // Print the story:

      Console.WriteLine(story);

    }
  }
}
