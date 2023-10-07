/*
3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.

3 -> Среда
5 -> Пятница
*/

System.Console.WriteLine("Введите номер от 1 до 7");
int num1 = Convert.ToInt32(Console.ReadLine());
if(num1==1)
{
    Console.WriteLine("Понедельник");
}
if(num1==2)
{
    Console.WriteLine("Вторник");
}
if(num1==3)
{
    Console.WriteLine("Среда");
}
if(num1==4)
{
    Console.WriteLine("четверг");
}
if(num1==5)
{
    Console.WriteLine("Пятница");
}
if(num1==6)
{
    Console.WriteLine("Субота");
}
if(num1==7)
{
    Console.WriteLine("Воскресение");
}
if(num1>7 || num1<1)
{
    Console.WriteLine("Вы ввели не правилное число");
}