using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите пятизначное число: ");
        string input = Console.ReadLine();

        if (input.Length == 5)
        {
            int number;
            if (int.TryParse(input, out number))
            {
                if (IsPalindrome(number))
                {
                    Console.WriteLine("Да, число является палиндромом.");
                }
                else
                {
                    Console.WriteLine("Нет, число не является палиндромом.");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: Введите числовое значение.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка: Введите пятизначное число.");
        }
    }

    static bool IsPalindrome(int number)
    {
        string numberString = number.ToString();
        int length = numberString.Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (numberString[i] != numberString[length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
}
