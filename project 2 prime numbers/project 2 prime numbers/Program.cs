public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter The Start Number: ");
        int startNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the End Number : ");
        int endNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("prime numbers between " + startNumber + " and " + endNumber);

        for (int i = startNumber; i <= endNumber; i++)
        {
            int counter = 0;

            for (int j = 2; j <= i / 2; j++)
            {
                if (i % j == 0)
                {
                    counter++;
                    break;
                }
            }

            if (counter==0 && i !=0 )
            {
                Console.WriteLine(i + " the prime number ");

            }
        }
        
    }
}

