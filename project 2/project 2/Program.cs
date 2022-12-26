namespace PerfectNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Enter the lower limit: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the upper limit: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("The perfect numbers between {0} and {1} are: ", n1, n2);

            for (int i = n1; i <= n2; i++)
            {
                if (IsPerfect(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsPerfect(int number)
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            return sum == number;
        }
    }
}
