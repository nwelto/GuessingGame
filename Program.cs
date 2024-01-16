// See https://aka.ms/new-console-template for more information


int secretNumber = 42;


Console.WriteLine("Welcome to the Guessing Game!");
Console.Write("Guess the secret number: ");


int userGuess = int.Parse(Console.ReadLine());


if (userGuess == secretNumber)
{
    Console.WriteLine("Congratulations! You guessed the correct number.");
}
else
{
    Console.WriteLine("Sorry, that's not correct. Better luck next time!");
}

