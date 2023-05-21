Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 > 0)
{
    for(int count = 2; num1 > count;count = count +2)
    {
        Console.WriteLine(count);
    
    }
}
else
{
    for(int count = 0; num1 < count;count = count -2)
    {
        Console.WriteLine(count);
    
    }
}
