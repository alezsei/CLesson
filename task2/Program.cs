﻿Console.WriteLine("Введите 1 число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 число");
int num3 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    if (num1 > num3)
    {
        Console.Write($"Большее из чисел {num1}");
    }
    else
    {
         Console.Write($"Большее из чисел {num3}");
    }

}else
{
    if ( num2 > num3)
    {
        Console.Write($"Большее из чисел {num2}");
    }    
    else
    {
        Console.Write($"Большее из чисел {num3} ");
    }

}


