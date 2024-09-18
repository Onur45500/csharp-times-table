namespace TimesTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number to multiply until 10 :");
            string stringNumber = Console.ReadLine();

            int intNumber = Convert.ToInt32(stringNumber);

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", i, intNumber, i * intNumber);
            }
        }
    }
    
}