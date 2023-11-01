/*
Задача 44: Не используя рекурсию, выведите первые N чисел
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/
void Fibonachi(int num)
{
    int[] fibonachi = new int[num + 2];
    if (num == 0) System.Console.Write("1");
    else
        for (int i = 0; i < 2; i++)
        {
            fibonachi[i] = i;
            System.Console.Write(fibonachi[i] + " ");
        }
    for (int i = 2; i < num; i++)
    {
        fibonachi[i] = fibonachi[i - 2] + fibonachi[i - 1];
        System.Console.Write(fibonachi[i] + " ");
    }


}
Fibonachi(1);