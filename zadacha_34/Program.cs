//Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет 
//количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


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


int EvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]%2==0) count++;
    }
    return count;
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

int[] array = CreateArrayRndInt(6,0,1000);
PrintArray(array);
int res = EvenNumbers(array);
Console.Write($" -> {res}");