namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            string firstName = "Fernando";
            int age = 27;
            char middleInitial = 'M';
            bool isMale = true;
            double heightinMeters = 1.81;
            decimal moneyAvailable = 1000.59m;

            Console.WriteLine(
                $"Meet {firstName} {middleInitial}. He's {age} years old and {heightinMeters} meters tall. He is worth {moneyAvailable}."
                );
        }
    }
}
