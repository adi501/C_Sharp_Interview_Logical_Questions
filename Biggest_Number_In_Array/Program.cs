//biggest number in array

int[] arr= {1,2,3,9,5,6,7};
int bigNmuber = arr[0];
for (int i = 0; i < arr.Length; i++)
{
    if(arr[i] > bigNmuber)
    {
        bigNmuber = arr[i];
    }
}
Console.WriteLine("Biggest Number in given Array: " + bigNmuber);
Console.ReadLine();