//  на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите значение a:");
int firstValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b:");
int secondValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение c:");
int thirdValue = Convert.ToInt32(Console.ReadLine());
int max = firstValue;
if (secondValue > max)
{
max = secondValue;
}
if (thirdValue > max)
{
max = thirdValue;
}
Console.WriteLine($"Максимальное число: {max}");

