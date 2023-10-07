/*
5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые
 числа в промежутке от -N до N.
*/
System.Console.WriteLine("enter number");
int num = Convert.ToInt32(Console.ReadLine());

 for (int i = -num; i <= num; i++)
        {
            Console.Write(i);
            Console.Write(", ");
        }