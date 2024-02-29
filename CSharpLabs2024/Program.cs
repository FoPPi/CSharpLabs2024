using System;
using System.Globalization;

namespace CSharpLabs2024
{
    internal class Program
    {
        private static Random rnd = new Random();
        
        static void Main(string[] args)
        {
            Task1();
            
            Task2();
            
            Task3();
            
            Task4();
        }
        
        private static void Task1()
        {
            Console.WriteLine("Task 1");
            
            Console.Write("Input numbers sep by space: ");
            string text = Console.ReadLine();
            
            string[] numbersStr = text.Split(' ');
            
            int[] numbers = new int[numbersStr.Length];
            
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(numbersStr[i]);
            }

            Console.Write("In range from 1 to 41: ");
            foreach(int number in numbers)
            {
                if (number >= 1 & number <= 41)
                {
                    Console.Write(number + " ");
                }
            }
        }
        
        private static void Task2()
        {
            Console.WriteLine("Task 2");

            double[] numbers = new double[3];
            
            for (int i = 0; i < 3; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
                
            }
            
            double a = numbers[0], b = numbers[1], c = numbers[2];
            
            
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                Console.WriteLine("Error: Not a triangle");
                return;
            }
            
            double P = a + b + c;

            double p = P / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            
            string type;
            if (a == b && b == c)
            {
                type = "Equilateral";
            }
            else if (a == b || a == c || b == c)
            {
                type = "Isosceles";
            }
            else
            {
                type = "Versatile";
            }

            // Виведення результатів
            Console.WriteLine($"Perimeter of a triangle: {P}");
            Console.WriteLine($"Area of the triangle: {S}");
            Console.WriteLine($"Triangle type: {type}");
        }
        
        private static void Task3()
        {
            Console.WriteLine("Task 3");
            
            int[] numbers = new int[41];
            
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 101);
            }

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            
            
            Console.WriteLine("Min: " + numbers.Min());
            Console.WriteLine("Max: " + numbers.Max());

            Console.WriteLine("or");
            
            Array.Sort(numbers);

            Console.WriteLine("Min: " + numbers[0]);
            Console.WriteLine("Max: " + numbers[^1]);

        }
        
        private static void Task4()
        {
            Console.WriteLine("Task 4");

            Console.Write("Input number: ");
            int userNum = Convert.ToInt16(Console.ReadLine());
            
            int[] numbers = new int[41];
            
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(-50, 51);
            }
            
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            
            Console.WriteLine("Positive numbers: ");
            List<int> positiveNumbers = new List<int>();
            foreach (int number in numbers)
            {
                if (number >= Math.Abs(userNum))
                {
                    positiveNumbers.Add(number);
                }
            }
            
            foreach (int number in positiveNumbers)
            {
                Console.Write(number + " ");
            }
        }
        
    }
}