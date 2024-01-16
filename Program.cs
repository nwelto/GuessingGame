// See https://aka.ms/new-console-template for more information


Random random = new Random();
int secretNumber = random.Next(1, 101); 

Console.WriteLine("Welcome to the Guessing Game!");
Console.WriteLine("Choose a difficulty level (Easy, Medium, Hard):");

string difficulty = Console.ReadLine().ToLower();
int maxGuesses;

switch (difficulty)
{
    case "easy":
        maxGuesses = 8;
        break;
    case "medium":
        maxGuesses = 6;
        break;
    case "hard":
        maxGuesses = 4;
        break;
    default:
        Console.WriteLine("Invalid difficulty. Defaulting to Hard.");
        maxGuesses = 4;
        break;
}

Console.WriteLine($"You have chosen {difficulty.ToUpper()} difficulty. You get {maxGuesses} guesses.");

for (int attempts = 0; attempts < maxGuesses; attempts++)
{
    int guessesLeft = maxGuesses - attempts;
    Console.Write($"Your guess ({guessesLeft} guesses left)> ");

    int userGuess;
    if (!int.TryParse(Console.ReadLine(), out userGuess))
    {
        Console.WriteLine("Please enter a valid number.");
        continue;
    }

    if (userGuess == secretNumber)
    {
        Console.WriteLine("Congratulations! You guessed the correct number.");
        break;
    }
    else if (userGuess > secretNumber)
    {
        Console.WriteLine("Sorry, that's too high.");
    }
    else
    {
        Console.WriteLine("Sorry, that's too low.");
    }
}

Console.WriteLine("Game over. The secret number was " + secretNumber + ".");



