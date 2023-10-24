/*
28. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/

int Num(int sum)
{
    int a=1;
    for (int i = 1; i <=sum; i++)
    {
        a=a*i;
    }
    return a;
}
System.Console.WriteLine("enter number");
int sum = int.Parse(Console.ReadLine());
int number=Num(sum);
System.Console.WriteLine(number);