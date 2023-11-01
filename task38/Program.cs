//

void Array(double[] numbers)
{
    int length = numbers.Length;
    int index = 0;
    while (index < length)
    {
        numbers[index] = new  Random().NextDouble();
        numbers[index]=numbers[index]+ new Random().Next(1,10);
        index++;
    }

}
void Printarray(double[] col)
{
    int count = col.Length;
    int ind = 0;
    while (ind < count)
    {
        System.Console.Write(Math.Round(col[ind],2) + " ");
        ind++;
    }
}
void Calldiferencemaxmin(double[]arr)
{
    double dif=0;
    double max=0;
    double min=arr[0];
    for (int i = 0; i < arr.Length; i++)
        {
            if(arr[i]>max)max=arr[i];
        }
    for (int i = 0; i < arr.Length; i++)
        {
            if(arr[i]<min)min=arr[i];
        }
    dif=max-min;
        System.Console.WriteLine(Math.Round(max,2));
        System.Console.WriteLine(Math.Round(min,2));
        System.Console.WriteLine(Math.Round(dif,2));

}


double[] masiv= new double[300];
Array(masiv);
Printarray(masiv);
System.Console.WriteLine();
Calldiferencemaxmin(masiv);

