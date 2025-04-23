static void printArray<T>(T[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.WriteLine(a[i] + " ");
    }
}

int[] a = {3, 4, 5, 7};
double[] b = { 4.2, 3.2, 1.2 };
string[] c = { "Tram", "Thao" };
printArray(a);
printArray(b);
printArray(c);