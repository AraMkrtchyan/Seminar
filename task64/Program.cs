/*Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
промежутке от N до 1. Выполнить с помощью рекурсии.*/  
void DigitDiapas (int max, int start = 1)
{
if(max<start)
{
return;
}
else
{
System.Console.Write(max + " ");
DigitDiapas(max-1, start);
}
}

DigitDiapas(8);