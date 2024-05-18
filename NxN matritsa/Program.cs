public class Program
{
    private static void Main(string[] args)
    {
        NxN_Matrix_No_Array();

    }

    private static void NxN_Matrix()
    {
        Console.Write("Enter the number N: ");
        int n = 0;
        var isInt = true;

        try
        {
            n = Convert.ToInt32(Console.ReadLine());
        }
        catch (System.FormatException ex)
        {
            isInt = false;
            Console.WriteLine(ex.Message);
        }

        var a = new int[n, n];
        var isEven = n % 2 == 0;
        int k = n / 2;

        if (n > 0)
        {
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {

                    if (i == 0 || j == 0 || i == n - 1 || j == n - 1)
                    {
                        a[i, j] = 1;
                    }

                    else
                    {
                        a[i, j] = 0;
                    }

                }

            }

            if (isEven)
            {
                a[k, k] = 1;
                a[k, k - 1] = 1;
                a[k - 1, k] = 1;
                a[k - 1, k - 1] = 1;
            }

            else
            {
                a[k, k] = 1;
            }

            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + "  ");
                }

                Console.Write("\n");

            }
        }

        else
        {
            if (isInt)
            {
                Console.WriteLine("N  must be greater than 0");
            }
            else
            {
                Console.WriteLine("You should have entered n as an integer");
            }
        }
    }
    
    private static void NxN_Matrix_No_Array()
    {
        Console.Write("Enter the number N: ");
        int n = 0;
        var isInt = true;

        try
        {
            n = Convert.ToInt32(Console.ReadLine());
        }
        catch (System.FormatException ex)
        {
            isInt = false;
            Console.WriteLine(ex.Message);
        }

        bool isEven = n % 2 == 0;

        if(n > 0)
        {

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (i == 0 || j == 0 || i == n - 1 || j == n - 1)
                    {
                        Console.Write("1   ");
                    }
                    else
                    {
                        if (isEven && (Math.Abs(n - 1 - 2 * i) < 2 && Math.Abs(n - 1 - 2 * j) < 2))
                        {
                            Console.Write("1   ");
                        }
                        else if(i == n/2 && j == n/2)
                        {
                            Console.Write("1   ");
                        }
                        else
                        {
                            Console.Write("0   ");
                        }
                    }
                }
                Console.WriteLine();
            }

        }
        else
        {
            if (isInt)
            {
                Console.WriteLine("N  must be greater than 0");
            }
            else
            {
                Console.WriteLine("You should have entered n as an integer");
            }
        }
    }
}