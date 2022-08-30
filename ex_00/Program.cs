Console.WriteLine("Введите число: ");
string input = Console.ReadLine(); // пользовательский ввод

int number = int.Parse(input); // если ошибка, программа взрывается
// if (int.TryParse(input))
int square = number * number; // квадрат

Console.WriteLine($"Число в квадрате равно {square}");