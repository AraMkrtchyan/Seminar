/*
9. Напишите программу, которая выводит случайное число из отрезка [10, 99], и показивает 
наибольшую цифру числа.
78 -> 8
12 -> 2
85 -> 8
*/

int number = new Random().Next(10, 100);
System.Console.WriteLine(number);
int first_number = number/10;
int second_number= number%10;
if (first_number> second_number)
{
    System.Console.WriteLine(first_number);
}
else if(first_number<second_number)
{
    System.Console.WriteLine(second_number);
}
else
{
    System.Console.WriteLine($"{first_number} equals {second_number}");
}