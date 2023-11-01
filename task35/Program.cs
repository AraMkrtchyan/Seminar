/*Напишите программу, которая подсчитывает количество четных элементов в
 массиве целых положительных трехзначных чисел и выводит результат на экран.*/ 



void Array(int[] numbers)
{
    int length = numbers.Length;
    int index = 0;
    while (index < length)
    {
        numbers[index] = new Random().Next(100,1000);
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
        if (col[i] % 2==0)
        {
            count+=1;
        }
    }
    System.Console.WriteLine($"количество четних элементов:{count}");
}

int[] masiv= new int[7];
Array(masiv);
Printarray(masiv);
System.Console.WriteLine();
Count(masiv);