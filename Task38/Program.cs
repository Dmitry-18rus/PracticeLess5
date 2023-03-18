// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите величину массива ");
int N = Convert.ToInt32(Console.ReadLine());

int [] array = new int [N];
MetArray(array);
MetPrint(array);
MaxArray(array);
MinArray(array);
int b = MinArray(array); 
int a = MaxArray(array);
Console.WriteLine ($"min = {b}");
Console.WriteLine ($"max = {a}");
RazzMinMax(a,b);


void MetArray(int [] array)
{
    for (int i = 0; i<array.Length; i++)
        array[i] = new Random().Next(-99,100);
}

void MetPrint ( int [] array)
{
    Console.Write("[");
    foreach (int el  in array)
        Console.Write($"{el} ");
    Console.WriteLine("]");
}

int MaxArray(int [] array)
{
int max = 0;
    for (int i = 0; i<array.Length; i++)
    {
        if (array[i]>max)
            max = array[i];
    }
return max;
}

int MinArray(int [] array)
{
    int min = 0;
    for (int i = 0; i<array.Length; i++)
    {
        if (array[i]<min)
            min = array[i];
    }
return min;
}

int RazzMinMax (int a, int b )
{
    int result = a - b;
    Console.WriteLine($"result= {result}");
return result;
}



