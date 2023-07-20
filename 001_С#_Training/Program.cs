internal class Program
{
    private static void Main(string[] args)
    {
        do
        {
            Console.WriteLine("\nEnter: rock, paper or scissors?");

            Console.WriteLine(calculateResultOfGame(getVariantAnswerOfAsk()));

        } while (getAnswerForContinuePlay());

    }

    private static string getVariantAnswerOfAsk()
    {
        var userChoise = Console.ReadLine();

        if ((userChoise != "rock") ^ (userChoise != "paper") ^ (userChoise != "scissors"))
        {
            Console.WriteLine("Incorrect answer, try again!");
            userChoise = getVariantAnswerOfAsk();
        }

        return userChoise;
    }

    private static string calculateResultOfGame(string userAnswer)
    {
        string botAnswer;
        Random rnd = new Random();
        switch (rnd.Next(1, 4))
        {
            case 1:
                botAnswer = "paper";

                Console.WriteLine("Bot chose paper.");

                if (userAnswer == botAnswer)
                {
                    return "Draw";
                }
                else if (userAnswer == "rock")
                {
                    return "Lose";
                }
                else
                {
                    return "Win";
                }

            case 2:
                botAnswer = "scissors";

                Console.WriteLine("Bot chose scissors.");

                if (userAnswer == botAnswer)
                {

                    return "Draw";
                }
                else if (userAnswer == "rock")
                {
                    return "Win";
                }
                else
                {
                    return "Lose";
                }

            case 3:
                botAnswer = "rock";

                Console.WriteLine("Bot chose rock.");

                if (userAnswer == botAnswer)
                {

                    return "Draw";
                }
                else if (userAnswer == "paper")
                {
                    return "Win";
                }
                else
                {
                    return "Lose";
                }
            default:
                return "error";
        }
    }

    private static bool getAnswerForContinuePlay()
    {
        Console.WriteLine("Do you want to play again? (y/n)");
        var userAnswer = Console.ReadLine();
        if (userAnswer == "y")
        {
            return true;
        }
        else if(userAnswer == "n")
        {
            Console.WriteLine("Thanks for game!");
            return false;
        }
        else
        {
            Console.WriteLine("Try again!");
            return getAnswerForContinuePlay();
        }
    }
}