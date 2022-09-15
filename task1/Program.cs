//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Программа для определения большего числа");

//ввод значений

Console.Write("Введите первое число - ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число - ");
int number2 = int.Parse(Console.ReadLine());

//сравним числа, сделаем вывод большего и меньшего числа

if (number1 < number2)
{
   Console.WriteLine($"{number2} большее число, {number1} меньшее."); 
}
else
{
    Console.WriteLine($"{number1} больше число, {number2} меньшее.");
}