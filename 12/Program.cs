﻿//Задача 12.Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно

int firstNumber = Convert.ToInt32(Console.ReadLine());   
int secondNumber = Convert.ToInt32(Console.ReadLine());  

if (firstNumber % secondNumber == 0) // остаток от деления = 0, числа кратные
{
    Console.WriteLine("кратно");
}
else Console.WriteLine($"Не кратно, остаток: {firstNumber % secondNumber}");

