using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese tres números:");

        Console.Write("Número 1: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Número 2: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Número 3: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        int smallest = Math.Min(num1, Math.Min(num2, num3));

        Console.WriteLine($"El número más pequeño es: {smallest}");

        if (IsPrime(smallest))
        {
            Console.WriteLine($"{smallest} es un número primo.");
        }
        else
        {
            Console.WriteLine($"{smallest} no es un número primo.");
        }
    }

    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}