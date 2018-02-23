using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double height;
            double width;
            double perimeter;
            string input;
            Console.WriteLine("Hello, What Is YOUR Name: ");

            input =  Console.ReadLine();
            Console.WriteLine("Hello " + input);
            Console.ReadLine();
            Console.WriteLine("Enter a height");
            input = Console.ReadLine();
            height = double.Parse(input);
            Console.WriteLine("Enter a width");
            input = Console.ReadLine();
            width = double.Parse(input);
            perimeter = (height + width) *2;
            Console.WriteLine("Perimeter is: " + perimeter);
            Console.ReadLine();
                   
                    }
    }
}
