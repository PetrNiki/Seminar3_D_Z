// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
Console.WriteLine("Введите число");
int namber = int.Parse(Console.ReadLine());

double Result(int iLocal)
{
    return Math.Pow(iLocal, 3);
}
for(int i = 1; i <= namber; i++)
{
    Console.WriteLine(Result(i));
}
