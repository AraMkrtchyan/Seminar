/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

void Printarray(int[] col)
{
    int count = col.Length;
    int ind = 0;
    while (ind < count)
    {
        System.Console.Write(col[ind] + " ");
        ind++;
    }
}
void Morezero(int[]arr)
{
    int count=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>0)
        {
            count++;
        }
        else
        continue;
           
    }
    System.Console.WriteLine(count);
}
int[] list= {0,1,-2,5,-4,0};
Printarray(list);
System.Console.WriteLine();
Morezero(list);
