
//Factorial=
Console.Write("Enter any number: ");
int number=int.Parse(Console.ReadLine()),factorial=1;

for(int i = number; i > 0; i--)
{
    if (i == 0)
    {
        factorial = 1;
    }
    else
    {
        factorial *= i;
    }
}
Console.WriteLine($"Factorial of {number} is {factorial}");



