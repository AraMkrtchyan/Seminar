/*20. Напишите программу, которая принимает на вход координаты двух точек и находит
расстояние между ними в 2D пространстве.*/
Console.Clear();
System.Console.Write("Введите координаты точки Xa " );
int userXa= int.Parse(Console.ReadLine());
System.Console.Write("Введите координаты точки Ya " );
int userYa= int.Parse(Console.ReadLine());
System.Console.Write("Введите координаты точки Xb " );
int userXb= int.Parse(Console.ReadLine());
System.Console.Write("Введите координаты точки Yb " );
int userYb= int.Parse(Console.ReadLine());
//int num1= ((userXb - userXa)*(userXb - userXa))+((userYb - userYa)*(userYb - userYa));
double sqrX= Math.Pow(userXb-userXa,2); //Math.Pow astichan e barcracnum
double sqrY= Math.Pow(userYb-userYa,2);
double sqrt= Math.Sqrt(sqrX+sqrY); //Math.Sqrt armat e hanum 
Console.WriteLine(Math.Round(sqrt,3)); //Math.Round kloracnum e ,ic heto 