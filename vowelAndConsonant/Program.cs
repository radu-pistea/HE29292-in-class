using System;

class LetterGrades
{
    static void Main()
    {
        string input = "";
        Console.WriteLine("Enter a character: ");
        input = Console.ReadLine();
        Console.WriteLine("Enter a number: ");
        string number = Console.ReadLine();
        //double number = Convert.ToDouble(Console.ReadLine());

        if (input != null)
        {
            char character = char.Parse(input);

            switch (character)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine($"{character} is a vowel");
                    break;
                default:
                    Console.WriteLine($"{character} is a consonant");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input");
        }


        if (number != null)
        {
            /*int numberInt = Convert.ToInt32(number);
            if (number - numberInt  != 0)
            {
                Console.WriteLine($"{number} is not an integer number");
            }
            else
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine($"{number} is an even integer number");
                }
                else
                {
                    Console.WriteLine($"{number} is an odd integer number");
                }
            }*/
            string finalType = "String";
            if (!string.IsNullOrEmpty(number))
            {
                // Check integer before Decimal
                int tryInt;
                /*double tryDouble;
                float tryFloat;*/
                decimal tryDec;

                if (Int32.TryParse(number, out tryInt))
                {
                    finalType = "Integer";
                }
                /*else if (float.TryParse(number, out tryFloat))
                {
                    finalType = "Float";
                }
                else if (double.TryParse(number, out tryDouble))
                {
                    finalType = "Double";
                }*/
            
                else if (Decimal.TryParse(number, out tryDec))
                {
                    finalType = "Decimal";
                
                }
                
            }

            Console.WriteLine(finalType);
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    
    
    }


}
