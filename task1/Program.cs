// Внутри класса Answer напишите метод CompareNumbers, 
// который на вход принимает два числа и выводит, какое число большее, а какое меньшее.
Console.WriteLine("Введите значение a:");
int firstValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b:");
int secondValue = Convert.ToInt32(Console.ReadLine());
if (firstValue < secondValue)
{
    Console.WriteLine("Второче число наибольшее");
}
if (secondValue < firstValue)
{
    Console.WriteLine("Первое число наибольшее");
}
if (secondValue == firstValue)
{
    Console.WriteLine("Числа равны");
}
    // Console.WriteLine($"a = {firstValue}, b = {secondValue} => Нет");
