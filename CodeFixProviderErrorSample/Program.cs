namespace CodeFixProviderErrorSample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Func<int, int> test = (int n) => n * 2;
        }
    }
}