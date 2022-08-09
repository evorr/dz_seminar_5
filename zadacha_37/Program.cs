//Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний
//и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21



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

int[] GetSum(int[] array)
{
    int num=0;
    if(array.Length%2==0)
    {
        num=array.Length/2;
    }
    else
    {
        num=array.Length/2+1;
    }
    int[] sumArray = new int [num];
    for (int i = 0; i < array.Length/2; i++)
    {
        sumArray[i]=array[i]*array[array.Length-1-i];
    }
    if (array.Length%2==0) return sumArray;
    else
    {
        sumArray[sumArray.Length-1]=array[array.Length/2];
        return sumArray;
    }
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

int[] array = CreateArrayRndInt(6,0,11);
PrintArray(array);
int[] newArray = GetSum(array);
PrintArray(newArray);
