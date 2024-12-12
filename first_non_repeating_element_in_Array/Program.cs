
Console.WriteLine(findNonRepeating([1, 2, 1, 3, 4, 3, 4]));
Console.ReadLine();
 int findNonRepeating(int[] input)
{
    for(int i = 0;i<input.Length;i++)
    {
        int j;
        for ( j= 0; j < input.Length; j++)
        {
            if (i!=j && input[i] == input[j])
            {
                break;
            }
        }
        if (j == input.Length)
            return input[i];
    }
    return -1;
}