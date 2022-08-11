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
int n=Convert.ToInt32(readText[0]);
int k=Convert.ToInt32(readText[2]);
string [] array = readText[1].Split(' ', StringSplitOptions.RemoveEmptyEntries);
string [] new_array=new string[n];
if(Math.Abs(k)>n) k=k%n;
for(int i=0; i<n; i++)
{
    if(i-k<0) new_array[i]=array[i+n-k];
    else  if(i+k>n || i-k<n) new_array[i]=array[i-k];
    else new_array[i]=array[i-n-k];
}
WriteLine($"[{String.Join(", ", array)}]");
WriteLine("--------------------");
WriteLine($"[{String.Join(", ", new_array)}]");