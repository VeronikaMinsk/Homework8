// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine($"\nЗадайте размер массива m x n и диапазон случайных значений:");
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
int range = InputNumbers("Введите диапазон: от 1 до ");

int[,] array = new int[m, n];
FillArray(array);
WriteArray(array);

void FillArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
        array[i, j] = new Random().Next(range);
  }
}

int minSumm = 0;
int summLine = lineNumbersSumm(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSummLine = lineNumbersSumm(array, i);
        if (summLine > tempSummLine)
            {
            summLine = tempSummLine;
            minSumm = i;
            }
}

Console.WriteLine($"\n{minSumm+1} - строкa с наименьшей суммой ({summLine}) элементов ");


int lineNumbersSumm(int[,] array, int i)
{
  int summLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    summLine += array[i,j];
  }
  return summLine;
}




int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
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