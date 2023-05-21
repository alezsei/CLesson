 Console.WriteLine("Введите 1 число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.Write($"Большее из дву чисел {num1}");
}
else

    if (num2 > num1)

    {
        Console.Write($"Большее из дву чисел {num2}");
    }

else 
{
    Console.Write("Они равны");
} 


