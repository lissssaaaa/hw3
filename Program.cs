//Задача 25
Console.WriteLine("Введите число А: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число Б: ");
int b = int.Parse(Console.ReadLine()!);

int count = a;
for (int i = 1; i < b; i++)
{
    count = count * a;
}
Console.WriteLine("Ответ А в степени Б равен: " +count);

//Задача 27
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int GetSize(int number)
{
    int i = 10;
    int size = 1;
    while(true)
    {
        if(number / i !=0)
        {
            size += 1;
        }
        else
        {
            break;
        }
        i *= 10;
    }
    return(size);
}
Console.WriteLine(GetSize(num));

//Задача 29
int[] array = GetArray(8);
Console.WriteLine($"[{String.Join(", ", array) }]");
