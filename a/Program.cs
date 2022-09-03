// Задача 11.Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 456 -> 46 782 -> 72 918 -> 98

int number = new Random().Next(100,1000);
Console.WriteLine("Рандомное число: " + number);

int firstDigit = number / 100; //firstDigit-первая цифра числа: 78-7
int secondDigit = number % 10; //secondDigit-вторая цифра числа:78-8
int digit = firstDigit * 10 + secondDigit;
Console.WriteLine(digit);
