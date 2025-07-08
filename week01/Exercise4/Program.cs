using System;

class Program
{
    static void Main(string[] args)
    {
           List<int> numbers = new List<int>();    
    int Number = 100;
    
    

    Console.WriteLine("Enter a list of numbers, type 0 when finished.");

    while (Number != 0)
    
    {
        
        Console.Write("Enter number: ");
        Number = int.Parse(Console.ReadLine());

         if (Number != 0)

            {
             numbers.Add(Number);
            }
      

      
        
    }

     int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");


        int Max = numbers[0];

        foreach (int number in numbers)

        {

            if (number > Max)
            {
                Max = number;
                Console.WriteLine($"The maxinum number is: {Max}");
               
            }

        
        }
    }
}