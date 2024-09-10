using System;
//Варінт 13
//ЗАВДАННЯ 1

class Exercise1
{
    static void Main()
    {
        string text = "Текст першого завдання по лабороторный 1 з обєктно орієнтовного програмування";
        char letter = 'о';

        // Знайти індекс останнього пропуску
        int lastSpaceIndex = text.LastIndexOf(' ');

        // Отримати частину рядка від останнього пропуску до кінця
        string substring = text.Substring(lastSpaceIndex + 1);

        // Порахувати кількість появ букви
        int count = 0;
        foreach (char c in substring)
        {
            if (c == letter)
            {
                count++;
            }
        }

        Console.WriteLine($"Буква '{letter}' зустрічається {count} разів у частині рядка '{substring}'");
      
    }
}



