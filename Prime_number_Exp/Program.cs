//Prime_number_Exp
//2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47 (1 to 50)
bool isPrime = true;
int i, j;
Console.WriteLine("Prime Numbers are : ");
for (i = 2; i <= 50; i++)
{
    for (j = 2; j <= 50; j++)
    {
        if (i != j && i % j == 0)
        {
            isPrime = false;
            break;
        }
    }
    if (isPrime)
    {
        Console.Write(i+",");
    }
    isPrime = true;
}
Console.ReadLine();
