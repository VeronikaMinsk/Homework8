// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int n = 4;
int row = n;
int colomns = n;
int[,] array = new int[row, colomns];

int numbers = 1;
int i = 0;
int j = 0;

while (numbers <= row * colomns)
{
  array[i, j] = numbers;
  numbers++;
  if (i <= j + 1 && i + j < colomns - 1)
    j++;
  else if (i < j && i + j >= row - 1)
    i++;
  else if (i >= j && i + j > colomns - 1)
    j--;
  else
    i--;
}

WriteArray(array);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}