namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Story();
        }
        public static void Story()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hi {name}, nice to meet you!");
            
            Console.WriteLine("What is your favorite dinner meal?");
            string dinnerMeal = Console.ReadLine();
            Console.WriteLine($"That sounds really good! {dinnerMeal} is something I'll have to try cooking soon.");
            
            Console.WriteLine("What is your favorite type of pet?");
            string pet = Console.ReadLine();
            Console.WriteLine($"Nice, {pet} are fun animals.");
            
            Console.Write("Last questions, who is your favorite musician or band you listen to?");
            string music = Console.ReadLine();
            Console.WriteLine($"{music} has some great songs! When I was younger, my favorite band was Metallica or AC/DC." +
                              $" Now I mostly listen to country music on the radio or podcasts.");
        }

    }
    
}
