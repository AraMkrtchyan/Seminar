/*
Задайте масив из 123 чисел и выявите количество чисел от 10 до 99
*/
void Array(int[] numbers)
{
    int length = numbers.Length;
    int index = 0;
    while (index < length)
    {
        numbers[index] = new Random().Next(1,200);
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
        if (col[i]>9 && col[i]<100)
        {
            count+=1;
        }
    }
    System.Console.WriteLine(count);
}

int[] masiv= new int[123];
Array(masiv);
Printarray(masiv);
System.Console.WriteLine();
Count(masiv);