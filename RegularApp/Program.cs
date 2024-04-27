using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string[] input = File.ReadAllLines(@"C:\Users\user\YandexDisk\Progs_VS\RegularApp\RegularApp\Unit1.txt");
        Task1(input);
        Task2(input);
        Task3(input);
        Task4(input);
    }

    static void Task1(string[] input)
    {
        string pattern = @"^a(\s*a\s*)*$";

        for (int i = 0; i < input.Length; ++i)
        {
            if (Regex.IsMatch(input[i], pattern))
            {
                Console.WriteLine($"Строка {i + 1} удовлетворяет шаблону Task1 (a || aaaaa || a aa a)");
            }
            else
            {
                Console.WriteLine($"Строка {i + 1} не удовлетворяет шаблону Task1");
            }
        }
        Console.WriteLine("==========================================");
    }

    static void Task2(string[] input)
    {
        string pattern = @"^\w{5,}$";

        for (int i = 0; i < input.Length; ++i)
        {
            if (Regex.IsMatch(input[i], pattern))
            {
                Console.WriteLine($"Строка {i + 1} удовлетворяет шаблону Task2 (aaaaa)");
            }
            else
            {
                Console.WriteLine($"Строка {i + 1} не удовлетворяет шаблону Task2");
            }
        }
        Console.WriteLine("==========================================");
    }

    static void Task3(string[] input)
    {

        string pattern = @"^\w+@[a-zA-Z_]+\.[a-zA-Z]{2,}$";

        for (int i = 0; i < input.Length; ++i)
        {
            if (Regex.IsMatch(input[i], pattern))
            {
                Console.WriteLine($"Строка {i + 1} удовлетворяет шаблону Task3 (email)");
            }
            else
            {
                Console.WriteLine($"Строка {i + 1} не удовлетворяет шаблону Task3");
            }
        }
        Console.WriteLine("==========================================");
    }

    static void Task4(string[] input)
    {

        string pattern = @"^(ул\.|пер\.)\s*[А-Яа-я]+\s*д\.\s*\d+\/\d+";
        /*string[] input = { "ул. Высоцкого д. 20/3", "пер. Ленина д. 15/2", "ул. Пушкина д. 10/1" };*/

        for (int i = 0; i < input.Length; ++i)
        {
            Match match = Regex.Match(input[i], pattern);
            if (match.Success)
            {
                string[] parts = input[i].Split(new string[] { "ул.", "пер.", "д.", "/" }, StringSplitOptions.RemoveEmptyEntries);
                string street = parts[0].Trim();
                string houseNumber = parts[1].Trim();
                Console.WriteLine($"Для строки {i + 1}: Название улицы: {street}, Номер дома: {houseNumber}");
            }
            else
            {
                Console.WriteLine($"Для строки {i + 1}: Не найдено");
            }
        }

        Console.WriteLine("==========================================");
    }
}
