// Задача HARD STAT необязательная: Задайте массив случайных целых чисел. 
// Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, 
// среднее арифметическое всех элементов. Сохранить эту инфу в отдельный массив и
//  вывести на экран с пояснениями. Найти медианное значение первоначалального массива ,
//  возможно придется кое-что для этого дополнительно выполнить.


Console.WriteLine("Введите величину массива ");
int N = Convert.ToInt32(Console.ReadLine());
int [] array = new int [N];
MetArray(array);
MetPrint(array);
int maxEl = MaxArray(array);
MetIndexMax(array,maxEl);
int minEl = MinArray(array);
MetIndexMin(array,minEl);
MidArif(array);
Medial(array);
MetInfoArray(MaxArray(array),MetIndexMax(array,maxEl),MinArray(array),MetIndexMin(array,minEl),MidArif(array),Medial(array));


void MetArray ( int [] array )
{
    for (int i = 0; i<array.Length; i++)
        array[i] = new Random().Next(-1000,1001);
}

void MetPrint ( int [] array)
{
    Console.Write("[");
    foreach (int el  in array)
        Console.Write($"{el} ");
    // Console.WriteLine();
    Console.WriteLine("]");
}

int MaxArray(int [] array)
{
int max = 0;
    for (int i = 0; i<array.Length; i++)
    {
        if (array[i]>max)
        {
            max = array[i];
            
        }
    
    }


// Console.WriteLine("max = "+ max);
return max;
}

int MetIndexMax(int [] array, int maxEl)
{
int ind1 = Array.IndexOf(array, maxEl);
// Console.WriteLine("i max = "+ind1);
return ind1;
}

int MinArray(int [] array)
{
    int min = 0;
    for (int i = 0; i<array.Length; i++)
    {
        if (array[i]<min)
        {
            min = array[i];
    // Console.WriteLine("i min = "+i);
        }
    
    }

// Console.WriteLine("min = "+ min);
return min;
}

int MetIndexMin(int [] array, int minEl)
{
int ind2 = Array.IndexOf(array, minEl);
// Console.WriteLine("i min = "+ind2);
return ind2;
}

decimal MidArif (int [] array)
{
    int result = 0;
    for (int i = 0; i<array.Length; i++)
    {
        result = result + array[i];
    }
    decimal resultMid = Convert.ToDecimal(result)/Convert.ToDecimal(array.Length);
// Console.WriteLine("среднее арифм = "+ Math.Round(resultMid,2));
return resultMid;
}

decimal Medial (int [] array)
{
    decimal med = 0;
    if (N%2 !=0)
    {
        med = array[array.Length/2];
        // Console.WriteLine("Медиальное значение = "+ med);
    }
    else
    {
        decimal medL = array[(array.Length-1)/2];
        decimal medR = array[(array.Length/2-1)+1];
        med = (medR + medL)/2;
        // Console.WriteLine("Медиальное значение = "+ med);
    }
return med;
}

void MetInfoArray(int a, int b, int c, int d, decimal e, decimal f)
{
    string[] infoArray = new string[6];
    infoArray[0] = "Максимальный элемент массива = " + MaxArray(array);
    infoArray[1] = "Индекс максимального элемента = " + MetIndexMax(array, maxEl);
    infoArray[2] = "Минимальный элемент массива = " + MinArray(array);
    infoArray[3] = "Индекс минимального элемента = " + MetIndexMin(array, minEl);
    infoArray[4] = "Среднее арифметическое всех элементов = " + MidArif(array);
    infoArray[5] = "Медиальное значение  = " + Medial(array);
    
    foreach (string el in infoArray)
        Console.WriteLine($"{el} ");
    // Console.WriteLine();
    
}