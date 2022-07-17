// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
 
Console.WriteLine("Введите xa");
int xa = int.Parse(Console.ReadLine());
Console.WriteLine("Введите ya");
int ya = int.Parse(Console.ReadLine());
Console.WriteLine("Введите za");
int za = int.Parse(Console.ReadLine());
Console.WriteLine("Введите xb");
int xb = int.Parse(Console.ReadLine());
Console.WriteLine("Введите yb");
int yb = int.Parse(Console.ReadLine());
Console.WriteLine("Введите zb");
int zb = int.Parse(Console.ReadLine());

double Distance (int xaLocal, int yaLocal, int xbLocal, int ybLocal,
                 int zaLocal, int zbLocal)
{ 
   double Distance = Math.Sqrt(Math.Pow((xbLocal-xaLocal),2)
                           + Math.Pow((ybLocal - yaLocal),2)
                           + Math.Pow((zbLocal - zaLocal),2));
                           return Distance;
}
Console.WriteLine(Distance (xa, ya, xb, yb, za, zb));
