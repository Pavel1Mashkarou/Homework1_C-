int a = 0;
int b = 0;
int c = 0;
int max = 0;

System.Console.WriteLine("Приветствую Вас в программе для нахождения максимального из трёх чисел.");
System.Console.WriteLine("Введите первое число:");
a = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите второе число:");
b = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите третье число:");
c = int.Parse(Console.ReadLine());

max = a;

if (max > b)
{
    if (max > c)
    {
        System.Console.WriteLine($"Максимальное число - {max}.");
    }
    else 
    {
        max = c;
        System.Console.WriteLine($"Максимальное число - {max}.");
    }
}
else 
{
    max = b;
    if (max > c)
    {
        System.Console.WriteLine($"Максимальное число - {max}.");
    }
    else
    {
        max = c;
        System.Console.WriteLine($"Максимальное число - {max}.");
    }
}
