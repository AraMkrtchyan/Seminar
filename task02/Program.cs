/*Напишите программу, которая на вход принимает два числа и выводит,
 какое число большее, а какое меньшее.
 a = 5; b = 7 -> Первое число 5 меньше чем второе число 7

a = 2; b = 2 -> Введенные числа равны 2

a = -3; b = -9 -> Первое число -3 больше чем второе число -9

 */

System.Console.WriteLine("Enter first number");
int num1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Enter second number");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    System.Console.WriteLine($"First number {num1} more than second number {num2}");
}
if (num1 < num2)
{
    System.Console.WriteLine($"First number {num1} less than second number {num2}");
}
if (num1 == num2)
{
    System.Console.WriteLine($"First numbers equals {num1}");
}
