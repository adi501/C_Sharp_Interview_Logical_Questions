
int[] arr = { 1, 2, 9, 10, 4, 5 };
Array.Sort(arr);
int a = arr[0], b = arr[arr.Length - 1];
bool status=false;
for(int i = a; i <=b; i++)
{
    for(int j = 0; j < arr.Length; j++)
    {
        if (i == arr[j])
        {
            status = true;
            break;
        }
        else
        {
            status = false;
        }
    }
    if (status==false)
    {
        Console.WriteLine(i);
    }
}
Console.ReadLine();