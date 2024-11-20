
int[] arr = {1, 2, 3,9,10, 4, 5};
Array.Sort(arr);
int a = 0, b = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (a < arr[i])
        a = arr[i];
}
for (int i = 0; i < arr.Length; i++)
{
    if (b<arr[i] && a!=arr[i])
        b=arr[i];
}
Console.WriteLine("Second Largest Number: "+b);
Console.ReadLine();