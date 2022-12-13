адача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.(Math.Pow использовать нельзя!!!)

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
// int NumberValue(int number_a, int number_b)
// {
//     int res = 1;


//     for (int i = 1; i <= number_b; i++)


//         res *= number_a;

//     return res;

// }
// Console.Write("ввведите значение A:= ");
// int number_a = Convert.ToInt32(Console.ReadLine());
// Console.Write("ввведите значение B:= ");
// int number_b = Convert.ToInt32(Console.ReadLine());
// int resualt = NumberValue(number_a, number_b);
// Console.Write($" возводит число := {number_a}   в натуральную степень := {number_b}     ответ := {resualt}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.(Массивы и строки использовать нельзя!!!)

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// Console.Write("Enter your number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int count = 0;
// int SumNumber(int num)
// {
//    int sum = 0;

//     while (num!=0){

//         sum+=num%10;
//         num/=10;
//     }



//     return sum ;
// }
// count = SumNumber(num);
// Console.WriteLine($"сумма  в нашем числе:= {count}");

// Задача 29: Напишите программу, которая задаёт массив из произвольного кол-ва элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int[] Array(int num)
{
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("\n введите элемент массива : ");
        int value = Convert.ToInt32(Console.ReadLine());
        arr[i] = value;
    }

    return arr;
}
void ShowArray(int[] arr)

{
    Console.Write('[');
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            System.Console.Write($"{arr[i]} ,");
        else 
             System.Console.Write($"{arr[i]} ");
    }
    Console.Write(']');
    Console.Write('\n');
}
Console.Write("введите количестов элементов массива : ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[size];
ShowArray(Array(size));

