﻿Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
int count = 1;
while (count <= n)
{
    if (count % 2 == 0)
    {
        Console.Write(count + ", ");
        count = count + 1;
    }
    else
    {
        count = count + 1;
    }
}
