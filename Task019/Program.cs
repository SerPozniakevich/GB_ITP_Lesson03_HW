// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
string text = Console.ReadLine();
int len = text.Length;
if (len != 5) 
{
    Console.Write("Введено не пятизначное число");
}
else if (text[0] == text[4] | text[1] == text[3])
{
    
     Console.WriteLine("Число является палиндромом.");

} 
else
{
    Console.WriteLine("Число не является палиндромом.");
}
