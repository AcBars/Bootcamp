/*
Суперсдвиг
(Время: 1 сек. Память: 16 Мб Сложность: 20%)
Дана последовательность из N целых чисел и число K. Необходимо сдвинуть всю последовательность (сдвиг - циклический) на
|K| элементов вправо, если K – положительное и влево, если отрицательное.

Входные данные
Первая строка входного файла INPUT.TXT содержит натуральное число N, во второй строке записаны N целых чисел Ai,
а в последней – целое число K. (1 ≤ N ≤ 105, |K| ≤ 105, |Ai| ≤ 100).

Выходные данные
В выходной файл OUTPUT.TXT выведите полученную последовательность.
*/

using System;
using static System.Console;
using System.IO;

Clear();

string path = @"C:\Users\mihaylovav\Documents\soft.dev\homework\Bootcamp\task_001\INPUT.txt";


string[] readText = File.ReadAllLines(path);
foreach (string s in readText)
    {
        Console.WriteLine(s);
    }