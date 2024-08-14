namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
