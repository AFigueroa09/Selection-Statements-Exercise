namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Exercise #1
            int favNumber = 8;
            Console.WriteLine("Guess my favorite number:");
            int userInput = int.Parse(Console.ReadLine());

            if (favNumber > userInput)
            {
                Console.WriteLine("Too low");
            }
            else if (favNumber < userInput)
            {
                Console.WriteLine("Too high");
            }
            else
            {
                Console.WriteLine("You guessed it!!!");
            }

            // Exercise #2
            Console.WriteLine("What is your favorite school subject?");
            string favoriteSubject = Console.ReadLine();
            switch (favoriteSubject) {
                case "Math":
                    Console.WriteLine("Math is cool. Very useful.");
                    break;
                case "Chemistry":
                    Console.WriteLine("Are you a mad scientist? Mixing checmicals can be fun but dangerous. Be careful.");
                    break;
                case "History":
                    Console.WriteLine("History helps us avoid repating the same mistakes of the past; usually.");
                    break;
                case "Spanish":
                    Console.WriteLine("Muy bien! Muchos americanos hablan solo Español");
                    break;
                case "Science":
                    Console.WriteLine("Science helps us understand te world around us.");
                    break;
                default:
                    Console.WriteLine("Interesting choice! What do you like about it?");
                    break;
            }
        }
    }
}
