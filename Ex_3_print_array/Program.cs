//Задача 29: (необязательная) Напишите программу, которая создает массив из введенных через запятую цифр и выводит этот массив на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
Console.WriteLine("Введите числа через запятую: ");
string numbers = Console.ReadLine();
int[] array = numbers.Split(',').Select(int.Parse).ToArray();
Console.Write(string.Join(",", array));

