//  на вход принимает число number и выводит, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0)
{
    Console.WriteLine("Число четное");
}
// else 
//     Console.WriteLine("Число нечетное");
if (a % 2 != 0)
{
    Console.WriteLine("Число нечетное");
}
