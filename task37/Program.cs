/*37. Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21*/


void Array(int[] numbers)
{
    int length = numbers.Length;
    int index = 0;
    while (index < length)
    {
        numbers[index] = new Random().Next(1,10);
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
int[] Number(int[]count)
{
    int[] numb= new int[count.Length-count.Length/2];
    int temp=0;
    for (int i = 0; i < count.Length-count.Length/2; i++)
    {
        temp=count[i]*count[count.Length-1-i];
        if(i==count.Length-1-i)
        {
            numb[i]=count[i];
            continue;
        }    
        numb[i]=temp;
    } 
    return numb;
}
int[] masiv= new int[8];
Array(masiv);
Printarray(masiv);
System.Console.WriteLine();
int [] masiv2=Number(masiv);
Printarray(masiv2);