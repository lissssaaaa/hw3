//Задача 10
Console.Write("Введи трёхзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);

//Задача 13
int n = Random().Next(1, 100000);
int b = ( n % 1000)/100;
Console.WriteLine(n);
if ( b > 0)
{
    Console.WriteLine(b);
}
else
{
    Console.WriteLine("Нет числа");
}

//Задача 15
int den = new Random().Next(1, 8);
Console.WriteLine("Введи число");
int den = int.Parse(Console.ReadLine()!);
if (den == 1){Console.WriteLine("Пн");}
if (den == 2){Console.WriteLine("Вт");}
if (den == 3){Console.WriteLine("Ср");}
if (den == 4){Console.WriteLine("Чт");}
if (den == 5){Console.WriteLine("Пт");}
if (den == 6){Console.WriteLine("Сб");}
if (den == 7){Console.WriteLine("Вс");}
if (den == 8){Console.WriteLine("откисаем");}
else{
    Console.WriteLine("Проверче число от 1 до 7");
}