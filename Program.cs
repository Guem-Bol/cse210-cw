using System;

class Program
{
    static void Main(string[] args)
    {
        string inputuserName = DisplayPersonalMessage();
     int inputNumber = DisplayNumber();
     All(inputuserName ,inputNumber );

        DisplayMessage();
        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }

        DisplayPersonalMessage();

        static string DisplayPersonalMessage()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();


        return name;
            
            
        }

        DisplayNumber();

        static int DisplayNumber()

        {
            int number = 0;
            Console.Write("Please enter your favorite number: ");
            number = int.Parse(Console.ReadLine());

            int numb = number * number ;

        return numb;


        }

        

        static void All( string inputuserName, int  inputNumber)

        {
           
         Console.WriteLine($"{inputuserName},The square of your number is {inputNumber}");

            
        }
    }
}