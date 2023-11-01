/*
33. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
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

bool Search(int[]arra,int chislo)
{
    foreach (var element in arra)
    {
        if (element==chislo) return true;
    }
    return false;
    
}   


int[] spisok = new int[10];
Array(spisok);
Printarray(spisok);
Search(spisok,5);
