using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{

    public class Class1 : ArrayBorders
    {
        public int Border { get; set; }

        public Class1()
        {
            Console.WriteLine("What is the Value, should be more than 0");
            int i = 0;

            while (i < 10)
            {

                string InputString = Console.ReadLine();
                if (InputString.ToString() != string.Empty) // the Convert fails when ""
                {
                    try
                    {
                        Border = Convert.ToInt32(InputString);
                        Console.WriteLine("Border is " + Border);

                        break;
                    }
                    catch (SystemException sex)
                    {
                        // this class's error string
                        string LastError = sex.Message;
                        Console.WriteLine("Incorrect Input, error" + LastError);
                        Console.WriteLine("Try again to populate correct border");
                        i++;

                    }

                }

                else
                {
                    Console.WriteLine("Empty input");
                }
            }
        }
             public override int CheckLowerUpper()
        {
            int result = Border;
            return result;
        }

      
    }
}