//Задача 34
int size = ReadInt("Введите размерность массива: ");
int [] numbers = new int[size];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int result = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        result++;
    }
}
if (result % 10 == 1)
{
    Console.WriteLine($"В массиве {result} четное число");
}
if (result % 10 == 2 || result % 10 == 3 || result % 10 == 4)
{
    Console.WriteLine($"В массиве {result} четных чисел");
}
else
Console.WriteLine($"В массиве {result} четных чисел");

//Задача 36
int size = ReadInt("Введите размерность массива: ");
int min = ReadInt("Введите минимальное число массива: ");
int max = ReadInt("Введите максимальное число массива: ");
int [] numbers = new int[size];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int result = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if(i % 2 != 0)
    {
        result += numbers[i];
    }
}
Console.WriteLine($"Сумма элементов нечетных позиций = {result}");

//Задача 37
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);

int[] PairInArray(int[] array)
{
    int 1 = array.Length, size = 1/2;
    int[]array2;
    if (1 % 2 == 0)
    array2 = new int[size];
    else
    {
        array2 = new int[(size +1)];
        array2[size] = array[size];
    }
    for (int i = 0; i < size; i++, 1--)
    array2[i] = array[1-1];
    return array2;
}

//Задача 38
int size = ReadInt("Введите размер массива: ");
int min = -10; //ReadInt("Введите минимальное число массива:");
int max = 10; //ReadInt("Введите максимальное число массива: ");
int [] numbers = new int[size];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);

int maxFillarray = numbers[0];
int minFillarray = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > maxFillarray)
    {
        maxFillarray = numbers[i];
    }
    if (numbers[i] < minFillarray)
    {
        minFillarray = numbers[i];
    }
}
Console.WriteLine($"Разница между максимальным и минимальным числом = {maxFillarra - minFillarray}");

