void InputMatrix(int[,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            
            matrix[i, j] = new Random().Next(1, 100);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void ReplacingStrings(int[,] matrix){

        int row1 = 0;
        int row2 = 2; 

        if (row1 >= 0 && row1 < matrix.GetLength(0) && row2 >= 0 && row2 < matrix.GetLength(0))
        {
            int[] tempRow = new int[matrix.GetLength(1)];

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                tempRow[i] = matrix[row1, i];
            }
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                matrix[row1, i] = matrix[row2, i];
            }

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                matrix[row2, i] = tempRow[i];
            }
           
        }
        else
        {
            Console.WriteLine("Некорректные позиции строк для замены.");
        }
    
}
    
Console.Clear();
Console.Write("Введите размеры двумерного массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Начальный массив: ");
PrintMatrix(matrix);
Console.WriteLine("Измененный массив:");
ReplacingStrings(matrix);
PrintMatrix(matrix);