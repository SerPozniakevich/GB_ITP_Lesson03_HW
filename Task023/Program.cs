// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите положительное число: ");
int num =Int16.Parse(Console.ReadLine());

if (num < 0) Console.WriteLine($" Число {num} не является положительным");

int i = 0;

while (i < num)
{
    
    i++;

    Console.Write( Math.Pow(i, 3) + ", ");
}