namespace OOP_Lab10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create instance of class
            RecursiveMath recursiveMath = new RecursiveMath();
            //create variables
            int n = 0;
            int m = 0;
            int l = 0;
            //first problem
            Console.WriteLine("Addition");
            while (n == 0)
            {
                try
                {
                    Console.WriteLine("Please enter the first number: ");
                    n = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please Enter a valid number!");
                }
            }
            while (m == 0)
            {
                try
                {
                    Console.WriteLine("Please enter the second number: ");
                    m = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please Enter a valid number!");
                }
            }
            Console.WriteLine("Result: " + recursiveMath.AdditionBetween(n,m));
            Console.WriteLine("Division");
            while (l == 0)
            {
                try
                {
                    Console.WriteLine("Please enter a number to divide: ");
                    l = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please Enter a valid number!");
                }
            }
            Console.WriteLine("Result: " + recursiveMath.EvenDivision(l));
        }
    }
}
