/*
Напишите программу который принимает на вход координаты двух точек и 
возвращает расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7) -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
Console.Clear();
System.Console.Write("Введите координаты точки Xa " );
int userXa= int.Parse(Console.ReadLine());
System.Console.Write("Введите координаты точки Ya " );
int userYa= int.Parse(Console.ReadLine());
System.Console.Write("Введите координаты точки Za " );
int userZa= int.Parse(Console.ReadLine());
System.Console.Write("Введите координаты точки Xb " );
int userXb= int.Parse(Console.ReadLine());
System.Console.Write("Введите координаты точки Yb " );
int userYb= int.Parse(Console.ReadLine());
System.Console.Write("Введите координаты точки Zb " );
int userZb= int.Parse(Console.ReadLine());

double sqrX= Math.Pow(userXb-userXa,2);
double sqrY= Math.Pow(userYb-userYa,2);
double sqrZ= Math.Pow(userZb-userZa,2);
double sqrt= Math.Sqrt(sqrX+sqrY+sqrZ); 
Console.WriteLine(Math.Round(sqrt,2));

