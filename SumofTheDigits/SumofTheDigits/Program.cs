
//Sum Of the Digits
//split the number, add the number through loop

Console.Write("Enter the number : ");
int number = int.Parse(Console.ReadLine()), r = 0, sum = 0, temp = number;

while (number > 0)
{
    r = number % 10;
    sum += r;
    number /= 10;
}

Console.WriteLine($"For the given number {temp}, sum of the digits is {sum}");

