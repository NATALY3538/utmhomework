using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Example numbers
        int num1 = 17;
        int num2 = 12;
        int num3 = 25;

        // Find the smallest number
        int smallest = FindSmallest(num1, num2, num3);

        // Check if the smallest number is prime
        bool isPrime = IsPrime(smallest);

        // Print the result
        Console.WriteLine($"The smallest number is: {smallest}");
        if (isPrime)
        {
            Console.WriteLine($"{smallest} is a prime number.");
        }
        else
        {
            Console.WriteLine($"{smallest} is not a prime number.");
        }
    }

    public static int FindSmallest(int a, int b, int c)
    {
        return Math.Min(a, Math.Min(b, c));
    }

    public static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}