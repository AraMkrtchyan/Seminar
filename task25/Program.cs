/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в
натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
System.Console.WriteLine(Pow(3,5));
int Pow(int A,int B)
{
    int num=A;
    while (B>1)
    {
        A*=num;
        B--;
    }
    return A;
}
//System.Console.WriteLine(Pow);