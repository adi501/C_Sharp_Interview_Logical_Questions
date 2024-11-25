//Fibonacci_Series_Example
//0,1,1,2,3,5,8,13,21,34 (upto 50)

int firstNum = 0, secondNumber = 1;
Console.WriteLine(firstNum);
Console.WriteLine(secondNumber);
int result=firstNum+secondNumber;
while(result<50)
{
    Console.WriteLine(result);
    firstNum = secondNumber;
    secondNumber = result;
    result = firstNum + secondNumber;
}
Console.ReadLine();
