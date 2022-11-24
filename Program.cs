//Задача 19
Console.WriteLine("Введите число");
string sum = Console.ReadLine();
int len = sum.Length;

if (len == 5)
{
    if (sum[0] == sum[4] && sum[1] == sum[3])
    {
        Console.WriteLine($"{sum} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{sum} - не палиндром");
    }
}
else
{
    Console.WriteLine($"Ошибка: {sum} - не пятизначное число");
}

//Задача 21
int[] mas = {3, 6, 8, 2, 1, -7};
int[] mas = {7, -5, 0, 1, -1, 9};

double masR = Math.Sqrt(Math.Pow(mas[0]-mas[2]-mas[4], 3) + Math.Pow(mas[1]-mas[3]-mas[5], 3));
Console.WriteLine($"{masR:f2}");

//Задача 23
Console.WriteLine("Введи число");
int num = int.Parse(Console.ReadLine()!);
if (num < 0)
{
    Console.WriteLine("Число отрицательно преобразовано в положительное");
    num = -num;
}
for (int i = 1; i <= num; i++)
{
    Console.WriteLine($"{Math.Pow(i, 3)}");
}