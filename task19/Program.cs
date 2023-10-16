/*
19.Напишите программу который принимает на вход пятизначное число number и проверяет, является ли оно палиндромом.
14212 -> False
12821 -> True
234322 -> Число не пятизначное False
*/

System.Console.Write("Введите пятизначное число: " );
int number= int.Parse(Console.ReadLine());
int number1 = number / 10000;
int number2= (number/1000)%10;
int number4=(number/10)%10;
int number5= number%10;
/*System.Console.WriteLine(number1);
System.Console.WriteLine(number2);
System.Console.WriteLine(number4);
System.Console.WriteLine(number5);*/
if (number<10000 ||number>99999)
{
    System.Console.WriteLine("Число не пятизначное");
}
if (number1==number5 && number2==number4)
{
    System.Console.WriteLine("True");
}
else
{
    System.Console.WriteLine("False");
}
