﻿// Задание 4.
// Вывести нечетные числа
// Описание: Напишите код, который на вход принимает число(number), а на выходе
// выводит все нечетные числа от 1 до number( включительно), после каждого числа
// должен быть знак пробела.
// Пример использовагия: На входе:
// number: 5
// На выходе:
// 1 3 5

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= number; i += 2)
Console.WriteLine(i);

