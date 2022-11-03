namespace MethodsExercise
{
    public class Program
    {
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }
        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 + num3;
        }
        static void Main(string[] args)
        {

            var amountOfCars = Sum(2, 6);
            var blah = Multiply(60, 2, 4);
           
            
            //------------exercise 1 -------------

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

            //------------exercise 2--------------

        }
    }
}
