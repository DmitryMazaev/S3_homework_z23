/* Задача 23
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
int i = 1;
if (N>0)
{
    while (i <= N)
    {
        Console.Write(Math.Pow(i, 3) + " ");
        i++;
    }
}
else if (N<=1)
{
    while (N <= i)
    {
        Console.Write(Math.Pow(N, 3) + " ");
        N++;
    }
}
else
{
    Console.Write("Попробуйте еще раз");
}