/*
Напишите программу который принимает на вход число (N) и 
 выводит таблицу кубов чисел от 1 до N (включительно) каждое на новой строке.
*/

System.Console.Write("Введите Число " );
double numb= double.Parse(Console.ReadLine());
for (double i= 1; i <= numb; i++)
{
    double num=Math.Pow(i,3);
    System.Console.WriteLine($"{i} * {i} * {i} = {num}");
}
