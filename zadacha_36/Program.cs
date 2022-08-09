//Задайте одномерный массив, заполненный случайными 
//числами. Найдите сумму элементов, стоящих на нечётных 
//позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt (int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i<arr.Length; i++)
    {
        arr[i] = rnd.Next(min,max+1);
    }
    return arr;
}

int SumElements(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum+=array[i];
    }
    return sum;
}

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i==0) Console.Write ("[");
        if(i<array.Length-1) Console.Write(array[i] + ",");
        else Console.Write(array[i] + "]");
    }
}

int[] array = CreateArrayRndInt(5,-10,11);
PrintArray(array);
int res = SumElements(array);
Console.Write($" -> {res}");