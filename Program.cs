//Задача 47
Console.WriteLine("Введите кол-во строк");
int linesVal = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов");
int columsVal = Convert.ToInt32(Console.ReadLine());
double[,] num = new double[linesVal, columsVal];
FillArrayRandomNumbers(num);
PrintArray(num);

void FillArrayRandomNumbers(double[,] array) 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            array[i, b] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine("[ ");
        for (int b = 0; b < array.GetLength(1); b++)
        {
            Console.WriteLine(array[i, b] + " ");
        }
        Console.WriteLine("] ");
        Console.WriteLine("");
    }
}

//Задача 50
int rows = ReadInt("Введите индекс строки");
int colums = ReadInt("Введите индекс столца");
int[,] num = new int[7, 9];
FillArray2D(num);
PrintArray2D(num);

if (rows < num.GetLength(0) && colums < num.GetLength(1)) Console.WriteLine(num[rows, colums]);
else Console.WriteLine($"{rows}{colums} - этого числа нет в массиве");

void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            array[i, b] = new Random().Next(1, 10);
        }
    }
}
void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            Console.WriteLine(array[i, b] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int ReadInt(string message)
{
    Console.WriteLine(message);
return ConsoleCancelEventArgs.ToInt32(Console.ReadLine());
}

//Задача 52
Random = new Random();
int[,] arr = new int[random.Next(1, 9), random.Next(1, 9)];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int b = 0; b < Array.GetLength(1); b++)
    {
        arr[i, b] = Random.Next(1, 9);
        Console.WriteLine(arr[i, b] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine(arr.GetLength(0));
for (int b = 0; b < Array.GetLength(1); b++)
{
    double sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, b];
    }
    Console.WriteLine($"{sum / arr.GetLength(0)}");
}
Console.ReadLine();