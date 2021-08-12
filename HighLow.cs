using System;

class HighLow {
    private static void Main(String[] args)
    {
        int numToBeGuessed;
        int guessCounter = 0;
        int currentGuess;
        bool luckyGuessAchieved;
        System.Console.WriteLine("Welcome to Higher or Lower!");
        System.Console.Write("Generating number... ");
        numToBeGuessed = generateNumber();
        System.Console.WriteLine("number generated successfully!");
        System.Console.WriteLine("Remember - if you want to quit at anytime, guess 9999");
        System.Console.Write("Please guess a number between 0 and 1000 to try to find out what the number is: ");
        luckyGuessAchieved = guessCheck(numToBeGuessed, currentGuess, guessCounter);
        
    }

    private int generateNumber()
    {
        Random r = new Random();
        int randomNum = r.Next(0, 100);
        return randomNum;
    }

    private bool guessCheck(int numToBeGuessed, int currentGuess, int guessCounter)
    {
        while(currentGuess != numToBeGuessed)
        {
            currentGuess = System.Console.ReadLine();
            guessCounter++;
            if(currentGuess < 0)
            {
                System.Console.Write("You naughty possum... I said between 0 and 1000... try again: ");
            }
            else if(currentGuess > 1000)
            {
                System.Console.Write("You stinky pineapple... I said between 0 and 1000... try again: ");
            }
            else if(currentGuess > numToBeGuessed)
            {
                if(currentGuess == 9999)
                {
                    System.Console.WriteLine("Done so soon? Well, hopefully see you next time... goodbye.");
                    return false;
                }
                System.Console.Write("Slow it down, try a little lower next time... ");
            }
            else if(currentGuess < numToBeGuessed)
            {
                System.Console.Write("Hmm... not quite - try a little higher next time... ");
            }
            else
            {
                System.Console.WriteLine($"You guessed it, well done, champ! It took you {guessCounter} guesses");
                return true;
            }
        }
    }
}