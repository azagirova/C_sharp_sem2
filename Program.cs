/*
Задача 10: Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
int SecondNumber(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int num = SecondNumber("Введите трехзначное число: ");
if (num < 100 || num >= 1000) 
{
    Console.WriteLine ("Вы ввели не трехзначное число. Пожалуйста, повторите ввод");
    return;
}
Console.WriteLine ($"Введенное число: {num}");
int secondNumber = num / 10 % 10;
Console.WriteLine ($"Вторая цифра: {secondNumber}");


/*
Задача 13: Напишите программу, которая выводит третью 
цифру заданного числа или сообщает, что третьей цифры 
нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/


int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
int ThirdNumber(int num)
{
    while (num > 999)
    {
        num /= 10;

    }
    return num % 10;
}
bool ValidateNum(int num)
{
    if (num < 100)
    {
        Console.WriteLine("Третьего числа нет");
        return false;
    }
    return true;
}

int num = InputNum("Введите число: ");
if (ValidateNum(num)) ;
{
    Console.WriteLine(ThirdNumber(num));
}

/*
Задача 15: Напишите программу, которая принимает на 
вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
bool Holiday(int weekDay)
{
    if (weekDay > 5)
    {
        return true;
    }
    return false;
}
bool ValidateNum(int num)
{
    if (num > 0 && num < 7)
    {
        return true;
    }
    Console.WriteLine("Такого дня недели нет");
    return false;
}

int weekDay = InputNum("Введите день недели: ");
if (ValidateNum(weekDay)) ;
{
    if (Holiday(weekDay))
    {
        Console.WriteLine("выходные");
    }

    else
    {
    Console.WriteLine("еще будни");
    }
}