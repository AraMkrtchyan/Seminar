/*
27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
System.Console.WriteLine(Num(82));
int Num(int numb)
{
    int result=0;
    while (numb>0)
    {
        result=result+numb%10;
        numb=numb/10;
    }
    return result;
}