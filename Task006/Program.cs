int a = 0;
int ost = 0;

System.Console.WriteLine("Приветсвую Вас в программе определения чётного числа.");
System.Console.WriteLine("Введите число:");
a = int.Parse(Console.ReadLine());

ost = a % 2;

if (ost == 0)
{
    System.Console.WriteLine($"Число {a} - чётное.");
}
else
{
    System.Console.WriteLine($"Число {a} - нечётное.");
}