/*
32. Напишите программу замена элементов массива: положительные элементы замените
 на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/
void Array(int[] numbers)
{
    int length = numbers.Length;
    int index = 0;
    while (index < length)
    {
        numbers[index] = new Random().Next(-9, 10);
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
int[] Revers(int[]arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i]*=-1;
    }
    return arr;
}


int[] spisok = new int[10];
Array(spisok);
Printarray(spisok);
int[] chnage=Revers(spisok);
System.Console.WriteLine();
Printarray(chnage);
