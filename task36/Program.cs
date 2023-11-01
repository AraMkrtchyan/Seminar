/*
Напишите программу, которая находит сумму элементов 
с нечетными индексами в одномерном массиве целых чисел и выводит результат на экран.
*/

void Array(int[] numbers)
{
    int length = numbers.Length;
    int index = 0;
    while (index < length)
    {
        numbers[index] = new Random().Next(0,10);
        index++;
    }

}
void Printarray(int[] col)
{
    int count = col.Length;
    int ind = 0;
    while (ind < count)
    {
        System.Console.Write(col[ind] + ",");
        ind++;
    }
}
void Count(int[]col)
{
    int count=0;
    for (int i = 0; i < col.Length; i++)
    {
        if (i % 2==1)
        {
            count=count+col[i];
        }
    }
    System.Console.WriteLine($"сумма равно:{count}");
}

int[] masiv= new int[4];
Array(masiv);
Printarray(masiv);
System.Console.WriteLine();
Count(masiv);