
Console.Write("Enter first value : ");
int firstNumber=int.Parse(Console.ReadLine());//1
Console.Write("Enter second value : ");
int secondNumber=int.Parse(Console.ReadLine()),
    thirdNumber=0;//2
Console.WriteLine($"Before swap,  first number is {firstNumber} and second number is {secondNumber}");

thirdNumber = firstNumber;
firstNumber = secondNumber;
secondNumber = thirdNumber;

Console.WriteLine($"After swap, first number is {firstNumber}, second number is {secondNumber}");


