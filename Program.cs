namespace T5_if_statments_question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int secretNunber = 7;
            int guessNumber;
            Console.WriteLine("Hello, user, this is the worst guessing game ever. You will have one chance to pick a number I have chosen between one and ten.");
            Console.WriteLine("What number will you choose?");
            guessNumber = Convert.ToInt32(Console.ReadLine());

            if (guessNumber == secretNunber)
            {
                Console.WriteLine("Correct! You guessed the correct number great job");

            }
            else
            {
                Console.WriteLine("Incorrect, that is not the number I chose");
            }

        }
    }
}
