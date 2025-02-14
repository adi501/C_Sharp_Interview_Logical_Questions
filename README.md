**Find second largest number in array in c# ?**
```
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
```
![image](https://github.com/user-attachments/assets/70d72cab-d606-4c3e-9e92-1b687a11a1af)
-------------------------------------------------------------------------------------------------------------------------------
**Find missing number in array in c# ?**
```
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
```
![image](https://github.com/user-attachments/assets/96af222b-4f10-4d4d-8678-520e02a76c68)


**Factorial program**
 ```

int i = 5;
int result=1; //(5*4*3*2*1)
for (int j = 1; j <=5; j++)
{
    result *= j;
}
Console.WriteLine("Factorial of " + i + " is :" + result);
Console.ReadLine();

```
![image](https://github.com/user-attachments/assets/45d31d85-8d23-47e6-b749-8a21fb44f809)

**Fibonacci Series Example**
```
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

```
![image](https://github.com/user-attachments/assets/fa488c7c-4e4d-456e-8eb8-0c1c88af71ec)

**Prime Number Example**
```
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

```
![image](https://github.com/user-attachments/assets/e9a31400-82c6-4c51-976f-01ba438509ee)

**Biggest Number in Array?**
```
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
```
![image](https://github.com/user-attachments/assets/2817053a-54d1-485e-98f0-700bc27c55ca)

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

**Reverse Integer in c#**
```
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
```
**Fibonacci Series in c#**
```
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

```




