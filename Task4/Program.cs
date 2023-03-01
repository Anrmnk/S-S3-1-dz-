// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write ("Введите первое число");
string answer1 = Console.ReadLine ();
int number1 = Convert.ToInt32 (answer1);
Console.Write ("Введите второе число");
string answer2 = Console.ReadLine ();
int number2 = Convert.ToInt32 (answer2);
Console.Write ("Введите третье число");
string answer3 = Console.ReadLine ();
int number3 = Convert.ToInt32 (answer3);
int max = number1;
if (number2 > max)
{
    max = number2;
}
if (number3 > max)
{
    max = number3;
}
Console.WriteLine ("Большее число" + " " + max);