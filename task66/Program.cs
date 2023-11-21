/*
 Задайте значения M и N. Напишите программу, которая найдёт сумму 
 натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int Summ(int minnum,int maxnum)
{
if (minnum>maxnum)
{
return 0;
}
else
{
return minnum+ Summ(minnum+1,maxnum);
}
}

int result = Summ(4,8);
System.Console.WriteLine(result);