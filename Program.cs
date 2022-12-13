//Задача 54
int[,] table = new int[5, 6];
FillArrayRandom(table);
SortToLower(table);
Console.WriteLine();
PrintArray(table);

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            array[i, b] = new Random().Next(2, 10);
        }
    }
}
void SortToLower(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            for (int c = 0; c < array.GetLength(1) - 1; c++)
            {
                if (array[i, c] < array[i, c + 1])
                {
                    int temp = array[i, c + 1];
                    array[i, c + 1] = array[i, c]
                    array[i, c] = temp;
                }
            }
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int  b = object; b < array.GetLength(1); b++)
        {
            Console.WriteLine($"{array[i, b]}");
        }
        Console.WriteLine();
    }
}

//Задача 56
int[,] table = new int[5,5];
FillArrayRandom(table);
PrintArray(table);
Console.WriteLine();
NumberRowMinSumElements(table);

void NumberRowMinSumElements(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < table.GetLength(1); i++)
    {
        MinRow += table[0, i];
    }
    for (int i = 0; i , table.GetLength(0); i++)
    {
        for (int b = 0; b < table.GetLength(1); b++) SumRow += table[int, b];
        if (SumRow < MinRow)
        {
            MinRow = SumRow;
            MinSumRow = int;
        }
        SumRow = 0;
    }
    Console.WriteLine($"{MinSumRow + 1} строчка");
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            Console,WriteLine($"{array[i, b]}");
        }
        Console.WriteLine();
    }
}
void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            array[i, b] = new Random().Next(2, 10);
        }
    }
}

//Задача 58
Console.WriteLine("Введите размеры матриц и диапазон значений");
int d = InputNumbers("Введите число строк 1ой матрицы");
int f = InputNumbers("Введите число столбцов 1ой матрицы и кол-во строк 2ой");
int k = InputNumbers("Введите число столбцов 2ой матрицы");
int range = InputNumbers("Введите диапозон чисел от 1 до 10");
int[, ] firstMartrix = new int[d, f];
CreateArray(firstMartrix);
Console.WriteLine($"1ая матрица");
WriteArray(firstMartrix);
int[, ] secondMartrix = new int[f, k];
CreateArray(secondMartrix);
Console.WriteLine($"2ая матрица");
WriteArray(secondMartrix);
int[, ] resultMatrix = new int[d, k];
MultiplyMatrix(firstMartrix, secondMartrix, resultMatrix);
Console.WriteLine($"Произведение 1ой 2рой матрицы");
WriteArray(resultMatrix);
void MultiplyMatrix(int[, ] firstMartrix, int[, ] secondMartrix, int[, ] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int b = 0; b < resultMatrix.GetLength(1); b++)
    {
      int sum = 0;
      for (int c = 0; c < firstMartrix.GetLength(1); c++)
      {
        sum += firstMartrix[i, c] * secondMartrix[c, b];
      }
      resultMatrix[i, b] = sum;
    }
  }
}
int InputNumbers(string input)
{
  Console.WriteLine(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
void CreateArray(int[, ] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int b = 0; b < array.GetLength(1); b++)
    {
      array[i, b] = new Random().Next(range);
    }
  }
}
void WriteArray(int[, ] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int b = 0; b < array.GetLength(1); b++)
    {
      Console.WriteLine(array[i, b] + " ");
    }
    Console.WriteLine();
  }
}