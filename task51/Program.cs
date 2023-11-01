/*
51. Задайте двумерный массив. 
Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
*/
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i,j] + " ");
        }
        System.Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j]= new Random().Next(1,10);
        }
    }
}

void Sum(int[,] sum)
{   int a=0;
    for (int i = 0; i < sum.GetLength(0); i++)
    {
        for (int j = 0; j < sum.GetLength(1); j++)
        {
           if (i==j) a+=sum[i,j];
            
        }
    }
    System.Console.WriteLine(a);
}
int[,] matrix=new int[8,6];
FillArray(matrix);
PrintArray(matrix);
System.Console.WriteLine();
Sum(matrix);

