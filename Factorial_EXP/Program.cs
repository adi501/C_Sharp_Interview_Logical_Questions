
int i = 5;
int result=1; //(5*4*3*2*1)
for (int j = 1; j <=5; j++)
{
    result *= j;
}
Console.WriteLine("Factorial of " + i + " is :" + result);
Console.ReadLine();
