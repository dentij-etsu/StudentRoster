namespace StudentRoster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Beep(400 + (i * 200), 500);
            }
        }
    }
}