/*
Задача 42: Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/
int value=123; 
Console.WriteLine(Dec(value));
int Dec(int num)
{
    int result =0;
    int temp= 1;
    while(num>0)
    {
        result+=num%2 * temp;          //ЭТО РАБОТАЕТ С ИНТОМ НО НЕ МОЖЕТ ВЗЯТЬ БОЛЬШИЕ ЧИСЛА
        num=num/2;
        temp*=10;
    }
    
    return result;
}




void Binary(int numb)
{
    string result="";
    int bin=0;
    for (int i = numb; i >0; i/=2)   //ЭТО СО СТРИНГОМ И ХОРОШ С БОЛЬШИМИ ЧИСЛАМИ
    {
        bin=i%2;
        result=bin+result;

    }
    System.Console.WriteLine(result);
}
Binary(12345);