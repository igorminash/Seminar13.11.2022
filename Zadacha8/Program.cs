﻿Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

int number = 1;

while (number <= N)
{
    if (number % 2 == 0)
    {
        Console.WriteLine(number);  
    }
    number ++;
}