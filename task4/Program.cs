// на вход принимает число (number), а на выходе выводит все чётные числа от 1 до number (включительно), 
// после каждого числа должен быть знак пробела.
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

for (int i = 2; a >= i; i+=2)
{
    Console.Write(i + " ");
}


// while (i <= a)
// {
//     Console.Write(i + " ");
//     i = i + 2;
// }