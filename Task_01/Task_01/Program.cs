﻿// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

for (var i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

var j = 0;

while (j < 5)
{
    Console.Write(j + " ");
    j++;
}
Console.WriteLine();
Console.WriteLine(j + j);

int[] arr = {1, 2, 3, 4, 5};
int sum = 0;

foreach(int element in arr)
{
    sum += element;
}

int avg = sum / arr.Length;

Console.WriteLine(avg);

static int MaxArray(int[] arr)
{
    return arr.Max();
}

Console.WriteLine("Max: " + MaxArray(arr));