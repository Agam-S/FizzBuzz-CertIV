using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
        for (int counter = 1;
        counter <= 100; counter++)

        if (counter % 3 == 0 && counter % 5 == 0) {

        System.Console.WriteLine("FizzBuzz");
        }

        else if (counter % 3 == 0) {
        System.Console.WriteLine("Fizz");
        }
        
        else if (counter % 5 == 0) {
        System.Console.WriteLine("Buzz");
       }

        else {
        System.Console.WriteLine(counter);
        }
       }
    }
}
