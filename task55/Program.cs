/*
55. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
В итоге получается вот такой массив:
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
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

int[,] ArraySwap(int[,] mas)
{
    if (mas.GetLength(0)!=mas.GetLength(1))
    {
        System.Console.WriteLine("its unposible");
        return mas;
    }
    int[,]result=new int[mas.GetLength(0),mas.GetLength(1)];
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j <mas.GetLength(1); j++)
        {
            result[i,j]=mas[j,i];
        }
    }
   return result;
}


int[,] matrix=new int[3,3];
FillArray(matrix);
PrintArray(matrix);
System.Console.WriteLine();
int[,]swap=ArraySwap(matrix);
PrintArray(swap);