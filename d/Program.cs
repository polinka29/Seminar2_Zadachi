﻿//Задача 11.Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 456 -> 46 782 -> 72 918 -> 98

// 2. int

int number = new Random().Next(100, 1000); // [0;999]
int result = ((number/100) * 10) + number % 10;//456 -> 4, 456 % 10 -> 6

Console.WriteLine($"Исходное число: {number}, результат: {result}");
