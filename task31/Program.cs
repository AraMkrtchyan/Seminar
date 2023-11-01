/*
31. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
сумма отрицательных равна -20.

*/

int[] mas= {3,9,-8,1,0,-7,2,-1,8,-3,-1,6};

void Sum1(int[] text)
{
    
    int length=text.Length;
    int result=0;
    int result2=0;

    for (int i = 0; i < length; i++)
    {
        if(text[i]>0)
        {
            result=result+text[i];
        }
        if (text[i]<0)
        {
            result2=result2+text[i];
        }
    }
    
    System.Console.WriteLine(result);
    
    System.Console.WriteLine(result2);
}
Sum1(mas);
