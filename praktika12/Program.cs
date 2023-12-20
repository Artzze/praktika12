using System;

class Program
{
    static void Main()
    {
        string input = "функция должна работать эффективно. Финал!";

        // Подсчет количества букв 'ф' и 'Ф' в строке
        int countF = 0;
        foreach (char c in input)
        {
            if (c == 'ф' || c == 'Ф')
            {
                countF++;
            }
        }

        // Удаление всех букв 'ф' и 'Ф' из строки
        string stringWithoutF = input.Replace("ф", "").Replace("Ф", "");

        // Замена каждой точки на две точки и два восклицательных знака
        string finalString = stringWithoutF.Replace(".", "..!!");

        Console.WriteLine($"Исходная строка: {input}");
        Console.WriteLine($"Количество букв 'ф': {countF}");
        Console.WriteLine($"Строка без букв 'ф': {stringWithoutF}");
        Console.WriteLine($"Финальная строка: {finalString}");
    }
}
