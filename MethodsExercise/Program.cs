namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Story();

            int addition = Add(3, 4);
            Console.WriteLine(addition);

            int subtraction = Subtract(7, 5);
            Console.WriteLine(subtraction);

            int multiplication = Multiply(6, 2);
            Console.WriteLine(multiplication);

            int division = Divide(15, 3);
            Console.WriteLine(division);

            int calculation = Total(2, 4, 6, 8, 10);
            Console.WriteLine(calculation);
        }
        public static void Story()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"\n Hi {name}, nice to meet you!");
            
            Console.WriteLine("What is your favorite dinner meal?");
            string dinnerMeal = Console.ReadLine();
            Console.WriteLine($"\n That sounds really good! {dinnerMeal} is something I'll have to try cooking soon.");
            
            Console.WriteLine("What is your favorite type of pet?");
            string pet = Console.ReadLine();
            Console.WriteLine($"\n Nice, {pet} are fun animals.");
            
            Console.Write("Last questions, who is your favorite musician or band you listen to?");
            string music = Console.ReadLine();
            Console.WriteLine($"\n {music} has some great songs! When I was younger, my favorite band was Metallica or AC/DC." +
                              $" Now I mostly listen to country music on the radio or podcasts.");
        }

        public static int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public static int Subtract(int number1, int number2)
        {
            return number1 - number2;
        }

        public static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        public static int Divide(int number1, int number2)
        {
            return number1 / number2;
        }

        public static int Total(params int[] numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number; 
            }

            return sum;
        }

    }
    
}
