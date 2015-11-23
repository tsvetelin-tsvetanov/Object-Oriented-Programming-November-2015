using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.EnterNumbers
{
    class EnterNumbers
    {
        static void Main(string[] args)
        {
            short min = 1;
            short max = 100;
            short index = 0;
            short[] numbers = new short[10];
            string errorMessage = "Invalid number! The number must be in range [1...100]";

            while(index < 10)
            {
                short i;
                try
                {
                    i = ReadNumber(min, max, short.Parse(Console.ReadLine()));
                }
                catch (FormatException)
                {
                    Console.WriteLine(errorMessage);
                    continue;
                }
                catch (OverflowException)
                {
                    Console.WriteLine(errorMessage);
                    continue;
                }
                catch(ArgumentOutOfRangeException)
                {
                    Console.WriteLine(errorMessage);
                    continue;
                }
                min = i;
                numbers[index] = i;
                index++;
                errorMessage = "Invalid number! The number must be in range [" + min + "...100]";
            }

            foreach(short sh in numbers)
            {
                Console.Write(sh + " ");
            }
        }

        public static short ReadNumber(short min, short max, short i)
        {
            if(i > max || i < min)
            {
                throw new ArgumentOutOfRangeException();
            }
            return i;
        }
    }
}
