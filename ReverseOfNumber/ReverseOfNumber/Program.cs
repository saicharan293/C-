
//Reverse of number: 123,=> 321
//split the number,join it..almost similar to the palindrom except checking condition

Console.Write("Enter the value : ");
int number = int.Parse(Console.ReadLine()),sum=0,r=0,temp=number;

while (number > 0)
{
    r = number % 10;
    sum =(sum * 10) + r;
    number /= 10;
}
Console.Write($"Reverse of {temp} is {sum} ");