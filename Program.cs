// 1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateRandomArray(int size)
{

    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
       array[i] = new Random().Next(100, 1000);   
    }
    
    return array;
}

void ShowArray(int[] array)

{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
        {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}

void AmountEven(int [] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)

    {
        if (array[i] % 2 == 0)
        {
            result = result + 1;
        }
    }
    Console.Write(" -> " + result);
}

Console.WriteLine("Input amount of elements of the massive: ");
int amount = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArray(amount);
ShowArray(myArray);
AmountEven(myArray);

// 2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateRandomArray(int size, int min, int max)
{

    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
       array[i] = new Random().Next(min, max +1);   
    }
    
    return array;
}

void ShowArray(int[] array)

{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}

void AmountOdd (int [] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i += 2)

    {
        result = result + array[i];
    }
    Console.Write(" -> " + result);
}

Console.WriteLine("Input amount of elements of the massive: ");
int amount = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input minimal value of the massive: ");
int minimum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input maximal value of the massive: ");
int maximum = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArray(amount, minimum, maximum);

ShowArray(myArray);
AmountOdd(myArray);

// 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] CreateRandomArray(int size, int min, int max)
{

    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
       array[i] = new Random().Next(min, max +1);   
    }
    
    return array;
}

void ShowArray(int[] array)

{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}

void DiffMaxMin (int [] array)
{
    int max1 = array[0];
    int min1 = array[0];
        for (int i = 1; i < array.Length - 1; i ++)

    {
        if (array[i] > max1)
        {
            max1 = array[i];
        }   
        else
        {
            if (min1 > array[i])
            {
                min1 = array [i];
            }
        }    
    }
    int result = max1 - min1;
    Console.Write(" -> " + result);
}

Console.WriteLine("Input amount of elements of the massive: ");
int amount = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input minimal value of the massive: ");
int minimum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input maximal value of the massive: ");
int maximum = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArray(amount, minimum, maximum);

ShowArray(myArray);
DiffMaxMin(myArray);
