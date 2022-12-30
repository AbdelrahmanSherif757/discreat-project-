using System;
public class project
{
    public static void Main()
    {
        int n, i, sum;
        int fristnumber , lastnumber;

        Console.WriteLine("find perfect numbers\n");


        Console.Write(" enter the frist number: ");
         fristnumber = int.Parse(Console.ReadLine());

        Console.Write("enter the last number : ");
         lastnumber = int.Parse(Console.ReadLine());



        for (n = fristnumber; n <= lastnumber; n++)
        {
            i = 1;
            sum = 0;
            while (i < n)
            {
                if (n % i == 0)
                    sum = sum + i;
                i++;
            }
            if (sum == n)
            {
                Console.WriteLine("the perfect numbers :");
                Console.WriteLine("{0} ", n);

            }


        }
        Console.Write("\n");
    }
}