// Задача:
// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

using System;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Введите пять строк для массива:");
        string[] originalArray = new string[5];

        // Заполнение массива строками, введенными пользователем
        for (int i = 0; i < originalArray.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            originalArray[i] = Console.ReadLine();
        }

        // Формирование нового массива из строк, длина которых <= 3 символов
        string[] newArray = FilterArray(originalArray);

        // Вывод нового массива
        Console.WriteLine("\nНовый массив из строк, длина которых <= 3 символов:");
        foreach (var str in newArray)
        {
            Console.WriteLine(str);
        }

        Console.ReadLine(); // Чтобы консольное окно не закрылось сразу
    }

    static string[] FilterArray(string[] inputArray)
    {
        // Подсчет количества строк, длина которых <= 3 символов
        int count = 0;
        foreach (var str in inputArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        // Создание нового массива
        string[] newArray = new string[count];

        // Заполнение нового массива
        int index = 0;
        foreach (var str in inputArray)
        {
            if (str.Length <= 3)
            {
                newArray[index] = str;
                index++;
            }
        }

        return newArray;
    }
}
