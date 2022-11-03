namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, What is your first name? ");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hello {userName}, What is your favorite color? ");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is awesome, What is your favorite animal? ");
            var animal = Console.ReadLine();

            Console.WriteLine("Great! Now  What is your favorite band? ");
            var band = Console.ReadLine();

            Console.WriteLine($"Thanks {userName}! Here is your profile");
            Console.WriteLine("------------------------------------");

            Console.WriteLine($"Name : {userName}");
            Console.WriteLine($"Favorite color : {color}");
            Console.WriteLine($"Favorite animal : {animal}");
            Console.WriteLine($"Favorite Band : {band}");

        }
    }
}
