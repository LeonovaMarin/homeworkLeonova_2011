// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число");
var Num1 = Convert.ToInt32(Console.ReadLine());
var palindrom1 = Num1 % 10;
Console.WriteLine(palindrom1);
var palindrom2 = (Num1 % 100) / 10;
Console.WriteLine(palindrom2);
var palindrom4 = (Num1 % 10000) / 1000;
Console.WriteLine(palindrom4);
var palindrom5 = (Num1 % 100000) / 10000;
Console.WriteLine(palindrom5);

if (palindrom1 == palindrom5 || palindrom2 == palindrom4)
    {
    Console.WriteLine("Это палиндром");
    }
else    
    Console.WriteLine("Число не палиндром");
    
