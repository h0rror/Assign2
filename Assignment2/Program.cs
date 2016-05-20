using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
        
    class Program
    {
        static void Main(string[] args)
        {
            int x = 50;
            int y = 40;
            int result = 0;

            result = addXandY(x, y);
            Console.WriteLine(result);
            Console.WriteLine();

            addYtoX(ref x, ref y);

            Console.WriteLine(x);

            Console.WriteLine();

            Console.WriteLine(readUntilEnd());

        }

        public static int addXandY(int firstNumber, int secondNumber)
        {
            int result = 0;
            result = firstNumber + secondNumber;
            return result;
        }
     public static int addYtoX(ref int X, ref int Y)
        {
            X += Y;
            return X;
        }

        public static string[]  readUntilEnd()
        {
            string[] inputs = new string[100];
            int inputCounter = 0;

            do
            {
                Console.WriteLine("Enter a value - ('end' to stop): ");
                inputs[inputCounter] = Console.ReadLine();
                if (inputs[inputCounter] == "end")
                {
                    inputCounter = -1;
                }
                else
                {
                    inputCounter++;
                }

            } while (inputCounter != -1);

            return inputs;


            }
        }
    }
    }
}
