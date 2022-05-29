// Нахождение максимального из трех чисел
Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число с: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

if (b >= max)
{
    max = b;
}
else if (c >= max)
{
    max = c;
}

Console.WriteLine("max = " + max);
