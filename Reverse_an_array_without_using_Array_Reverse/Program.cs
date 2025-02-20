int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
for (int i = 0; i < arr.Length / 2; i++)
{
    //Methods 1
    //int tmp = arr[i];
    //arr[i] = arr[arr.Length - i - 1];
    //arr[arr.Length - i - 1] = tmp;

    //Methods 2
    //Note : assume a=arr[i] and b=arr[arr.Length - i - 1] , then a=a+b, b=a-b, a=a-b
    arr[i] = arr[i] + arr[arr.Length - i - 1]; //a=a+b
    arr[arr.Length - i - 1] = arr[i] - arr[arr.Length - i - 1]; //b=a-b
    arr[i] = arr[i] - arr[arr.Length - i - 1]; //a=a-b
}
Console.WriteLine(string.Join(",", arr));