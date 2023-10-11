/*
12.Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому.
Если второе число некратно первому, то программа выводит остаток от деления.
34, 5 -> некратно, остаток 4
16, 4 -> кратно
*/

System.Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите Второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2 * num2)
{
    Console.WriteLine("Кратно");
}
else
{
    int result = num1 % num2;
    Console.WriteLine($"Некратно,остаток {result}:");
}
