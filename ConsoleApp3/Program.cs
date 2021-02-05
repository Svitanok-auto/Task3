using System;

namespace ConsoleApp3
{
    public class ArrayBorders
    {
        public virtual int CheckLowerUpper()
        {
            return 0;

        }

    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Set the lower value of the diapason!");
            ArrayBorders border1 = new Class1();
            Console.WriteLine("Lower Border : " + border1.CheckLowerUpper());
            int Lower = border1.CheckLowerUpper();

            Console.WriteLine("Set the upper value of the diapason!");
            ArrayBorders border2 = new Class1();
            Console.WriteLine("Upper Border : " + border2.CheckLowerUpper());
            int Upper = border2.CheckLowerUpper();

            int Number = 0;
            Number = (Upper - Lower + 1);

            Console.WriteLine("Count of values : " + Number);

            int sum = 0;
            if (Number > 10)

            {
                int[] NumberArray = new int[Number];
                int i = 0;
                do
                {
                    NumberArray[i] = Lower + i;
                    Console.WriteLine("Array: " + NumberArray[i]);
                    i++;
                    Console.WriteLine("i: " + i);
                }

                while ((Lower + i <= Upper) && (i <= Number));

                for (int u = 0; u < Number; u++)
                {
                    if ((NumberArray[u] % 3 == 0) && (NumberArray[u] % 5 != 0)) // It is divisible by 3 and not divisible by 5
                    {
                        sum = sum + NumberArray[u];
                    }
                }

                Console.WriteLine("Result Sum : " + sum);

            }
            else
            {
                Console.WriteLine("Less then 10 values diapason, exit");
            }
            }

    }
}
