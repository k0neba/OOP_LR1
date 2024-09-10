using System;
//Варінт 13
//Завдання 3
class Program
{
    static void Main()
    {
        string sentence = "Це приклад речення для задачі 3 з дисципліни ООП";

        // Розділити речення на слова
        string[] words = sentence.Split(' ');

        foreach (string word in words)
        {
            if (word.Length % 2 == 0)
            {
                // Вивести слово у зворотньому порядку
                char[] charArray = word.ToCharArray();
                Array.Reverse(charArray);
                Console.WriteLine(new string(charArray));
            }
        }
    }
}