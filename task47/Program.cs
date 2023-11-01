/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Hапишите метод , которыe указывают на минимальную и максимальную границы случайных чисел.
*/

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(Math.Round(matr[i,j],2) + "  ");
        }
        System.Console.WriteLine();
    }
}

void FillArray(double[,] matr)
{
    System.Console.WriteLine("Введите минимальное число");
    int a=int.Parse(Console.ReadLine());
    System.Console.WriteLine("Введите максимальное число");
    int b=int.Parse(Console.ReadLine());
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j]=new Random().NextDouble()+new Random().Next(a,b);
            
        }
    }
    System.Console.WriteLine($"По введеним числам minLimitRandom = {a}, maxLimitRandom = {b}");
}

System.Console.WriteLine("Введите границу массива");
int n=int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите вторую границу массива");
int m=int.Parse(Console.ReadLine());
double[,] matrix=new double[m,n];
FillArray(matrix);
PrintArray(matrix);

