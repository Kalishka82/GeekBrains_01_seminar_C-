﻿Console.WriteLine("Введите трехзначное число: ");
string threeDigitNumber = Console.ReadLine();
Console.WriteLine(threeDigitNumber[2]);

// Математическое решение
int number = int.Parse(threeDigitNumber);
Console.WriteLine(number % 10);