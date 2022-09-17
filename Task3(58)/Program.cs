// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.



int m = InputNumbers("Введите число строк 1-й матрицы: ");
int n = InputNumbers("Введите число столбцов 1-й матрицы и строк 2-й матрицы: ");
int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
int range = InputNumbers("Введите диапазон: от 1 до ");

int[,] firstMatrix = new int[m, n];
fillArray(firstMatrix);
Console.WriteLine($"Первая матрица: ");
WriteArray(firstMatrix);

int[,] secondMatrix = new int[n, p];
fillArray(secondMatrix);
Console.WriteLine($"Вторая матрица: ");
WriteArray(secondMatrix);

int[,] resultMatrix = new int[m, p];

MultiplyMatrix(firstMatrix, secondMatrix, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матрицы: ");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < resultMatrix.GetLength(1); k++)
                sum += firstMatrix[i, k] * secondMatrix[k,j];
                resultMatrix[i, j] = sum;
        }
    }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void fillArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}

