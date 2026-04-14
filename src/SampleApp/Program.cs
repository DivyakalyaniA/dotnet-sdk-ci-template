// Simple .NET Console Application
// This is a sample app used to test the generic CI pipeline template

namespace SampleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello from SampleApp!");
            Console.WriteLine("CI Pipeline is working!");
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static string Greet(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("Name cannot be empty");
            return $"Hello, {name}!";
        }
    }
}
