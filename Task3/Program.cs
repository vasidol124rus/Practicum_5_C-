int rows = 4;
int columns = 6;
int[,] matrix = new int[rows, columns];
void InputMatrix(int[,] matrix){
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
       
        int minSum = int.MaxValue;
        int minSumRowIndex = -1;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int rowSum = 0;

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                rowSum += matrix[i, j];
            }

            if (rowSum < minSum)
            {
                minSum = rowSum;
                minSumRowIndex = i;
            }
        }
        Console.WriteLine("Строка с наименьшей суммой элементов: " + minSumRowIndex);
}
Console.Clear();
InputMatrix(matrix);
Console.WriteLine("Начальный массив: ");
PrintMatrix(matrix);

    
