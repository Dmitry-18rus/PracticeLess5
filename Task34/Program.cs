// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите величину массива ");
int N = Convert.ToInt32(Console.ReadLine());

int [] array = new int [N];
MetArray(array);
MetPrint(array);

void MetArray ( int [] array )
{
    for (int i = 0; i<array.Length; i++)
        array[i] = new Random().Next(100,1000);
}

void MetPrint ( int [] array)
{
    Console.Write("[");
    foreach (int el  in array)
        Console.Write($"{el} ");
    // Console.WriteLine();
    Console.Write("]");
}

int MetChet (int [] array)
{
    int count = 0;
    for (int i = 0; i<array.Length; i++)
        if (array[i]%2 == 0)
            count++;
return count;
}

Console.Write ($"-> {MetChet(array)}");