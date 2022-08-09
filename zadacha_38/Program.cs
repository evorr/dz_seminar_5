//Задайте массив вещественных чисел. Найдите разницу 
//между максимальным и минимальным элементов массива.
//[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] CreateArrayRndInt (int size,double min, double max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i<arr.Length; i++)
    {
        arr[i] = Math.Round((rnd.NextDouble()*(max-min)),1);
    }
    return arr;
}

double Difference(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i]>max) max=array[i];
        else if (array[i]<min) min=array[i];
    }
    return max-min;
}
void PrintArray (double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i==0) Console.Write ("[");
        if(i<array.Length-1) Console.Write(array[i] + ", ");
        else Console.Write(array[i] + "]");
    }
}

double[] array = CreateArrayRndInt(5,10,100);
PrintArray(array);
double res = Math.Round(Difference(array),1);
Console.Write($" -> {res}");