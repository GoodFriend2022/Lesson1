// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.Write("Веедите первое число > ");
int numberA = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Веедите второе число > ");
int numberB = Convert.ToInt32(Console.ReadLine());

int max = numberA;

if (numberA > numberB)
{
    System.Console.WriteLine($"Из двух чисел, которые вы ввели {numberA} - большее число, {numberB} - меньшее число");
}
if (numberA == numberB)
{
    System.Console.WriteLine("Вы ввели одинаковые числа, среди которых нет ни большего ни меньшего");
}
if (numberA < numberB)
{
    System.Console.WriteLine($"Из двух чисел, которые вы ввели {numberB} - большее число, {numberA} - меньшее число");
}