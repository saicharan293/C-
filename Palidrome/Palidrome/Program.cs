Console.Write("Enter the number: ");
int number = int.Parse(Console.ReadLine()),r,sum = 0;
Console.WriteLine(number);
int temp = number;
while (number > 0)
{
    r =number % 10;
    sum = (sum * 10) + r;
    number /= 10;
}

if (sum == temp)
{
    Console.WriteLine($"Given number {temp} is palindrome");
}
else
{
    Console.WriteLine($"Given number {temp} is not palindrome");
}
