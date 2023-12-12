﻿int[,] array = {
            { 11, 202, 3 },
            { 40, 55, 61 },
            { 27, 90, -9 }
        };

        Console.Write("Введите номер строки: ");
        int row = int.Parse(Console.ReadLine()!);

        Console.Write("Введите номер столбца: ");
        int column = int.Parse(Console.ReadLine()!);

         if (row >= 0 && row < array.GetLength(0) && column >= 0 && column < array.GetLength(1))
        {
             int element = array[row, column];
            Console.WriteLine("Значение элемента: " + element);
        }
        else
        {
            Console.WriteLine("Элемент с такими позициями не существует.");
        }