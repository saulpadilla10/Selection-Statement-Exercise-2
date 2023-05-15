namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is you favorite school subject?");

            var subject = Console.ReadLine();

            switch (subject)
            {
                case "Science":
                    Console.WriteLine("Cool story, Darwin!");
                    break;
                case "Math":
                    Console.WriteLine("Sometimes 2+2=5.");
                    break;
                default:
                    Console.WriteLine("Social bettery at 0% Good-Bye.");
                    break;
            }
        }
    }
}