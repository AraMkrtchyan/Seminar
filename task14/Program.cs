/*14. Напишите программу, которая принимает на вход число и проверяет, 
кратно ли оно одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да
*/

/*System.Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
int result1 = num1 % 7;
int result2= num1 % 23; 
if ((result1 == 0) && (result2 == 0))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}*/



System.Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 % 7 == 0 && num1 % 23 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
} 