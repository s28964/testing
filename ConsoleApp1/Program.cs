﻿class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        double average = CalculatingAverage(numbers);
        Console.WriteLine($"Średnia: {average}");
    }

    static double CalculatingAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Tablica jest pusta");
        }

        return numbers.Average();
    }
}

