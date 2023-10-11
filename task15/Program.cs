/*
15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

System.Console.WriteLine("Введите число от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());
if (number>=1 && number<6)
{
    System.Console.WriteLine("Нет");
}
else if (number==6 || number==7)
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Неправельный номер недели");
}