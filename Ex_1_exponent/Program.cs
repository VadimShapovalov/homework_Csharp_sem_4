//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
Console.WriteLine("Введите число являющееся основанием степени: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число являющееся показателем степени: ");
int b = Convert.ToInt32(Console.ReadLine());
int count = 2;
int result;
for(result = a * a; count < b; count++)
{
    result = result * a;
}
Console.WriteLine($"{a} в степени {b} равно {result}");