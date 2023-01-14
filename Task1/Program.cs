//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число
//чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет
Console.WriteLine("Введите число N: ");
int numberN = int.Parse(Console.ReadLine());
uint numberN2 = numberN%2 == 0;
Console.WriteLine(numberN2);

