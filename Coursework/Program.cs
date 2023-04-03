using System;
using System.Text.RegularExpressions;

namespace Coursework
{
    internal class Program
    {
        //EXERCISE 1: Binary, octal and hexadecimal -----------------------------------------

        //static void Main(string[] args)
        //{
        //    int number = 2039;
        //    string binary = Convert.ToString(number, 2);
        //    Console.WriteLine("Binary: " + binary);

        //    string octal = Convert.ToString(number, 8);
        //    Console.WriteLine("Octal: " + octal);

        //    string hexadecimal = Convert.ToString(number, 16);
        //    Console.WriteLine("Hexadecimal: " + hexadecimal);
        //}

        //static void Main(string[] args)
        //{
        //    int decimalNumber = 2039;

        //    int quotient = decimalNumber;
        //    string binary = "";
        //    while (quotient > 0)
        //    {
        //        binary = (quotient % 2) + binary;
        //        quotient /= 2;
        //    }
        //    Console.WriteLine("Binary representation of " + decimalNumber + " is: " + binary);

        //    quotient = decimalNumber;
        //    string octal = "";
        //    while (quotient > 0)
        //    {
        //        octal = (quotient % 8) + octal;
        //        quotient /= 8;
        //    }
        //    Console.WriteLine("Octal representation of " + decimalNumber + " is: " + octal);

        //    quotient = decimalNumber;
        //    string hexadecimal = "";
        //    while (quotient > 0)
        //    {
        //        int remainder = quotient % 16;
        //        if (remainder < 10)
        //        {
        //            hexadecimal = remainder + hexadecimal;
        //        }
        //        else
        //        {
        //            char hexDigit = (char)('A' + (remainder - 10));
        //            hexadecimal = hexDigit + hexadecimal;
        //        }
        //        quotient /= 16;
        //    }
        //    Console.WriteLine("Hexadecimal representation of " + decimalNumber + " is: " + hexadecimal);
        //}

        //EXERCISE 2: EXERCISE 200 (from schoolbook) ------------------------

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter the coefficients of the first equation (ax + by = c):");
        //    Console.Write("a = ");
        //    double a = double.Parse(Console.ReadLine());
        //    Console.Write("b = ");
        //    double b = double.Parse(Console.ReadLine());
        //    Console.Write("c = ");
        //    double c = double.Parse(Console.ReadLine());

        //    Console.WriteLine("Enter the coefficients of the second equation (dx + ey = f):");
        //    Console.Write("d = ");
        //    double d = double.Parse(Console.ReadLine());
        //    Console.Write("e = ");
        //    double e = double.Parse(Console.ReadLine());
        //    Console.Write("f = ");
        //    double f = double.Parse(Console.ReadLine());

        //    double determinant = a * e - b * d;

        //    if (determinant == 0)
        //    {
        //        Console.WriteLine("The system has no unique solution.");
        //    }
        //    else
        //    {
        //        double x = (c * e - b * f) / determinant;
        //        double y = (a * f - c * d) / determinant;

        //        Console.WriteLine($"The solution of the system is: x = {x} and y = {y}");
        //    }
        //}

        //EXERCISE 3: EXERCISE 48b (from schoolbook) -----------------------------------------------
        //public static double Function(double x)
        //{
        //    if (x <= 0)
        //    {
        //        return x + 2;
        //    }
        //    else if (x < 1)
        //    {
        //        return x - 2;
        //    }
        //    else
        //    {
        //        return 3 * x;
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    double result = Function(4.5);
        //    Console.WriteLine(result);
        //}

        //EXERCISE 4: EXERCISE 83a (from schoolbook) -----------------------------------------------

        //static void Main(string[] args)
        //{
        //    int lower = 1, upper = 100;
        //    while (lower < upper)
        //    {
        //        Console.Write(lower++ + ", ");
        //        Console.Write(lower++ + ", ");
        //        Console.Write(upper-- + ", ");
        //        Console.Write(upper-- + ", ");
        //    }
        //}

        //EXERCISE 5: EXERCISE 375 (from schoolbook) ----------------------------------------------

        //375.1
        //static void Main(string[] args)
        //{
        //    Random rand = new Random();
        //    int[] numbers = new int[32];

        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        numbers[i] = rand.Next(0, 51);
        //    }

