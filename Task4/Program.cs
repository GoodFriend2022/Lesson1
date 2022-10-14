// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.Write("Введите натуральное число > ");
int value = Convert.ToInt32(Console.ReadLine());
int number = 2;

while (value < 1)
{
    System.Console.Write("Необходимо натуральное число, т.е. число, которое больше 1. Попробуйте ещё раз ввести число > ");
    value = Convert.ToInt32(Console.ReadLine());
}

if (value == 1)
{
    System.Console.WriteLine("Четные числа в интервале от 1 до введеного Вами числа отсутствуют");
}
else
{
    System.Console.Write(number);
    number = number + 2;
    while (value >= number)
    {
        System.Console.Write($", {number}");
        number = number + 2;
    }
}
