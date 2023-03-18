// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.WriteLine("Введите величину массива ");
int N = Convert.ToInt32(Console.ReadLine());

int [] array = new int [N];
MetArray(array);
MetPrint(array);
Console.WriteLine($"сумма элементов, стоящих на нечётных позициях = {MetCheck(array)}");


void MetArray(int [] array)
{
    for (int i = 0; i<array.Length; i++)
    {
        array[i] = new Random().Next(-99,100);
    }
}

int MetCheck (int [] array)
{
    int result = 0;
    for (int i = 0; i<array.Length; i++)
    {
        if (i%2 != 0 && i!=0)
            result = result + array[i];
    }
return result;
}

void MetPrint ( int [] array)
{
    Console.Write("[");
    foreach (int el  in array)
        Console.Write($"{el} ");
    // Console.WriteLine();
    Console.WriteLine("]");
}
