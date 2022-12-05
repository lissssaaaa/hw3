//Задача 41
Console.WriteLine("Введите элементы");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Количество элементов > 0");

//Задача 43
Console.WriteLine($"Ввод массива [ {String.Join(", ", array)} ]");
Console.WriteLine($"Фильтрация по возрастанию [ {String.Join(", ", SortArray(array))} ]");

int[] SortArray(int[] array)
{
    int tempNum = 0;
    bool flag = true;
    while (flag)
    {
        flag = false;
        for (int i = 0; i < array.Length -1; i++)
        {
            if (array[i] > array[i + 1])
            {
                tempNum = array[i];
                array[i] = array[i + 1];
                array[i + 1] = tempNum;
                flag = true;
            }
        }
    }
    return array;
}
int[] GetArrayRandom(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    returnt array;
}
