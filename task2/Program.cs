Console.WriteLine("Введите 1 число");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 число");
int c1 = Convert.ToInt32(Console.ReadLine());
if (a1 > b1)
{
    if (a1 >c1)
    {
        Console.Write("Большее из  чисел ");
        Console.WriteLine(a1);
    }
    else
    {
        Console.Write("Большее из  чисел ");
        Console.WriteLine(c1);

    }

}else
{
    if (b1 > c1)
    {
        Console.Write("Большее из  чисел ");
        Console.WriteLine(b1);
    }
    else
    {
        Console.Write("Большее из  чисел ");
        Console.WriteLine(c1);

    }

}


