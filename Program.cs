namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Name = "John";
            Console.WriteLine(user);
            Console.WriteLine("End program...");
        }
    }
}
