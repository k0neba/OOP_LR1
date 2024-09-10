using System;
//Варінт 13
//Завдання 2
class Program
{
    static void Main()
    {
        string text = "Завдання #2 до лр 1 з ООП";

        // Подвоїти кожен символ
        string doubledText = "";
        foreach (char c in text)
        {
            doubledText += new string(c, 2);
        }

        Console.WriteLine($"Подвоєний рядок: {doubledText}");
    }
}
