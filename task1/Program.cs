// Внутри класса Answer напишите метод CompareNumbers, 
// который на вход принимает два числа и выводит, какое число большее, а какое меньшее.
Console.WriteLine("Введите значение a:");
int firstValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b:");
int secondValue = Convert.ToInt32(Console.ReadLine());
int max = firstValue; 
if (max < secondValue)
{
    Console.WriteLine($"Наибольшее число = {secondValue}, Наименьшее число = {firstValue}");
}
if else
{
        Console.WriteLine($"Наименьшее число = {secondValue}, Наибольшее число = {firstValue}");
}

    // Console.WriteLine($"a = {firstValue}, b = {secondValue} => Нет");
