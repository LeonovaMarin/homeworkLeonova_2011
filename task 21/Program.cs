// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите значение xa");
var xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение ya");
var ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение za");
var za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение xb");
var xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение yb");
var yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение zb");
var zb = Convert.ToInt32(Console.ReadLine());

var result = Math.Sqrt(Math.Pow((xa-xb),2) + Math.Pow((ya-yb),2) + Math.Pow((za-zb),2));

Console.WriteLine(result);

