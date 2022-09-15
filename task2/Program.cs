// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Программа для определения большего числа из трёх");

//ввод значений

Console.Write("Введите первое число - ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число - ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число - ");
int num3 = int.Parse(Console.ReadLine());


//сравним числа, сделаем вывод большего

if ((num2 < num1) && (num1 > num3))
{
   Console.WriteLine($"Большим числом является - {num1}");
}
if ((num2 > num1) && (num2 > num3))
{
   Console.WriteLine($"Большим числом является - {num2}");
}
if ((num3 > num1) && (num2 < num3))
{
   Console.WriteLine($"Большим числом является - {num3}");
}