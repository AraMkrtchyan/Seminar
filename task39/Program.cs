/*Нпишите программу коорая перевернет одномерный масив*/ 

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
void Revers(int[]array)
{
    for (int i = 0; i < array.Length/2; i++)
    {
        int temp=array[i];
        array[i]=array[array.Length-1-i];
        array[array.Length-1-i]=temp;

    }
}

int[] list=new int[10];
Array(list);
Printarray(list);
System.Console.WriteLine();
Revers(list);
Printarray(list);
