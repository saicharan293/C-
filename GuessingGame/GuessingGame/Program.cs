

Console.WriteLine("This is a guessing game");

string str="",perfectGuess="sai";
int chances_taken = 0, maximumChances = 3;
bool outOf_Guesses = false;

while (str != perfectGuess && !outOf_Guesses)
{
    if (chances_taken < maximumChances)
    {
        Console.Write("Guess the name : ");
        str = Console.ReadLine();
        Console.WriteLine("Try again");
        chances_taken++;
    }
    else
    {
        outOf_Guesses=true;
        Console.WriteLine("Restart the game");
    }
}

if (outOf_Guesses)
{
    Console.WriteLine("You lose...");
}
else
{
    Console.WriteLine("You Win !!!");
}