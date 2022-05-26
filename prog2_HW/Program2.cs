// Нахождение минимума -максимума из 2-х чисел
Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
if (b > a)
{
    Console.WriteLine("max = " + b);
}
else if (b == a)
{

    Console.WriteLine("a = b = " + a);
}
else
{
    Console.WriteLine("max = " + a);
}