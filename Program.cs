//Задача 64
int N = InputInt("Введите число болше нуля");
int i =1;
Console.WriteLine(NaturalNumber(N, i));

int NaturalNumber(int N, int i)
{
    if (N == i)
        return N;
    else 
       Console.WriteLine($"{NaturalNumber(N, i + 1)}");


    return i;
}
int InputInt(string outpt);
{
    Console.WriteLine(output);
    return int.Parse(Console.ReadLine());
}

//Задача 66
Console.WriteLine("Введите первое число М");
int numM = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число N");
int numN = int.Parse(Console.ReadLine());

GapNumberSum(numM, numN, 0);

//Задача 68
Console.WriteLine("Введите два положительных числа");
int m = InputInt("Введите  число m");
int n = InputInt("Введите число n");
Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");

int InputInt(string output)
{
    Console.WriteLine(output);
    return int.Parse(Console.ReadLine());
}
int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else 
        return Akkerman(m - 1, Akkerman(m, n - 1));
}
