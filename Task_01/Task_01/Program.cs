// See https://aka.ms/new-console-template for more information

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

static int AvgArray(int[] arr)
{
    int sum = 0;
    foreach(int element in arr)
    {
        sum += element;
    }
    return sum / arr.Length;
}


Console.WriteLine(AvgArray(arr));

static int MaxArray(int[] arr)
{
    return arr.Max();
}

Console.WriteLine("Max: " + MaxArray(arr));