
/*int Num(int a)
{
    int result= a+a;  //func veradarcnum e int popxakan u @ndunum e int popoxakan ete uzum enq urish int num@ darcnum enq doubl num
    return result;
}

int Num1()
{
    int a=5;
    int result=a+a;
    return result;
}


void Num2(int a2)
{
    int result=a2+a2;
    System.Console.WriteLine(result);
}

int usera = Num1();
System.Console.WriteLine(usera);

Num2(2);*/
/*
24. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

int Metod(int num)
{
    int sum=0;
    for (int i = 0; i <= num; i++)
    {
        sum=sum+i;
    }
    return sum;
}

System.Console.WriteLine("enter number");
int usernumber= int.Parse(Console.ReadLine());
int result=Metod(usernumber);
System.Console.WriteLine(result);