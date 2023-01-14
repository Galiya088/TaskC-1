/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет*/

Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine());
int temp = A % 2;
bool result = temp == 0;

   if(result)
{ 
    Console.WriteLine("Число четное");
}
   else
{
    Console.WriteLine("Число нечетное");
}

