 Console.WriteLine("Введите 1 число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.Write("Большее из дву чисел ");
    Console.WriteLine(a);
}if (b>a)
{
    Console.Write("Большее из дву чисел ");
    Console.WriteLine(b);
}
if (a == b)
{
    Console.Write("Они равны");
} 


