**Find first non-repeating element in a given Array**
```
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
```
![image](https://github.com/user-attachments/assets/cbfe5cce-5697-4a82-b5fa-d1ed74e67c47)


![image](https://github.com/user-attachments/assets/771142a6-9d32-472a-934f-2c897459a014)
