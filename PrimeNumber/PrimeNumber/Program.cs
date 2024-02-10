
//For an even integer 'n', second highest factor = n/2
//for 6, factors are 1,2,3,6, here 3 is second highest factor which is half of 6 = (n/2)

//For an odd integer 'n', second highest factor < n/2
//for 9, factors are 1,3,9. Second highest factor is 3 which is less than 9/2 

//For prime number, we need to check for the numbers upto n/2 
//For 7, factors are 1,7. 7/2 = 3.5, because after 3.5, the next factor is 7

Console.Write("Enter a number: ");
int number=int.Parse(Console.ReadLine()),i=0,m=number/2;

for(i=2;i<=m;i++)
{
    if(number % i == 0)
    {
        Console.WriteLine($"{number} is not a prime number");
        break;
    }
    else
    {
        Console.WriteLine($"{number} is a prime number");
        break;
    }
}