
//Armstrong number : sum of the cubes of each digit
//153= 1*1*1 + 5*5*5 + 3*3*3
//split the number, mulitiplication of the digit by itself
//by count number of times

Console.Write("Enter the number :  ");
int number=int.Parse(Console.ReadLine()),r=0,sum=0,temp=number;
while (number > 0)
{
    r = number % 10;
    sum += (r * r * r);
    number /= 10;
}
if (sum == temp)
{
    Console.WriteLine($"{temp} is an Armstrong number");
}
else
{
    Console.WriteLine($"{temp} is not an Armstrong number");
}
