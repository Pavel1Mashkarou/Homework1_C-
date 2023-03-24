int a = 0;
int b = 2; 

System.Console.WriteLine("Приветсвтую Вас в программе для вывода ряда четных чисел.");
System.Console.WriteLine("Введите число, до которого будет составлен ряд.");
a = int.Parse(Console.ReadLine());

if (a<2)
{
    System.Console.WriteLine("Данная программа предполагает, что число будет больше либо равно 2. Введите корректное число.");
} 
else
{
    while (b<=a)
    {
        System.Console.Write(b+" ");
        b= b + 2;
    }
}