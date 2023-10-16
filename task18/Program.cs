/*18. Напишите программу, которая по заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y).*/

System.Console.Write("Введите номер четверти: " );
int num= int.Parse(Console.ReadLine());
if (num ==1)
{
    System.Console.WriteLine("X больше 0 и Y больше 0");
}
if (num ==2)
{
    System.Console.WriteLine("X меньше  0 и Y больше 0");
}
if (num ==3)
{
    System.Console.WriteLine("X больше 0 и Y меньше 0");
}
if (num ==4)
{
    System.Console.WriteLine("X меньше 0 и Y меньше 0");
}
if (num<1 || num>4)
{
    System.Console.WriteLine("Токой четверти не сушесвует");
}