// Задача 27. - HARD необязательная Напишите программу, которая принимает на вход целое 
// или дробное число и выдаёт количество цифр в числе.
// 452 -> 3
// 82 -> 2
// 9,012 ->4

Console.WriteLine("Введите число ");
decimal n = Convert.ToDecimal(Console.ReadLine());
int schet = MetConutCel(n);
Console.WriteLine($"количество цифр в числе = {schet}");

int MetConutCel(decimal n)
{
    int count = 0;
    decimal n1 = n;
    int finalCount = 0;
    if (n1>1)
    {
        while (n1 > 1)
        {
            n1=n1/10;
            count++;
        }
    // Console.WriteLine("count целых = " +count);
    decimal nDrob = n%1;
    int countDrob =0;
        // Console.WriteLine("nDrob = "+nDrob );
        while (nDrob!=0)
        {
            countDrob++;
            nDrob=nDrob*10;
            nDrob = nDrob%1;
            // Console.WriteLine("nDrob = "+ nDrob);
            // Console.WriteLine("countDrob = "+ countDrob);
        }
        // Console.WriteLine("countDrob final = "+ countDrob);
        finalCount = count + countDrob;
    }
    
return finalCount;
}