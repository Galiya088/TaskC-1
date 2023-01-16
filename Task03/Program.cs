/*Задача 4: Напишите программу, которая принимает на вход три числа
 и выдаёт максимальное из этих чисел. (Сравнить с каждым)
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

int max = 0;

Console.Write("Введите первое число: ");
int first = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int second = int.Parse(Console.ReadLine());

Console.Write("Введите третье число: ");
int third = int.Parse(Console.ReadLine());

    if(first > max)
{
    max = first;
}
    if(second > max)
{
    max = second;
}
    if(third > max)
{
    max = third;
}

Console.WriteLine("max = " + max);

