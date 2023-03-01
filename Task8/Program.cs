// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write ("Введите число");
string answer = Console.ReadLine ();
int number = Convert.ToInt32 (answer);
int current = 1;
while (current <= number)
if (current % 2 == 0)
{
Console.Write (current + " ");
current = current + 1;
}
else
{
    current = current + 1;
}
