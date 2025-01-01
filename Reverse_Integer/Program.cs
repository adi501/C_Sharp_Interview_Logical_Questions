// input: 12345 // output: 54321
int input = 12345;
int output = 0;
while (input != 0)
{
    int remainder = input % 10;
    output = output * 10 + remainder;
    input = input / 10;
}
Console.WriteLine(output);  //54321
Console.ReadLine();