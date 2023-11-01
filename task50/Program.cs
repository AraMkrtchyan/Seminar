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

void Sum(int[,] sum,int x,int y)
{   
    
    for (int i = 0; i < sum.GetLength(0); i++)
    {
        for (int j = 0; j < sum.GetLength(1); j++)
        {
           
           if(i>x && j>y) System.Console.WriteLine($"The number [{x},{y}] is {sum[x,y]}");
           
           
            
        
        }
        
    }
}

System.Console.WriteLine("Введите количество столбцов массива");
int n=int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите количество строк массива");
int m=int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите x");
int x=int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите y");
int y=int.Parse(Console.ReadLine());
int[,] matrix=new int[m,n];
FillArray(matrix);
PrintArray(matrix);
System.Console.WriteLine();
if (x>=n||y>=m) System.Console.WriteLine("There is no such index");
Sum(matrix,x,y);
