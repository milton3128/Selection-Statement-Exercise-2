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
                case "Math":
                    Console.WriteLine("Subject takes a lot of logic!");
                    break;
                case "Science":
                    Console.WriteLine("Subject takes a lot of research!");
                    break;
                case "History":
                    Console.WriteLine("Subject takes a lot of memory, contrast, and comparision!");
                    break;
                case "Literature":
                    Console.WriteLine("Subject takes a lot of reading and comprehension ability!");
                    break;
                case "P.E.":
                    Console.WriteLine("Subject takes a lot of physical endurance and strength!");
                    break;
                default:
                    Console.WriteLine($"WOW! I wanted to take {subject} but I never attended! You are so smart!");
                    break;
            }
        }
    }
}