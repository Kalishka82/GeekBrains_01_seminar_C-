Console.WriteLine("Введите первое число: ");
String a = Console.ReadLine();
int number1= int.Parse(a);
Console.WriteLine("Введите второе число: ");
String b = Console.ReadLine();
int number2 = int.Parse(b);
if (number1 == number2 * number2)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else 
    if (number2 == number1 * number1)
    {
        Console.WriteLine("Второе число является квадратом первого");
    }
    else
        Console.WriteLine("Числа НЕ являются квадратами друг друга");
