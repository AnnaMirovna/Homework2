// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*int SecondDigit(int num)
{
    int twodig = num / 10;
    int remains = twodig % 10;

    return remains;
}

Console.Write("Input a three-digit integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = SecondDigit(num);
Console.Write($"The second digit of the number {num} is {result}");
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*int Digit(int num)
{
    if (num > 99 && num < 1000)
    {
        int result = num % 10;
        return result;
    }
    else
    {
        if (num < 99)
        {
            return -1;
        }
        else
        {
            while (num > 1000)
            {
                num = num / 10;
            }
            int result = num % 10;
            return result;
        }
    }
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int third = Digit(num);
Console.Write($"The third digit of {num} is {third}");
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным... 

/*bool Dayoff(int num)
{
    if (num == 6 || num == 7)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.Write("Input a number that indicates the day of the week to check whether this day is day off: ");
int num = Convert.ToInt32(Console.ReadLine());

bool res = Dayoff(num);
Console.Write(res);
*/

