/*
49. Задайте двумерный массив.
 Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
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

void Sqrt(int[,] sqrt)
{
    for (int i = 0; i < sqrt.GetLength(0); i++)
    {
        for (int j = 0; j < sqrt.GetLength(1); j++)
        {
           if (i%2==0 & j%2==0) sqrt[i,j]*=sqrt[i,j];
            
        }
    }

}
int[,] matrix=new int[5,6];
FillArray(matrix);
PrintArray(matrix);
System.Console.WriteLine();
Sqrt(matrix);
PrintArray(matrix);
