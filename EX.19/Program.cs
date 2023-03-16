// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число палиндром");
Console.WriteLine("(Пример - 12321)");
Console.WriteLine("Ваше число: ");
string number = Console.ReadLine()!;
if (number.Length == 5 && number[0] == number[4] && number[1] == number[3]) System.Console.WriteLine("Число палиндром");
else if (number.Length < 5) System.Console.WriteLine("Число не пятизначное");
else if (number.Length == 5) System.Console.WriteLine("Число пятизначное, но не палиндром");
else if (number.Length >= 6) System.Console.WriteLine("Число больше, чем пятизначное");


