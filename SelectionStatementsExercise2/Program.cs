namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");

            var subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("Subject takes a lot of logic!");
                    break;
                case "science":
                    Console.WriteLine("Subject takes a lot of research!");
                    break;
                case "history":
                    Console.WriteLine("Subject takes a lot of memory, contrast, and comparision!");
                    break;
                case "literature":
                    Console.WriteLine("Subject takes a lot of reading and comprehension ability!");
                    break;
                case "p.e.":
                    Console.WriteLine("Subject takes a lot of physical endurance and strength!");
                    break;
                default:
                    Console.WriteLine($"WOW! I wanted to take {subject} but I never attended! You are so smart!");
                    break;
            }
        }
    }
}