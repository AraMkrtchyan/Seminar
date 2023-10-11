/*
13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

System.Console.WriteLine("enter number");
int number = Convert.ToInt32(Console.ReadLine());
while (number>1000)
{
    number= number /10;
}
if (number<100)
{
    System.Console.Write("третьей цифры нет");
}
else
{
    number= number % 10;
    System.Console.WriteLine(number);
}

