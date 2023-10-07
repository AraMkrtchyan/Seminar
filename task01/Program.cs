/*
Напишите программу, которая на входе принимает два числа и проверяет является ли первое число квадратом 
второга
*/

System.Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите Второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2 * num2 || num2 == num1 * num1)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}