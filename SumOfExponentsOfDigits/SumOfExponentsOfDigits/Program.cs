

//sum of exponents of digits
//assign the number to temp variable,
//split the number and count the number of digits
//number will be 0, assign temp value to number again to return back its original value


Console.Write("Enter a value: ");
int number = int.Parse(Console.ReadLine()),
    result,r,count=0,sum=0,temp=number;

//123
while (number > 0)
{
    number /= 10;
    count++;
}

number = temp;
//count=3
while(number > 0)
{

    r = number % 10;
    result = 1;
    if (r > 0)
    {
        for (int i = 0; i < count; i++)
        {
            result *= r;
        }
    }
    sum += result;
    number /= 10;
}

Console.WriteLine("Exponent value of " + temp + " is " + sum);