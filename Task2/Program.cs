Console.Write ("Введите первое число");
string answer1 = Console.ReadLine ();
int number1 = Convert.ToInt32 (answer1);
Console.Write ("Введите второе число");
string answer2 = Console.ReadLine ();
int number2 = Convert.ToInt32 (answer2);
if (number1 > number2)
{
    Console.WriteLine ("Большее число" + " " + number1);
    Console.WriteLine ("Меньшее число" + " " + number2);
}
else
{
    Console.WriteLine ("Большее число" + " " + number2);
    Console.WriteLine ("Меньшее число" + " " + number1);
}