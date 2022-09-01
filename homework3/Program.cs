/* 
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 
*/


Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int b = 1;
int count = 1;
int  cub = 0;


for (count = 1; count <= n; count++)
{
    cub = b * b * b;
    Console.Write(n + "-> " + cub + "  ");
    b++;
}
