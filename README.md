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




