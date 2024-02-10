//Fibonacci series
Console.Write("Enter the max value: ");
int max = int.Parse(Console.ReadLine()),num1=0,num2=1,num3,count=0;

Console.WriteLine(num1);
Console.WriteLine(num2);
Console.WriteLine("---------");
for(int i = 2;i < max; i++)
{
    count++;
    num3 = num1 + num2;
    num1 = num2;
    num2 = num3;
    
    Console.WriteLine(num3);
}

Console.WriteLine("count is " + count);
