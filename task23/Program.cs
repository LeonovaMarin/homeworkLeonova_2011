// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 4, 9. 
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число");
var Num1 = Convert.ToInt32(Console.ReadLine());
int Num2 = 1;

while (Num2 <= Num1)
{
    Console.WriteLine(Math.Pow (Num2,3));
    Num2++;
}

//for (int i = 1; i <= Num1; i++)
//{
  //  Console.WriteLine(Math.Pow (i,3));
//}
