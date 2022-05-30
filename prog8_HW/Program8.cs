// Все четные числа от 1 до N
Console.Write("Введите число N (больше единицы): ");
int N = Convert.ToInt32(Console.ReadLine());
int a = 2;
if (N <= 1)
{
    Console.WriteLine("Ошибка ввода");
}
else
{
    while (a <= N)
    {
        Console.Write(a + " ");
        a += 2;
    }

}
