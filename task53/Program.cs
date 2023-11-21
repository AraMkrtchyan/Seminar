/*
53. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
8 4 2 4
5 9 2 3
1 4 7 2
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

void ArraySwap(int[,] mas)
{
    int[] temp= new int[mas.GetLength(1)];
    for (int i = 0; i < temp.Length; i++)
    {
        temp[i]= mas[0,i];
        mas[0,i]=mas[mas.GetLength(0)-1,i];
    }

    for (int i = 0; i < temp.Length; i++)
    {
        mas[mas.GetLength(0)-1,i]=temp[i];
    }
}

int[,] matrix=new int[3,3];
FillArray(matrix);
PrintArray(matrix);
System.Console.WriteLine();
ArraySwap(matrix);
PrintArray(matrix);