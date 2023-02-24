/*
Задайте массив из 12 элементов,
 //заполненный случайными числами из промежутка [-9, 9].
  //Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

*/

Console.Clear();

int[] CreateArray(int size)
{
    return new int[size];
}

void RandomArrray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9,9);
    }
}

int PositivReturn(int[] arr)
{
    int positivSum = 0;
    
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0)
        {
            positivSum += arr[i];
        }
    }
   
    return positivSum;
}

int NegativReturn(int[] arr)
{
    int negativSum = 0;
    
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < 0)
        {
            negativSum += arr[i];
        }
    }
   
    return negativSum;
}

void PrintArray(int[] arr)
{
    for(int i = 0; i< arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

void PrintResult(int pos, int neg)
{
    Console.WriteLine($"Сумма положительных чисел {pos}, Сумма отрицательных чисел {neg}");
}



int[] arr = CreateArray(20);
RandomArrray(arr);

int positiveSum = PositivReturn(arr);
int negativeSum = NegativReturn(arr);

PrintArray(arr);
Console.WriteLine();
PrintResult(positiveSum, negativeSum);