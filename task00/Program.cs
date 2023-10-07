/*0.
Напишите программу, которая на вход принимает число и выдает его квадрат
(число умножить на само себя)
*/

System.Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int result= number * number;
System.Console.Write(result);