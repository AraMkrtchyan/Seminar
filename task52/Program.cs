/*

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
{   double a=0;
    double sredar=0;
    System.Console.WriteLine("среднее арифметическое столбцов");
    for (int j = 0; j < sum.GetLength(1); j++)
    {
        for (int i = 0; i < sum.GetLength(1); i++)
        {
           a=a+sum[i,j];
         
        }
      sredar=a/sum.GetLength(0);
      System.Console.Write(Math.Round(sredar,2)+"   ");
      a=0;
      sredar=0;
    }
    
}
int[,] matrix=new int[3,3];
FillArray(matrix);
PrintArray(matrix);
System.Console.WriteLine();
Sum(matrix);