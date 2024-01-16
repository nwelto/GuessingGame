// See https://aka.ms/new-console-template for more information




int secretNumber = 42;

Console.WriteLine("Welcome to the Guessing Game!");
Console.WriteLine("You have four chances to guess the number.");

for (int attempts = 0; attempts < 4; attempts++)
{
    
    Console.Write($"Your guess ({attempts + 1})> ");

    
    int userGuess = int.Parse(Console.ReadLine());

    
    if (userGuess == secretNumber)
    {
        Console.WriteLine("Congratulations! You guessed the correct number.");
        break; 
    }
    else
    {
        Console.WriteLine("Sorry, that's not correct.");
    }
}

Console.WriteLine("Game over.");


