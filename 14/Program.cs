﻿// Задача 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//14 -> нет 
//46 -> нет 
//161 -> да

int number = Convert.ToInt32(Console.ReadLine());   
// && - "И"
// or - "||" 
if (number % 7 == 0 && number % 23 == 0) Console.WriteLine("Кратно 7 и 23");
else Console.WriteLine("Не кратно 7 и 23");

