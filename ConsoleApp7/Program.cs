using System;
public static class ExtensionMethods
{
    public static bool IsOdd(this int number)
    {
        return number % 2 != 0;
    }
}

public static class IntExtensions
{
    public static bool IsPrime(this int num)
    {
        if (num <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
        }

        return true;
    }
}

public static class StringExtensions
{
    public static int CountVowels(this string str)
    {
        int count = 0;

        foreach (char c in str)
        {
            if ("AEIOUaeiou".IndexOf(c) >= 0)
                count++;
        }

        return count;
    }
}
class Program
{
    static void Main()
    {
       //1-2 
        Console.WriteLine("Введіть своє число: " );
        int number = int.Parse(Console.ReadLine());

        if (number.IsOdd())
        {
            Console.WriteLine("Число є непарним.", number);
        }
        else
        {
            Console.WriteLine("Число є парним.", number);
        }

        //3
        int[] numbers = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.WriteLine("Масив 1-10 : ");

        foreach (var num in numbers)
        {
            Console.WriteLine($"{num} просте: {num.IsPrime()}");
        }

        //4
        string[] words = { "hello", "world", "apple", "banana", "orange" };      
        foreach (var word in words)
        {
            Console.WriteLine($"The word '{word}' contains {word.CountVowels()} vowels.");
        }
    }
}