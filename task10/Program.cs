/*
10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает
вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int number = new Random().Next(100, 1000);
System.Console.WriteLine(number);
int first_number = number / 100;
int second_number = number % 100;
int third_number = number % 10;
int sum = (second_number - third_number)/10;
System.Console.WriteLine(sum);