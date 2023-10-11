/*
11.Напишите программу, которая выводит случайное трехзначное число
и удоляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98

*/


int number = new Random().Next(100, 1000);
System.Console.WriteLine(number);
int first_number = number / 100;
int second_number = number % 100;
int third_number = number % 10;
int sum = first_number * 10 + third_number;
System.Console.WriteLine(sum);