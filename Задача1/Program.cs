// Напишите программу, которая принимает на вход пятизначное 
//число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите число");
string namber  = Console.ReadLine();
if (namber[0] == namber[4] || namber[1] == namber[3])
{
    Console.WriteLine("Это число палиндром");
}
else
{
   Console.WriteLine("Это число не палиндром"); 
}