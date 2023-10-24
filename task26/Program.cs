/*
26. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

int Count(int numb)
{
    int sum = 0;
    for (int i = numb; i >0 ; i/=10)
    {
        sum+=1;
    }
    return sum;
}
System.Console.WriteLine("enter number");
int numb = int.Parse(Console.ReadLine());
int number=Count(numb);
System.Console.WriteLine(number);
