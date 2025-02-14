//public static void Demo()
//{
    var task1 = StartSchool();
    var task2 = TeachClass1();
    var task3 = TeachClass2();
    Task.WaitAll(task1, task2, task3);

Console.ReadLine();
//}

 static async Task StartSchool()
{
    await Task.Run(() =>
    {
        Thread.Sleep(8000);
        Console.WriteLine("School Started");
    });
}
 static async Task TeachClass1()
{
    await Task.Run(() =>
    {
        Thread.Sleep(2000);
        Console.WriteLine("Taught class 1");
    });
}
 static async Task TeachClass2()
{
    await Task.Run(() =>
    {
        Thread.Sleep(3000);
        Console.WriteLine("Taught class 2");
    });

}