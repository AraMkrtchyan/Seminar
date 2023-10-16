/*22. Напишите программу, которая принимает на вход число (N) и 
выдаёт таблицу квадратов чисел от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4*/

System.Console.Write("Введите Число " );
double numb= double.Parse(Console.ReadLine());
for (double i= 1; i <= numb; i++)
{
    double num=Math.Pow(i,2);
    System.Console.WriteLine($"{i} * {i} = {num}");
}