        //    Console.WriteLine("Positive integers:");

        //    foreach (int number in numbers)
        //    {
        //        if (number > 0)
        //        {
        //            Console.WriteLine(number);
        //        }
        //    }
        //}

        //375.2
        //static void Main(string[] args)
        //{
        //    int sum = 0;

        //    for (int i = 1; i <= 7; i++)
        //    {
        //        Console.WriteLine("Enter number " + i + ":");
        //        int number = int.Parse(Console.ReadLine());

        //        if (number < 0 || number > 200)
        //        {
        //            sum += number;
        //        }
        //    }

        //    Console.WriteLine("Sum of numbers that are negative or greater than 200: " + sum);
        //}

        //375.3
        //static Random rand = new Random();

        //static double Sred(int k)
        //{
        //    int sum = 0;
        //    int count = 0;

        //    for (int i = 0; i < k; i++)
        //    {
        //        int number = rand.Next(0, 101);
        //        if (number >= 10 && number <= 100)
        //        {
        //            sum += number;
        //            count++;
        //        }
        //    }

        //    return (double)sum / count;
        //}

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter a:");
        //    int a = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Enter b:");
        //    int b = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Enter c:");
        //    int c = int.Parse(Console.ReadLine());

        //    double result = Sred(Math.Abs(a - b)) - Sred(c + a);
        //    Console.WriteLine("Result: " + result);
        //}

        //EXERCISE 6: EXERCISE 412 (from schoolbook) ------------------------------------------

        //412.1a
        //static void Main(string[] args)
        //{
        //    int[] myArray = new int[5];
        //    InputArray(myArray);
        //}

        //private static void InputArray(int[] array)
        //{
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        Console.WriteLine("Enter element at index " + i + ":");
        //        string input = Console.ReadLine();
        //        array[i] = int.Parse(input);
        //    }
        //}

        //412.1b
        static void Main(string[] args)
        {
            int[] myArray = new int[5];
            InputArray(myArray);
        }

        private static void InputArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter element at index " + i + ":");
                string input = Console.ReadLine();
                array[i] = int.Parse(input);
            }

            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 1 && array[i] % 5 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("The count of elements that have an odd index and are divisible by 5 without remainder: " + count);
        }

        //412.2
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter the size of the arrays:");
        //    string input = Console.ReadLine();
        //    int n = int.Parse(input);

        //    int[] arrayA = new int[n];
        //    int[] arrayB = new int[n];
        //    int[] arrayC = new int[n];

        //    InputArray(arrayA);
        //    InputArray(arrayB);
        //    InputArray(arrayC);

        //    int resultA = CalculateOddDivisibleByFive(arrayA);
        //    int resultB = CalculateOddDivisibleByFive(arrayB);
        //    int resultC = CalculateOddDivisibleByFive(arrayC);

        //    Console.WriteLine("In the first array. The count of numbers, that are at an odd index and divisible by 5: " + resultA);
        //    Console.WriteLine("In the second array. The count of numbers, that are at an odd index and divisible by 5: " + resultB);
        //    Console.WriteLine("In the third array. The count of numbers, that are at an odd index and divisible by 5: " + resultC);
        //}

        //private static void InputArray(int[] array)
        //{
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        Console.WriteLine("Enter element at index " + i + ":");
        //        string input = Console.ReadLine();
        //        array[i] = int.Parse(input);
        //    }
        //}

        //private static int CalculateOddDivisibleByFive(int[] array)
        //{
        //    int count = 0;
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (i % 2 == 1 && array[i] % 5 == 0)
        //        {
        //            count++;
        //        }
        //    }
        //    return count;
        //}

        //EXERCISE 7: EXERCISE 360 (from schoolbook) -------------------------------------------------------------------

        //static bool IsIntegerOrIdentifier(string str)
        //{
        //    string intRegex = @"^\d+$";

        //    if (Regex.IsMatch(str, intRegex))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter a string:");
        //    string str = Console.ReadLine();

        //    if (IsIntegerOrIdentifier(str))
        //    {
        //        Console.WriteLine("Integer");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Identifier");
        //    }
        //}
    }
}
